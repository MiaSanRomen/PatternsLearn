using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Chain_of_Responsibility
{
    public interface IReinforcement
    {
        public void SetNextReinforcementStage(IReinforcement reinforcement);
        public string VerifySufficiency(int barbarians);

    }
}
