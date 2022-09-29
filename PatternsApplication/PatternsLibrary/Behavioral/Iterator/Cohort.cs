using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Iterator
{
    public class Cohort
    {
        public Cohort(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
