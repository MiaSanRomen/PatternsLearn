using Patterns.Library.Behavioral.Observer.LandLords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Observer
{
    public class King
    {
        private ICollection<ILandLord> _landLords;

        public King()
        {
            _landLords = new List<ILandLord>();
        }

        public event EventHandler ArmiesRequested;

        public void AddLandLord(ILandLord landLord)
        {
            if(!_landLords.Contains(landLord))
            {
                _landLords.Add(landLord);
                ArmiesRequested += landLord.BringAnArmy;
            }
        }

        public void RemoveLandLord(ILandLord landLord)
        {
            if (_landLords.Contains(landLord))
            {
                _landLords.Remove(landLord);
                ArmiesRequested -= landLord.BringAnArmy;
            }
        }

        public void GatherArmies()
        {
            ArmiesRequested?.Invoke(this, new EventArgs());
        }
    }
}
