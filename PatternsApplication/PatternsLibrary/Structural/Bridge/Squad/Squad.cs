using Patterns.Library.Structural.Bridge.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Bridge.Squad
{
    public abstract class Squad
    {
        protected ISoldiers _soldiers;

        public Squad(ISoldiers soldiers)
        {
            _soldiers = soldiers;
        }

        public virtual string Attack()
        {
            return _soldiers.Fight();
        }
        public virtual string Defend()
        {
            return _soldiers.Fight();
        }
        public virtual string Move()
        {
            return _soldiers.Move();
        }
        public virtual string Retreat()
        {
            return _soldiers.RunAway();
        }
    }
}
