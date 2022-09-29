using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Patterns.Library.Creational.Prototype
{
    public class LightTank : Tank
    {
        public LightTank(string name, string gun, string engine, string miniGun) : base(name, gun, engine)
        {
            MiniGun = miniGun;
        }

        private string MiniGun { get; set; }

        public override IPrototype Clone()
        {
            return new LightTank(Name, Gun, Engine, MiniGun);
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"MiniGun: {MiniGun}\n";
        }
    }
}
