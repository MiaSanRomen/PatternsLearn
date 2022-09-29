using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.TemplateMethod
{
    public abstract class BaseCityBuilder
    {
        public virtual string BuildWalls()
        {
            return "Building tree walls";
        }

        public virtual string BuildMainHouse()
        {
            return "Building main house";
        }

        public virtual string BuildTemple()
        {
            return "Building tree temple";
        }
    }
}
