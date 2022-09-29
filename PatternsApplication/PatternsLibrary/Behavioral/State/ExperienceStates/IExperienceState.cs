using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.State.ExperienceStates
{
    public interface IExperienceState
    {
        public void SetSquad(SquadWithXp squad);
        public string Fight();
        public string GrowUp();
        public string Worse();
    }
}
