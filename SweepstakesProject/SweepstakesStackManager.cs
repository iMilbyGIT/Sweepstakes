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
        Stack stack = new Stack();

        public abstract Sweepstakes GetSweepstakes();
        public abstract void InsertSweepstakes(Sweepstakes sweepstakes);
    }

}
