using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck_Simulation
{
    public class FlyWithWings : IFlyBehavior
    {
        public string fly()
        {
            return "Fly with wings";
        }
    }
}