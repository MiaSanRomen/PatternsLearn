using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Iterator.CustomIterators
{
    public interface ICustomIterator<T> where T : class
    {
        bool HasMore();
        T GetNext();
    }
}
