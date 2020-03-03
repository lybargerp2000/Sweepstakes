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
        public SweepstakesQueeManager()
        {
            queue = new Queue<Sweepstakes>();
        }
      
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
            
        }
        
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
            
        }



    }
}
