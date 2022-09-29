using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Mediator.Components
{
    public class Gun
    {
        IMediator _mediator;

        public Gun(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void CanFire()
        {
            Console.WriteLine("Ready to open fire!");
        }

        public void Reload()
        {
            Console.WriteLine("Reloading...");
            _mediator.GunReloaded?.Invoke(this, new EventArgs());
        }

        public void Fire()
        {
            Console.WriteLine("Fire!");
        }
    }
}
