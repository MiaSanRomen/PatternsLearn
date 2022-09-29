using Patterns.Library.Behavioral.Visitor.ProgrammingHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Visitor.ConsoleActions
{
    public class ConsoleOutput : IConsoleAction
    {
        private readonly string _argument;

        public ConsoleOutput(string argument)
        {
            _argument = argument;
        }

        public string GetCommand(IProgrammingHelper programmingHelper)
        {
            return programmingHelper.GetOutputCommand(_argument);
        }
    }
}
