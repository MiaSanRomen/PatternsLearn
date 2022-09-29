using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Decorator
{
    public class FleetTarget : ConcreteTarget
    {
        private int _fleetNumber;
        public FleetTarget(int fleetNumber)
        {
            _fleetNumber = fleetNumber;
        }

        public override string Spy()
        {
            return base.Spy() + $"\n   + Fleet No. {_fleetNumber} of Third Reich";
        }
    }
}
