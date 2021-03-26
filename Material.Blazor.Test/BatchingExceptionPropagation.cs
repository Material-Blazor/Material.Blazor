using Material.Blazor.Internal;
using Microsoft.JSInterop;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Testing
{
    public class BatchingExceptionPropagation
    {
        [Test]
        public void Message()
        {
            var js_runtime = new Mock<IJSRuntime>()
                .Chain(m => m.Setup(js => js.InvokeAsync<string[]>(It.IsAny<string>(), It.IsAny<object[]>())).ReturnsAsync(new[] { "failed because of XYZ" }))
                .Object;
            var batching_js_runtime = new BatchingJSRuntime(js_runtime);
            var exception = Assert.ThrowsAsync<JSException>(() => batching_js_runtime.InvokeVoidAsync("foo"));
            Assert.IsTrue(exception.Message.Contains("failed because of XYZ"));
        }
        [Test]
        public void PropagateCancelledTask()
        {
            var js_runtime = new Mock<IJSRuntime>()
                .Chain(m => m.Setup(js => js.InvokeAsync<string[]>(It.IsAny<string>(), It.IsAny<object[]>())).ThrowsAsync(new TaskCanceledException()))
                .Object;
            var batching_js_runtime = new BatchingJSRuntime(js_runtime);
            Assert.ThrowsAsync<TaskCanceledException>(() => batching_js_runtime.InvokeVoidAsync("foo"));
        }
    }
}
