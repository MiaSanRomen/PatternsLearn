using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.Prototype
{
    public class HeavyTank : Tank
    {
        public HeavyTank(string name, string gun, string engine, string additionalEngine) : base(name, gun, engine)
        {
            AdditionalEngine = additionalEngine;
        }

        private string AdditionalEngine { get; set; }

        public override IPrototype Clone()
        {
            return new HeavyTank(Name, Gun, Engine, AdditionalEngine);
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"MiniGun: {AdditionalEngine}\n";
        }
    }
}
