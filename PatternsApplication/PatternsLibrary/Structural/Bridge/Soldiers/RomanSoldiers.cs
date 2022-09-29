using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Bridge.Soldiers
{
    public class RomanSoldiers : ISoldiers
    {
        public string AccurateRetreat()
        {
            return "Going back in testudo formation";
        }

        public string Defend()
        {
            return "Fighting in formation";
        }

        public string Fight()
        {
            return "Defending with scutums";
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
            return "Getting gladiuses";
        }

        public string Move()
        {
            return "Moving in formation";
        }

        public string RaiseShields()
        {
            return "Raisng scutums";
        }

        public string RunAway()
        {
            return "Running to eagle";
        }

        public string TakeFormation()
        {
            return "Forming testudo";
        }

        public string ThrowPillums()
        {
            return "Throwing 2 pillums";
        }
    }
}
