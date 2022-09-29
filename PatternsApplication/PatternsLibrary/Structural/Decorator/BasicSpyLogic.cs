using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Decorator
{
    public class BasicSpyLogic : ISpyLogic
    {
        public BasicSpyLogic(string name)
        {
            CallName = name;
        }

        private string CallName { get; set; }

        public string Spy()
        {
            return $"CallName {CallName} started to look after: ";
        }
    }
}
