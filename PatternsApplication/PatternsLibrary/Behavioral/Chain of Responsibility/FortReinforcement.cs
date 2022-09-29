﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Behavioral.Chain_of_Responsibility
{
    public class FortReinforcement : BasicReinforcement
    {
        public FortReinforcement(int soldiers, string reinforcementName) : base(soldiers, reinforcementName)
        {
        }
    }
}
