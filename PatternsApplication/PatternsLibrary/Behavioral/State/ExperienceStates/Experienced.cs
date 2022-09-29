using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.State.ExperienceStates
{
    public class Experienced : IExperienceState
    {
        private SquadWithXp _squad;

        public string Fight()
        {
            return "Soldiers! You know what to do!";
        }

        public string GrowUp()
        {
            _squad.ChangeState(new Veterans());
            return "We are veterans now!";
        }

        public void SetSquad(SquadWithXp squad)
        {
            _squad = squad;
        }

        public string Worse()
        {
            _squad.ChangeState(new Professionals());
            return "Something went wrong...";
        }
    }
}
