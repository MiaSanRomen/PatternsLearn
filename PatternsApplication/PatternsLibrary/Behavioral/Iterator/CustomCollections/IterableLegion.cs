using Patterns.Library.Behavioral.Iterator.CustomIterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Iterator.CustomCollections
{
    public class IterableLegion : IArmyIterable<Cohort>
    {
        public ICustomIterator<Cohort> getArmyIterator()
        {
            return new CohortIterator(this);
        }

        public Cohort[] getCache()
        {
            //some tought and difficult logic
            return new Cohort[] { new Cohort("Coh. I"), new Cohort("Coh. II"), new Cohort("Coh. III") };
        }
    }
}
