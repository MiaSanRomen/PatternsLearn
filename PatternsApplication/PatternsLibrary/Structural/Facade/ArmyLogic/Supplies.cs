using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Facade.ArmyLogic
{
    public class Supplies
    {
        public string Create()
        {
            return "\n   +Creating supplies";
        }
        public string Move()
        {
            return "\n   +Moving supplies";
        }
        public string Protect()
        {
            return "\n   +Protecting supplies";
        }
    }
}
