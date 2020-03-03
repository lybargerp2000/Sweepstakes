using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //int numberOfSweepstakes;
        //string ChoosenSweepstakes;
        Stack<Sweepstakes> stack;
        //string nameOfSweepstakes;
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            
            stack.Push(sweepstakes);
           
        }

     public void GetSweepstakes()
        {

            stack.Pop();
            return;
            

        }



    }
}
