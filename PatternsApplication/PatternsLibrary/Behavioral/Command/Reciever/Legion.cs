using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Command.Reciever
{
    public class Legion
    {
        public string MoveTo(string city)
        {
            return $"Legion goes to {city} city.";
        }
        public string Attack(string tribe)
        {
            return $"Legion attacks {tribe} tribe.";
        }
    }
}
