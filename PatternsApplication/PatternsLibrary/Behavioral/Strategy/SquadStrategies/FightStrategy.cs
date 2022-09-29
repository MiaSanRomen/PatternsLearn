using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Strategy.SquadStrategies
{
    public class FightStrategy : IStrategy
    {
        public string ScoutAction()
        {
            return "We are fighting!";
        }
    }
}
