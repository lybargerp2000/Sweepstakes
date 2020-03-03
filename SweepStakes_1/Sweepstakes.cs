using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    public class Sweepstakes
    {
        string nameOfSweepstakes;
        Random random = new Random();
        int contestantNumber;
        int contestantWinner;
        string contestantName;
     public Sweepstakes()
        {
            //SweepstakesDictionary dictionary = new SweepstakesDictionary();

        }

        public void SweepStakes(string name)
        {
            nameOfSweepstakes = UserInterface.PickSweepstakesName();
        }

        public void RegisterContestant(Contestant contestants)
        {
            
            Dictionary<int, string> contestant = new Dictionary<int, string>();
            contestant.Add(contestantNumber,contestantName);
            foreach (KeyValuePair<int, string> pair in contestant)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }

        }

        public void ContestantPickWinner()
        {
            contestantWinner = random.Next(contestantNumber, contestantNumber);
            return;
         
         
        }

        public void PrintContestantInfo(Contestant contestant)
        {
         

        }



    }


}
