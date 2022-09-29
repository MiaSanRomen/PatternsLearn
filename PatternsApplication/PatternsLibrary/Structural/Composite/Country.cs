using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Composite
{
    public class Country : IComponent
    {
        private const decimal _taxCoefficient = 1.65m;

        public Country(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public string Name { get; set; }
        public int Population { get; set; }

        public decimal CollectTaxes()
        {
            return _taxCoefficient * Population;
        }
    }
}
