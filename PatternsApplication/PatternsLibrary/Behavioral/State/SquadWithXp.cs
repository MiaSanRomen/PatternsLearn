using Patterns.Library.Behavioral.State.ExperienceStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.State
{
    public class SquadWithXp
    {
        public IExperienceState State { get; set; }

        public SquadWithXp(IExperienceState state)
        {
            ChangeState(state);
        }

        public void ChangeState(IExperienceState state)
        {
            State = state;
            State.SetSquad(this);
        }

        public string Fight()
        {
            return State.Fight();
        }
    }
}
