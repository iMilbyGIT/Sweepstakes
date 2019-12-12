using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    abstract class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<string> queue = new Queue<string>();
        Queue qt = new Queue();
        public abstract Sweepstakes GetSweepstakes();
        public abstract void InsertSweepstakes(Sweepstakes sweepstakes);
    }

}
