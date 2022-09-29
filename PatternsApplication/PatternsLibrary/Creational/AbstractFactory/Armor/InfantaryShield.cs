using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.AbstractFactory.Armor
{
    public class InfantaryShield : Shield
    {
        public InfantaryShield()
        {
            Name = "Scutum";
            Material = "Tree and Steel";
        }
    }
}
