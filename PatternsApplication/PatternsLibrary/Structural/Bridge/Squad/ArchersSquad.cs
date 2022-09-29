using Patterns.Library.Structural.Bridge.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Bridge.Squad
{
    public class ArchersSquad : Squad
    {
        public ArchersSquad(ISoldiers soldiers) : base(soldiers)
        {
        }

        public override string Attack()
        {
            return _soldiers.TakeFormation() + ' ' + _soldiers.AccurateRetreat();
        }
        public override string Defend()
        {
            return _soldiers.FireAtCommand() + ' ' + base.Defend();
        }
    }
}
