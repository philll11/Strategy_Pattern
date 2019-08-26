using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck_Simulation
{
    public class Quack : IQuackBehavior
    {
        public string quack()
        {
            return "Quack";
        }
    }
}