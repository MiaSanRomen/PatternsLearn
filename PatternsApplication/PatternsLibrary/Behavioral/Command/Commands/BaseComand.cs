using Patterns.Library.Behavioral.Command.Reciever;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Command.Commands
{
    public abstract class BaseComand
    {
        protected Legion _legionUnderControl;

        public BaseComand(Legion legion)
        {
            _legionUnderControl = legion;
        }

        public abstract string ExecuteCommand(string destination);
    }
}
