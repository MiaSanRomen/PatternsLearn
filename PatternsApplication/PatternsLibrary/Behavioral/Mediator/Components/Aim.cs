using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Mediator.Components
{
    public class Aim
    {
        IMediator _mediator;

        public Aim(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void NeedToBeFocused()
        {
            Console.WriteLine("Ready to be focussed");
        }

        public void Focus()
        {
            Console.WriteLine("Focusing...");
            _mediator.AimFocused?.Invoke(this, new EventArgs());
        }
    }
}
