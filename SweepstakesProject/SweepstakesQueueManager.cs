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
        Queue<Sweepstakes> SweepQueue = new Queue<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            return SweepQueue.Dequeue();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            SweepQueue.Enqueue(sweepstakes);
        }
    }

}
