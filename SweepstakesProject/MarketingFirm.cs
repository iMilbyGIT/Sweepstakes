﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
   public class MarketingFirm
   {
        ISweepstakesManager SweepstakesManager;

        public MarketingFirm(ISweepstakesManager SweepstakesManager)
        {
            this.SweepstakesManager = SweepstakesManager;
        }
   }
}
