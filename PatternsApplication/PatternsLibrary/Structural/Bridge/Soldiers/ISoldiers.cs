using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Bridge.Soldiers
{
    public interface ISoldiers
    {
        public string RaiseShields();
        public string ThrowPillums();
        public string GetSwords();
        public string FireAtWill();
        public string FireAtCommand();
        public string RunAway();
        public string AccurateRetreat();
        public string TakeFormation();
        public string Fight();
        public string Defend();
        public string Move();

    }
}
