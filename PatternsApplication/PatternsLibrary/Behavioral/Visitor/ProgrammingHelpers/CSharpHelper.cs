using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Visitor.ProgrammingHelpers
{
    public class CSharpHelper : IProgrammingHelper
    {
        public string GetClearCommand()
        {
            return "Console.Clear();";
        }

        public string GetInputCommand(string inputVariable)
        {
            return $"var {inputVariable} = Console.Read();";
        }

        public string GetOutputCommand(string outputText)
        {
            return $"Console.WriteLine({outputText});";
        }
    }
}
