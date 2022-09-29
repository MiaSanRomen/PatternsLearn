using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.Prototype
{
    public class Tank : IPrototype
    {
        public Tank(string name, string gun, string engine)
        {
            Name = name;
            Gun = gun;
            Engine = engine;
        }

        public string Name { get; }
        protected string Gun { get; set; }
        protected string Engine { get; set; }

        public virtual string GetInfo()
        {
            return $"Tank Model: {Name}\n Gun: {Gun}\n Engine: {Engine}\n";
        }

        public virtual IPrototype Clone()
        {
            return new Tank(Name, Gun, Engine);
        }
    }
}
