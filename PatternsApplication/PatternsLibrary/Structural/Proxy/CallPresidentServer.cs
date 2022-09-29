using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Proxy
{
    public class CallPresidentServer : ICallService
    {
        public bool IsTalkingNow { get; private set; } = false;

        public event EventHandler CallEnded;
        public async Task AskQuestion(string message)
        {
            IsTalkingNow = true;
            await Task.Delay(5000);
            IsTalkingNow = false;
            CallEnded?.Invoke(this, new EventArgs());
            Console.WriteLine($"{DateTime.Now.ToString()} : {message}");
        }
    }
}
