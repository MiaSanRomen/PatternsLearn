using Patterns.Library.Creational.FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.FactoryMethod.Creator
{
    public class BlacksmithShields : IBlacksmith
    {
        public IArmor CreateArmor()
        {
            return new Shield();
        }
    }
}
