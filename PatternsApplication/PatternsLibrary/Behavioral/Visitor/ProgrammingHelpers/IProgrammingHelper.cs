using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Visitor.ProgrammingHelpers
{
    public interface IProgrammingHelper
    {
        public string GetOutputCommand(string outputText);
        public string GetInputCommand(string inputVariable);
        public string GetClearCommand();
    }
}
