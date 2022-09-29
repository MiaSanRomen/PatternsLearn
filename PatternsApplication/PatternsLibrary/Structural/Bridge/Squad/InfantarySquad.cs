using Patterns.Library.Structural.Bridge.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Bridge.Squad
{
    public class InfantarySquad : Squad
    {
        public InfantarySquad(ISoldiers soldiers) : base(soldiers)
        {
        }

        public override string Attack()
        {
            return _soldiers.GetSwords() + ' ' + _soldiers.RaiseShields() + ' ' + _soldiers.ThrowPillums() + ' ' + base.Attack();
        }
        public override string Defend()
        {
            return _soldiers.GetSwords() + ' ' + _soldiers.RaiseShields() + ' ' + _soldiers.TakeFormation() + ' ' + base.Defend();
        }
        public override string Move()
        {
            return _soldiers.TakeFormation() + ' ' + _soldiers.Move() + ' ' + _soldiers.TakeFormation() + ' ' + base.Defend();
        }
        public override string Retreat()
        {
            return _soldiers.TakeFormation() + ' ' + _soldiers.AccurateRetreat();
        }
    }
}
