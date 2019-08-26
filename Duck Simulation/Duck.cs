using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_Simulation
{
    public abstract class Duck
    {
        IQuackBehavior _quackBehavior;
        IFlyBehavior _flyBehavior;

        public abstract string swim();
        public abstract string display();

        public void setFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void setQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        public string preformQuack()
        {
            return _quackBehavior.quack();
        }
        public string preformFly()
        {
            return _flyBehavior.fly();
        }
        
    }
}
