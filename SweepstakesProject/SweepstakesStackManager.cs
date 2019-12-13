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
        Stack SweepStack = new Stack();
        public abstract Sweepstakes GetSweepstakes();
        //how to remove from a stack
        public abstract void InsertSweepstakes(Sweepstakes sweepstakes);
        //how to add to to stack
    }
}

