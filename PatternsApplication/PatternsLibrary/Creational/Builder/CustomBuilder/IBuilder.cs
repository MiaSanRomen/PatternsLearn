using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.Builder.CustomBuilder
{
    public interface IArmyBuilder<T> where T : class
    {
        public void SetHomeCity();
        public void SetCommander();
        public void SetPeople();
        public void Reset();
        public T GetArmy();
    }
}
