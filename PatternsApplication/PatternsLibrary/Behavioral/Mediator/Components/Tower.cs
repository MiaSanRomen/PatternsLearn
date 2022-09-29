using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Mediator.Components
{
    public class Tower
    {
        private IMediator _mediator;

        public Tower(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void TurnTower()
        {
            Console.WriteLine("Moving tower...");
            _mediator.TowerTurned?.Invoke(this, new EventArgs());
        }
    }
}
