using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Adapter
{
    public class ProvinceToTribeAdapter : IRomanProvince
    {
        private OccupiedTribe _occupiedTribe;

        public ProvinceToTribeAdapter()
        {
            _occupiedTribe = new OccupiedTribe();
        }

        public string GetCityMayor()
        {
            return _occupiedTribe.GetTribalLeader();
        }

        public string GetCityPriest()
        {
            return _occupiedTribe.GetTribalDruid();
        }

        public string GetCityTreasurer()
        {
            return _occupiedTribe.GetTribalLeaderSon();
        }
    }
}
