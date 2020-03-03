using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    public class SweepstakesQueeManager : ISweepstakesManager
    {
        Queue<Sweepstakes> queue;
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
            
        }
        
        public void GetSweepstakes()
        {
            queue.Dequeue();
            return;

        }



    }
}
