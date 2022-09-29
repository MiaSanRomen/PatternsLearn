using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Facade.ArmyLogic
{
    public class Armor
    {
        public string Create()
        {
            return "\n   +Searching for armor";
        }
        public string Fix()
        {
            return "\n   +Fixing armor";
        }
        public string Move()
        {
            return "\n   +Moving armor";
        }
        public string PrepareForFight()
        {
            return "\n   +Preparing armor";
        }
    }
}
