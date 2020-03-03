using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    
    public static class UserInterface
    {
        public static string PickStackOrQueu()
        {
            Console.WriteLine("Select Stack or Queue");
            return Console.ReadLine();


           

        }
        public static string PickSweepstakesName()
        {
            Console.WriteLine("What is the name of Sweepstakes");
            string name = Console.ReadLine();
            return name;
         
        }

    }
}
