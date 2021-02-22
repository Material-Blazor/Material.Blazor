using Microsoft.JSInterop;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Material.Blazor.Internal
{
    /// <inheritdoc/>
    internal class BatchingJsRuntime : IBatchingJsRuntime
    {
        /// <summary>
        /// A javascript call represented by its identifier and arguments
        /// </summary>
        public class Call
        {
            public string Identifier { get; set; }
            public object[] Args { get; set; }
            public Task Task => TaskCompletionSource.Task;
            private TaskCompletionSource TaskCompletionSource { get; set; }
            public Call(string identifier, object[] args)
            {
                Identifier = identifier;
                Args = args;
                TaskCompletionSource = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
            }
            public void MarkComplete()
            {
                TaskCompletionSource.SetResult();
            }
            public void MarkFailed()
            {
                TaskCompletionSource.SetException(new Exception());
            }
        }
        private readonly IJSRuntime js;
        private DateTime last_execution;
        private readonly System.Timers.Timer timer;
        private readonly ConcurrentQueue<Call> calls = new ConcurrentQueue<Call>();
        public BatchingJsRuntime(IJSRuntime js)
        {
            this.js = js;
            timer = new System.Timers.Timer(20);
            timer.Elapsed += Timer_Elapsed;
        }
        private async void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            last_execution = DateTime.UtcNow;
            var some_calls = new List<Call>(capacity: calls.Count);
            while (calls.TryDequeue(out var call))
            {
                some_calls.Add(call);
            }
            if (some_calls.Any())
            {
                var results = await js.InvokeAsync<object[]>("MaterialBlazor.BatchingJsRuntime.applyBatch", some_calls);
                foreach (var (call, result) in some_calls.Zip(results, (c, r) => (c, r)))
                {
                    if (result == null)
                    {
                        call.MarkComplete();
                    }
                    else
                    {
                        call.MarkFailed();
                    }
                }
            }
        }
        /// <inheritdoc/>
        public async Task InvokeVoidAsync(string identifier, params object[] args)
        {
            await js.InvokeVoidAsync(identifier, args);
            return;
            var call = new Call(identifier, args);
            calls.Enqueue(call);
            timer.Stop();
            timer.Start();
            await call.Task;
        }

        /// <inheritdoc/>
        public ValueTask<T> InvokeAsync<T>(string identifier, params object[] args)
        {
            return js.InvokeAsync<T>(identifier, args);
        }
    }
}
