using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Observer.LandLords
{
    public class Count : ILandLord
    {
        public void BringAnArmy(object? sender, EventArgs e)
        {
            Console.WriteLine("Count will bring 500 soldiers");
        }
    }
}
