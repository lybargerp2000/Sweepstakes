using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    public class Sweepstakes
    {
     public Sweepstakes()
        {
            //SweepstakesDictionary dictionary = new SweepstakesDictionary();

        }

        public void SweepStakes(string name)
        {
         
        }

        public void RegisterContestant(Contestant contestants)
        {
            Dictionary<int, string> contestant = new Dictionary<int, string>();
            contestant.Add(0,"");
            foreach (KeyValuePair<int, string> pair in contestant)
            {
                Console.WriteLine(pair.Key + "-" + pair.Value);
            }

        }

        public void ContestantPickWinner()
        {
         
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }



    }


}
