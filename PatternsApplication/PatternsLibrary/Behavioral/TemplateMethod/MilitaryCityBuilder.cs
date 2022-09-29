using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.TemplateMethod
{
    public class MilitaryCityBuilder : BaseCityBuilder
    {
        public override string BuildMainHouse()
        {
            return "Taking trees and " + base.BuildMainHouse().ToLower();
        }

        public override string BuildWalls()
        {
            return "Building great stone walls and towers";
        }
    }
}
