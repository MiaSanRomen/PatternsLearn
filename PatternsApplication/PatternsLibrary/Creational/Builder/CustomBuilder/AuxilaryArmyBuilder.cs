using Patterns.Library.Creational.Builder.Army;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.Builder.CustomBuilder
{
    public class AuxilaryArmyBuilder : IArmyBuilder<AuxilaryArmy>
    {
        private AuxilaryArmy _auxilaryArmy;

        public AuxilaryArmy GetArmy()
        {
            return _auxilaryArmy;
        }

        public void Reset()
        {
            _auxilaryArmy = new AuxilaryArmy();
        }

        public void SetCommander()
        {
            _auxilaryArmy.Commander = "Decurion";
        }

        public void SetHomeCity()
        {
            _auxilaryArmy.HomeProvince = "Panonia";
        }

        public void SetPeople()
        {
            _auxilaryArmy.Soldiers = 550;
        }
    }
}
