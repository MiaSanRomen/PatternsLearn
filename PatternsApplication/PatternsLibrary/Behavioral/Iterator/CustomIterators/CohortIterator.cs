using Patterns.Library.Behavioral.Iterator.CustomCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Iterator.CustomIterators
{
    public class CohortIterator : ICustomIterator<Cohort>
    {
        private Cohort[] _cohorts;
        private uint _currentPosition;

        public CohortIterator(IArmyIterable<Cohort> army)
        {
            _currentPosition = 0;
            _cohorts = army.getCache();
        }

        public Cohort GetNext()
        {
            if(HasMore())
            {
                var cohort = _cohorts[_currentPosition];
                _currentPosition++;
                return cohort;
            }
            return null;
        }

        public bool HasMore()
        {
            return _currentPosition < _cohorts.Length;
        }
    }
}
