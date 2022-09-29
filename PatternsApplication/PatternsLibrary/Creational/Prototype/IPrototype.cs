using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.Prototype
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
