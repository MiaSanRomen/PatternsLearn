using Patterns.Library.Behavioral.Visitor.ProgrammingHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Visitor.ConsoleActions
{
    public class ConsoleInput : IConsoleAction
    {
        private readonly string _argument;

        public ConsoleInput(string argument)
        {
            _argument = argument;
        }

        public string GetCommand(IProgrammingHelper programmingHelper)
        {
            return programmingHelper.GetInputCommand(_argument);
        }
    }
}
