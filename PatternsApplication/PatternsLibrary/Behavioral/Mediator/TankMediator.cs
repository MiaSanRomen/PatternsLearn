using Patterns.Library.Behavioral.Mediator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Mediator
{
    public class TankMediator : IMediator
    {
        public EventHandler<EventArgs> TowerTurned { get; set; }
        public EventHandler<EventArgs> GunReloaded { get; set; }
        public EventHandler<EventArgs> AimFocused { get; set; }

        public TankMediator()
        {
            Aim = new Aim(this);
            Gun = new Gun(this);
            Tower = new Tower(this);
            TowerTurned += OnTowerTurned;
            GunReloaded += OnGunReloaded;
            AimFocused += OnAimFocused;
        }

        public Aim Aim { get; set; }
        public Gun Gun { get; set; }
        public Tower Tower { get; set; }

        private void OnTowerTurned(object? sender, EventArgs e)
        {
            Aim.NeedToBeFocused();
        }

        private void OnGunReloaded(object? sender, EventArgs e)
        {
            Aim.NeedToBeFocused();
        }

        private void OnAimFocused(object? sender, EventArgs e)
        {
            Gun.CanFire();
        }
    }
}
