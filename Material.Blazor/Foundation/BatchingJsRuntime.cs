using Microsoft.JSInterop;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

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
        private readonly System.Timers.Timer timer = new(10);


        public BatchingJSRuntime(IJSRuntime js)
        {
            this.js = js;
            timer.Elapsed += Timer_Elapsed;
        }


        private async void Timer_Elapsed(object sender, ElapsedEventArgs e)
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


        /// <inheritdoc/>
        public Task InvokeVoidAsync(string identifier, params object[] args)
        {
            var call = new Call(identifier, args);
            queuedCalls.Enqueue(call);
            timer.Start();
            return call.Task;
        }


        /// <inheritdoc/>
        public async Task<T> InvokeAsync<T>(string identifier, params object[] args)
        {
            return await js.InvokeAsync<T>(identifier, args);
        }
    }
}
