using Patterns.Library.Creational.Builder.Army;
using Patterns.Library.Creational.Builder.CustomBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.Builder
{
    public class Director
    {
        public Legion CreateLegion()
        {
            LegionBuilder armyBuilder = new LegionBuilder();
            armyBuilder.Reset();
            armyBuilder.SetHomeCity();
            armyBuilder.SetCommander();
            armyBuilder.SetPeople();
            return armyBuilder.GetArmy();
        }

        public AuxilaryArmy CreateAuxilary()
        {
            AuxilaryArmyBuilder armyBuilder = new AuxilaryArmyBuilder();
            armyBuilder.Reset();
            armyBuilder.SetHomeCity();
            armyBuilder.SetCommander();
            armyBuilder.SetPeople();
            return armyBuilder.GetArmy();
        }
    }
}
