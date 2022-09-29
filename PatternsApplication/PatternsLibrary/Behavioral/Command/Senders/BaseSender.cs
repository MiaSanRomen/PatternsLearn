using Patterns.Library.Behavioral.Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Command.Senders
{
    public class BaseSender
    {
        protected BaseComand _baseComand;

        public void SetCommand(BaseComand baseComand)
        {
            _baseComand = baseComand;
        }

        public string ExecuteCommand(string destination)
        {
            return _baseComand.ExecuteCommand(destination);
        }
    }
}
