using Patterns.Library.Creational.Builder.Army;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.Builder.CustomBuilder
{
    public class LegionBuilder : IArmyBuilder<Legion>
    {
        private Legion _legion;

        public Legion GetArmy()
        {
            return _legion;
        }

        public void Reset()
        {
            _legion = new Legion();
        }

        public void SetCommander()
        {
            _legion.CommanderTitle = "Legate";
        }

        public void SetHomeCity()
        {
            _legion.HomeCity = "Rome";
            _legion.Banner = "Aquila";
        }

        public void SetPeople()
        {
            _legion.Legioners = 5500;
        }
    }
}
