using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Strategy.SquadStrategies
{
    public class RetreatStrategy : IStrategy
    {
        public string ScoutAction()
        {
            return "We are running to base!";
        }
    }
}
