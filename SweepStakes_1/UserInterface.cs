using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    
    public static class UserInterface
    {
        public static void PickStackOrQueu()
        {
            Console.WriteLine("Select Stack or Queue");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "Stack":
                    Console.WriteLine("Stack");
                    break;
                    
                case "Queue":
                    Console.WriteLine("Queue");
                    break;

            }
           

        }
        public static string PickSweepstakesName()
        {
            Console.WriteLine("What is the name of Sweepstakes");
            string name = Console.ReadLine();
            return name;
         
        }

       

        
     //public static string AssignContestant(Contestant contestant)
     //   {
            
     //   }
    }
}
