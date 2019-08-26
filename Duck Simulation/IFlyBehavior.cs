using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Duck_Simulation
{
    public interface IFlyBehavior
    {
        string fly();
    }

    public interface IQuackBehavior
    {
        string quack();
    }
}