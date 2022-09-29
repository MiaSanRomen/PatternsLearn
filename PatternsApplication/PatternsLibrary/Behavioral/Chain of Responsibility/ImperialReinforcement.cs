using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Chain_of_Responsibility
{
    public class ImperialReinforcement : BasicReinforcement
    {
        public ImperialReinforcement(int soldiers, string reinforcementName) : base(soldiers, reinforcementName)
        {
        }

        public override string VerifySufficiency(int barbarians)
        {
            if(barbarians < _availiableSoldiers)
            {
                return base.VerifySufficiency(barbarians);
            }
            return "All availiable soldiers in whole empire";
        }
    }
}
