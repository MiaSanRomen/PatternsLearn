using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Flyweight
{
    public class Legionary
    {
        public Legionary(string name, ArmorType armorType)
        {
            Name = name;
            Armor = ArmorFactory.GetArmor(armorType);
        }

        public string Name { get; set; }
        public Armor Armor { get; set; }
    }
}
