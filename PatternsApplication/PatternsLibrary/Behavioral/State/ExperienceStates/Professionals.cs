using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.State.ExperienceStates
{
    public class Professionals : IExperienceState
    {
        private SquadWithXp _squad;

        public string Fight()
        {
            return "Soldiers! Take formation! As learned...";
        }

        public string GrowUp()
        {
            _squad.ChangeState(new Experienced());
            return "We are experienced professionals now!";
        }

        public void SetSquad(SquadWithXp squad)
        {
            _squad = squad;
        }

        public string Worse()
        {
            _squad.ChangeState(new Newcomers());
            return "Ah shit, here we go again...";
        }
    }
}
