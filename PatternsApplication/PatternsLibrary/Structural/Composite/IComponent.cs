using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Composite
{
    public interface IComponent
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public decimal CollectTaxes();
    }
}
