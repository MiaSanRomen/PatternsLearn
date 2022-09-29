using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.State.ExperienceStates
{
    public class Veterans : IExperienceState
    {
        private SquadWithXp _squad;

        public string Fight()
        {
            return "Bha, let's kill them all!";
        }

        public string GrowUp()
        {
            return "We are allready death!";
        }

        public void SetSquad(SquadWithXp squad)
        {
            _squad = squad;
        }

        public string Worse()
        {
            _squad.ChangeState(new Experienced());
            return "War was so long ago...";
        }
    }
}
