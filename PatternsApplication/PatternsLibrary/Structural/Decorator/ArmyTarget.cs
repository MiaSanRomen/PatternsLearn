using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Decorator
{
    public class ArmyTarget : ConcreteTarget
    {
        private int _armyNumber;
        public ArmyTarget(int armyNumber)
        {
            _armyNumber = armyNumber;
        }

        public override string Spy()
        {
            return base.Spy() + $"\n   + Army No. {_armyNumber} of Third Reich";
        }
    }
}
