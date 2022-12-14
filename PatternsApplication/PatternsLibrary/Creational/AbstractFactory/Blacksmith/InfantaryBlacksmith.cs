using Patterns.Library.Creational.AbstractFactory.Armor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.AbstractFactory.Blacksmith
{
    public class InfantaryBlacksmith : IArmorBlacksmith
    {
        public Shield CreateShield()
        {
            return new InfantaryShield();
        }

        public Sword CreateSword()
        {
            return new InfantarySword();
        }
    }
}
