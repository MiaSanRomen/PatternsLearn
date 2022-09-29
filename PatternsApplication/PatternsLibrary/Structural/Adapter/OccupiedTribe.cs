using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Adapter
{
    public class OccupiedTribe
    {
        public string GetTribalLeader()
        {
            return "tribal leader";
        }
        public string GetTribalLeaderSon()
        {
            return "tribal leader son";
        }
        public string GetTribalDruid()
        {
            return "local druid";
        }
    }
}
