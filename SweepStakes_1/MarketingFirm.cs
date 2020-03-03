using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    //Dependency injection allows the MarketingFirm class to initialize and generate the Sweepstakes
    //managers without having to create new objects in the MaketingFirm class. 
    class MarketingFirm
    {
        ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }
    }
}
