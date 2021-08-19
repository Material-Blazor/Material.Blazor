using Microsoft.JSInterop;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Material.Blazor.Internal
{
    /// <inheritdoc/>
    internal class BatchingJSRuntime : IBatchingJSRuntime
    {
        /// <summary>
        /// A javascript call represented by its identifier and arguments
        /// </summary>
        private class Call
        {
            public string Identifier { get; private set; }

            public object[] Args { get; private set; }

            public TaskCompletionSource TaskCompletionSource { get; private set; }

            public Task Task => TaskCompletionSource.Task;

            public Call(string identifier, object[] args)
            {
                Identifier = identifier;
                Args = args;
                TaskCompletionSource = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
            }
        }


        private readonly IJSRuntime js;
        private readonly ConcurrentQueue<Call> queuedCalls = new();
        private readonly Architecture OSArchitecture = RuntimeInformation.OSArchitecture;

        public BatchingJSRuntime(IJSRuntime js)
        {
            this.js = js;
        }


        /// <inheritdoc/>
        public Task InvokeVoidAsync(MBBatchingWrapper batchingWrapper, string identifier, params object[] args)
        {
            if (OSArchitecture == Architecture.Wasm || batchingWrapper == null)
            {
                return js.InvokeVoidAsync(identifier, args).AsTask();
            }

            var call = new Call(identifier, args);
            queuedCalls.Enqueue(call);
            return call.Task;
        }


        /// <inheritdoc/>
        public async Task<T> InvokeAsync<T>(string identifier, params object[] args)
        {
            return await js.InvokeAsync<T>(identifier, args);
        }


        public async Task FlushBatchAsync()
        {
            List<Call> batch = new();

            while (queuedCalls.TryDequeue(out var call))
            {
                batch.Add(call);
            }

            if (!batch.Any())
            {
                return;
            }
            try
            {
                var errors = await js.InvokeAsync<string[]>("MaterialBlazor.Batching.apply", batch);
                foreach (var (call, error) in batch.Zip(errors))
                {
                    if (error != null)
                    {
                        call.TaskCompletionSource.SetException(new JSException(error));
                    }
                    else
                    {
                        call.TaskCompletionSource.SetResult();
                    }
                }
            }
            catch (Exception ex)
            {
                foreach (var call in batch)
                {
                    if (!call.TaskCompletionSource.Task.IsCompleted)
                    {
                        call.TaskCompletionSource.SetException(ex);
                    }
                }
            }
        }
    }
}
