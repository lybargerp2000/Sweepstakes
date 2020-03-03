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
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            
            stack.Push(sweepstakes);
           
        }

     public Sweepstakes GetSweepstakes()
        {

            return stack.Pop();
            
            

        }



    }
}
