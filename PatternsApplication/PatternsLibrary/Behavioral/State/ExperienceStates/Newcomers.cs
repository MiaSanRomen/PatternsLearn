using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.State.ExperienceStates
{
    public class Newcomers : IExperienceState
    {
        private SquadWithXp _squad;

        public string Fight()
        {
            return "Tactics? What does this word mean?..";
        }

        public string GrowUp()
        {
            _squad.ChangeState(new Professionals());
            return "We are professionals now!";
        }

        public void SetSquad(SquadWithXp squad)
        {
            _squad = squad;
        }

        public string Worse()
        {
            return "Can't get any worse...";
        }
    }
}
