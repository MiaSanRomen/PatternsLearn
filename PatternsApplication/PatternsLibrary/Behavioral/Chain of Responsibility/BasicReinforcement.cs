using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Chain_of_Responsibility
{
    public abstract class BasicReinforcement : IReinforcement
    {
        protected int _availiableSoldiers;
        protected string _reinforcementName;
        protected IReinforcement? _nextReinforcementStage;

        public BasicReinforcement(int soldiers, string reinforcementName)
        {
            _availiableSoldiers = soldiers;
            _reinforcementName = reinforcementName;
        }

        public void SetNextReinforcementStage(IReinforcement reinforcement)
        {
            _nextReinforcementStage = reinforcement;
        }

        public virtual string VerifySufficiency(int barbarians)
        {
            if(barbarians > _availiableSoldiers && _nextReinforcementStage != null)
            {
                return _nextReinforcementStage.VerifySufficiency(barbarians);
            }
            else
            {
                return _reinforcementName;
            }
        }
    }
}
