using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    class MarketingFirm
    {
        ISweepstakesManager Sweepstakes;

        public MarketingFirm(ISweepstakesManager Sweepstakes)
        {
            this.Sweepstakes = Sweepstakes;
            //As per User Stories
            Sweepstakes sweepstakes = new Sweepstakes();
        }
    }
}
