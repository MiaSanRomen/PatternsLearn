using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Facade.ArmyLogic
{
    public class Soldiers
    {
        public string Search()
        {
            return "\n   +Searching for soldiers";
        }
        public string Train()
        {
            return "\n   +Training soldiers";
        }
        public string Move()
        {
            return "\n   +Moving soldiers";
        }
        public string Fight()
        {
            return "\n   +Soldiers are fighting";
        }
    }
}
