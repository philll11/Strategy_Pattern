﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck_Simulation
{
    public class FlyNoWay : IFlyBehavior
    {
        public string fly()
        {
            return "I cannot fly";
        }
    }
}