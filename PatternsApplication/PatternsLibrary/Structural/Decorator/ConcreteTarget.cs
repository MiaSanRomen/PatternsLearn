using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Decorator
{
    public abstract class ConcreteTarget : ISpyLogic
    {
        ISpyLogic _spyLogic;

        public void AddTargetToSpy(ISpyLogic spyLogic)
        {
            _spyLogic = spyLogic;
        }

        public virtual string Spy()
        {
            return _spyLogic.Spy();
        }
    }
}
