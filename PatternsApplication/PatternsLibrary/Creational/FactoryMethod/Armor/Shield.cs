﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.FactoryMethod.Product
{
    public class Shield : IArmor
    {
        public string GetArmor()
        {
            return "Shield";
        }
    }
}