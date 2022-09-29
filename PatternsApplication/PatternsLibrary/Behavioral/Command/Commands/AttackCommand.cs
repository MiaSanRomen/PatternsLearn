using Patterns.Library.Behavioral.Command.Reciever;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Command.Commands
{
    public class AttackCommand : BaseComand
    {
        public AttackCommand(Legion legion) : base(legion)
        {
        }

        public override string ExecuteCommand(string destination)
        {
            return _legionUnderControl.Attack(destination);
        }
    }
}
