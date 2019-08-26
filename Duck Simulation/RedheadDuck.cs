using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck_Simulation
{
    public class RedheadDuck : Duck
    {
        public override string display()
        {
            return "I am a Readhead Duck";
        }

        public override string swim()
        {
            return "I can swimg";
        }
    }
}