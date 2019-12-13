using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    abstract class SweepstakesStackManager : ISweepstakesManager
    {

        public Sweepstakes GetSweepstakes()
        {
            Stack SweepStack = new Stack();
            SweepStack.Pop("Sweepstake1");
            return;
        }

        //how to remove from a stack
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Stack SweepStack = new Stack();
            SweepStack.Push("Sweepstake1");
            SweepStack.Push("Sweetsteak2");
            SweepStack.Push("Sleepstate3");
        }
    }
}

