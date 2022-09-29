using Patterns.Library.Behavioral.Iterator.CustomIterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Iterator.CustomCollections
{
    public interface IArmyIterable<T> where T : class
    {
        public T[] getCache();
        public ICustomIterator<Cohort> getArmyIterator();
    }
}
