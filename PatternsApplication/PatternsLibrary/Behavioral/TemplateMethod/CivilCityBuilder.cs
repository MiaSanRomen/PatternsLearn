using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.TemplateMethod
{
    public class CivilCityBuilder : BaseCityBuilder
    {
        public override string BuildMainHouse()
        {
            return "Taking stones and " + base.BuildMainHouse().ToLower();
        }

        public override string BuildTemple()
        {
            return "Building great Jupiter Temple";
        }
    }
}
