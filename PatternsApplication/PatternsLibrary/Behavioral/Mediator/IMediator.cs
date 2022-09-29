using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Mediator
{
    public interface IMediator
    {
        EventHandler<EventArgs> TowerTurned { get;  set; }
        EventHandler<EventArgs> GunReloaded { get; set; }
        EventHandler<EventArgs> AimFocused { get; set; }
    }
}
