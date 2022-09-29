using Patterns.Library.Behavioral.Strategy.SquadStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Strategy
{
    public class ScoutSquad
    {
        public IStrategy Strategy { get;  set; }

        public ScoutSquad()
        {
            Strategy = new SearchStrategy();
        }

        public string Activity()
        {
            return Strategy.ScoutAction();
        }
    }
}
