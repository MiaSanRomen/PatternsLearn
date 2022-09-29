using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Bridge.Soldiers
{
    public class GreekSoldiers : ISoldiers
    {
        public string AccurateRetreat()
        {
            return "Going back in phalanx formation";
        }

        public string Defend()
        {
            return "Fighting";
        }

        public string Fight()
        {
            return "Defending with hastas";
        }

        public string FireAtCommand()
        {
            return "Waiting for command.";
        }

        public string FireAtWill()
        {
            return "Shooting them down";
        }

        public string GetSwords()
        {
            return "Getting xiphoses";
        }

        public string Move()
        {
            return "Moving in rythm";
        }

        public string RaiseShields()
        {
            return "Raisng hoplones";
        }

        public string RunAway()
        {
            return "Running back";
        }

        public string TakeFormation()
        {
            return "Forming phalanx";
        }

        public string ThrowPillums()
        {
            return "Throwing stones";
        }
    }
}
