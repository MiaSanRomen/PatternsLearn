using Patterns.Library.Structural.Facade.ArmyLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Structural.Facade
{
    public class CommanderFacade
    {
        public string PrepareLegion()
        {
            Armor armor = new Armor();
            Soldiers soldiers = new Soldiers();
            Supplies supplies = new Supplies();
            return "Prepare Legion:" + armor.Create() + soldiers.Search() + supplies.Create();
        }
        public string TrainSoldiers()
        {
            Armor armor = new Armor();
            Soldiers soldiers = new Soldiers();
            return "Train soldiers:" + armor.Fix() + soldiers.Train();
        }
        public string SendLegion()
        {
            Armor armor = new Armor();
            Soldiers soldiers = new Soldiers();
            Supplies supplies = new Supplies();
            return "Send legion:" + armor.Move() + soldiers.Move() + supplies.Move();
        }
        public string DefeatEnemy()
        {
            Armor armor = new Armor();
            Soldiers soldiers = new Soldiers();
            Supplies supplies = new Supplies();
            return "Defeat enemy:" + armor.PrepareForFight() + soldiers.Fight() + supplies.Protect();
        }
    }
}
