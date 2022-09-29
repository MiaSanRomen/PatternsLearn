using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Composite
{
    public class Province : IComponent
    {
        private ICollection<City> _cities;
        private ICollection<Country> _villages;

        public Province(string name)
        {
            Name = name;
            _cities = new List<City>();
            _villages = new List<Country>(); 
        }

        public string Name { get; set; }
        public int Population { get; set; }

        public decimal CollectTaxes()
        {
            decimal taxes = 0;
            Population = 0;
            foreach (var city in _cities)
            {
                taxes += city.CollectTaxes();
                Population += city.Population;
            }

            foreach (var village in _villages)
            {
                taxes += village.CollectTaxes();
                Population += village.Population;
            }

            return taxes;
        }
        
        public void AddCity(City city)
        {
            _cities.Add(city);
        }

        public void AddVillage(Country country)
        {
            _villages.Add(country);
        }
    }
}
