using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
   public class MarketingFirm
   {
        public ISweepstakesManager SweepstakesManager;

        public MarketingFirm(ISweepstakesManager SweepstakesManager)
        {
            this.SweepstakesManager = SweepstakesManager;
        }

   }
}
