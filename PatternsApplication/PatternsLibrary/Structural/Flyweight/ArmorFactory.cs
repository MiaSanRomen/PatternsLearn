using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Flyweight
{
    public class ArmorFactory
    {
        public static Dictionary<ArmorType, Armor> armorStorage = new Dictionary<ArmorType, Armor>();

        public static Armor GetArmor(ArmorType armorType)
        {
            if(armorStorage.ContainsKey(armorType))
            {
                return armorStorage[armorType];
            }
            else
            {
                var armor = new Armor(armorType);
                armorStorage.Add(armorType, armor);
                return armor;
            }
        }
    }
}
