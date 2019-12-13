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
        Stack<Sweepstakes> SweepStack = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            return SweepStack.Pop();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            SweepStack.Push(sweepstakes);
        }
    }
}
