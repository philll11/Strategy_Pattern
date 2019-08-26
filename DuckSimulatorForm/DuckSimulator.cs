using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duck_Simulation
{
    public partial class DuckSimulator : Form
    {
        Duck _duck;
        
        public DuckSimulator()
        {
            InitializeComponent();
        }

        private void MallardRB_CheckedChanged(object sender, EventArgs e)
        {
            _duck = new MallardDuck();
            _duck.setFlyBehavior(new FlyWithWings());
            _duck.setQuackBehavior(new Quack());
        }

        private void ReadheadRB_CheckedChanged(object sender, EventArgs e)
        {
            _duck = new RedheadDuck();
            _duck.setFlyBehavior(new FlyWithWings());
            _duck.setQuackBehavior(new Quack());
        }

        private void RubberRB_CheckedChanged(object sender, EventArgs e)
        {
            _duck = new RubberDuck();
            _duck.setFlyBehavior(new FlyNoWay());
            _duck.setQuackBehavior(new Squeak());
        }

        private void DecoyRB_CheckedChanged(object sender, EventArgs e)
        {
            _duck = new DecoyDuck();
            _duck.setFlyBehavior(new FlyNoWay());
            _duck.setQuackBehavior(new MuteQuack());
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            displayLbl.Text = _duck.display();
        }

        private void QuackBtn_Click(object sender, EventArgs e)
        {
            displayLbl.Text = _duck.preformQuack();
        }

        private void FlyBtn_Click(object sender, EventArgs e)
        {
            displayLbl.Text = _duck.preformFly();
        }
    }
}
