using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Observer.LandLords
{
    public interface ILandLord
    {
        public void BringAnArmy(object? sender, EventArgs e);
    }
}
