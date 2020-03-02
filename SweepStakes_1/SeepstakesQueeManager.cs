using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    public class SeepstakesQueeManager : ISweepstakesManager
    {
        public void StartQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Frank");
        }
        




    }
}
