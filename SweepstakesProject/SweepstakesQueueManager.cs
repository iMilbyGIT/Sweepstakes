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
        public abstract Sweepstakes GetSweepstakes();
        //how to remove from a queue
        public abstract void InsertSweepstakes(Sweepstakes sweepstakes);
        //how to add to to queue

        Queue SweepQueue = new Queue();
        
    }

}
