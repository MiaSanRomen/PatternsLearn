using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Proxy
{
    public class CallProxy : ICallService
    {
        CallPresidentServer _callService;
        private ConcurrentQueue<object> _queue;

        public CallProxy(CallPresidentServer callService)
        {
            _callService = callService;
            _queue = new ConcurrentQueue<object>();
            _callService.CallEnded += OnCallEnded;
        }

        private async void OnCallEnded(object? sender, EventArgs e)
        {
            object message;
            var result = _queue.TryPeek(out message);
            if(result && message != null)
            {
                await _callService.AskQuestion((string)message);
            }
        }

        public async Task AskQuestion(string message)
        {
            if(_callService.IsTalkingNow)
            {
                _queue.Append(message);
            }
            else
            {
                await _callService.AskQuestion(message);
            }
        }
    }
}
