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
        public Sweepstakes GetSweepstakes()
        {
            Queue SweepQueue = new Queue();
            SweepQueue.Enqueue("Sweepstake1");
            return SweepQueue
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Queue SweepQueue = new Queue();
            SweepQueue.Enqueue("Sweepstake1");
            SweepQueue.Enqueue("Sweetsteak2");
            SweepQueue.Enqueue("Sleepstate3");
        }
    }

}
