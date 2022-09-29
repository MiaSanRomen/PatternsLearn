using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Adapter
{
    public interface IRomanProvince
    {
        public string GetCityMayor();
        public string GetCityTreasurer();
        public string GetCityPriest();
    }
}
