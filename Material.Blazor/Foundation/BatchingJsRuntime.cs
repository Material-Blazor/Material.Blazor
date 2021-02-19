using Microsoft.JSInterop;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace Material.Blazor.Internal
{
    internal class BatchingJsRuntime : IBatchingJsRuntime
    {
        public class Call
        {
            public string Identifier { get; set; }
            public object[] Args { get; set; }
            public Call(string identifier, object[] args)
            {
                Identifier = identifier;
                Args = args;
            }
        }
        private readonly IJSRuntime js;
        private DateTime last_execution;
        private readonly Timer timer;
        private readonly ConcurrentQueue<Call> calls = new ConcurrentQueue<Call>();
        public BatchingJsRuntime(IJSRuntime js)
        {
            this.js = js;
            timer = new Timer(20);
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            last_execution = DateTime.UtcNow;
            var some_calls = new List<Call>(capacity: calls.Count);
            while (calls.TryDequeue(out var call))
            {
                some_calls.Add(call);
            }
            if (some_calls.Any())
            {
                _ = js.InvokeVoidAsync("MaterialBlazor.BatchingJsRuntime.applyBatch", some_calls);
            }
        }

        public async Task InvokeVoidAsync(string identifier, params object[] args)
        {
            calls.Enqueue(new Call(identifier, args));
            if (last_execution.AddMilliseconds(20) < DateTime.UtcNow)
            {
                last_execution = DateTime.UtcNow;
                var some_calls = new List<Call>(capacity: calls.Count);
                while (calls.TryDequeue(out var call))
                {
                    some_calls.Add(call);
                }
                if (some_calls.Any())
                {
                    await js.InvokeVoidAsync("MaterialBlazor.BatchingJsRuntime.applyBatch", some_calls);
                }
            }
            else
            {
                timer.Stop();
                timer.Start();
            }
        }

        public ValueTask<T> InvokeAsync<T>(string identifier, params object[] args)
        {
            return js.InvokeAsync<T>(identifier, args);
        }
    }
}
