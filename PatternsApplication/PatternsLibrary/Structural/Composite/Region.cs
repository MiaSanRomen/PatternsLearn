using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Composite
{
    public class Region : IComponent
    {
        private ICollection<Province> _provinces;

        public Region(string name)
        {
            Name = name;
            _provinces = new List<Province>();
        }

        public string Name { get; set; }
        public int Population { get; set; }

        public decimal CollectTaxes()
        {
            decimal taxes = 0;
            Population = 0;
            foreach (var province in _provinces)
            {
                taxes += province.CollectTaxes();
                Population += province.Population;
            }
            return taxes;
        }

        public void AddProvince(Province province)
        {
            _provinces.Add(province);
        }
    }
}
