using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Proxy
{
    public interface ICallService
    {
        public Task AskQuestion(string message);
    }
}
