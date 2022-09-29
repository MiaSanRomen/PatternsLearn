using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Visitor.ProgrammingHelpers
{
    public class CppHelper : IProgrammingHelper
    {
        public string GetClearCommand()
        {
            return "system(\"clear\");";
        }

        public string GetInputCommand(string inputVariable)
        {
            return $"cin >> {inputVariable};";
        }

        public string GetOutputCommand(string outputText)
        {
            return $"cout << {outputText};";
        }
    }
}
