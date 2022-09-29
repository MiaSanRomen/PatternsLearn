using Patterns.Library.Creational.AbstractFactory.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.AbstractFactory.Blacksmith
{
    public class HorsemenBlacksmith : IArmorBlacksmith
    {
        public Shield CreateShield()
        {
            return new HorsemenShield();
        }

        public Sword CreateSword()
        {
            return new HorsemenSword();
        }
    }
}
