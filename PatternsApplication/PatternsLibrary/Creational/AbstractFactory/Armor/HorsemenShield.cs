using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.AbstractFactory.Armor
{
    public class HorsemenShield : Shield
    {
        public HorsemenShield()
        {
            Name = "Horsemen Scutum";
            Material = "Tree";
        }
    }
}
