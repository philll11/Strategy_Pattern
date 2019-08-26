using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck_Simulation
{
    public class MallardDuck : Duck
    {
        public override string display()
        {
            return "I am a Mallard Duck";
        }

        public override string swim()
        {
            return "I can swim";
        }
    }
}