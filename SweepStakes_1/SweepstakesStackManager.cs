using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        int numberOfSweepstakes;
        string ChoosenSweepstakes;
        Stack<Sweepstakes> stack;
        //string nameOfSweepstakes;
     public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            
            stack.Push(sweepstakes);
            numberOfSweepstakes++;

            //Console.WriteLine("Elements in stack: ");
            //foreach (string name in stack)
            //{
            //    Console.WriteLine(name);
            //}
            //string topOfStack = stack.Pop();
            //stack.Push(sweepstakes.nameOfSweepstakes);

            //Console.WriteLine("Elements in stack after Pop and Push(nameOfSweepstakes): ");
            //foreach (string name in stack)
            //{
            //    Console.WriteLine(name);
            //    return;
            //}
           
        }

     public   Sweepstakes GetSweepstakes()
        {

            return stack.Pop();
            

        }



    }
}
