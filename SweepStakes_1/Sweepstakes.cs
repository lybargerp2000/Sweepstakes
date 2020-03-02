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
            SweepstakesDictionary dictionary = new SweepstakesDictionary();

        }

        public void SweepStakes(string name)
        {
         
        }

        public void RegisterContestant(Contestant contestant)
        {
            Dictionary<string, string> contestant = new Dictionary<string, string>();
            contestant.Add("","");
            foreach (KeyValuePair<string, string> pair in contestant)
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
