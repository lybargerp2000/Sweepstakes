using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    public class Sweepstakes
    {
        public string name;
        Random random = new Random();
        Dictionary<int, Contestant> contestants;
        //public int contestantNumber;
        //int contestantWinner;
        //string contestantName;
        public Sweepstakes()
        {
            contestants = new Dictionary<int, Contestant>();


        }

        //public void SweepStakes(string name)
        //{
        //    nameOfSweepstakes = UserInterface.PickSweepstakesName();
        //}

        public void RegisterContestant(Contestant contestant)
        {
            
            
            contestants.Add(contestant.registrationNumber, contestant);
            //foreach (KeyValuePair<int, string> pair in contestant)
            //{
            //    Console.WriteLine(pair.Key + " - " + pair.Value);
            //}

        }

        public void PickWinner()
        {
            //contestantWinner = random.Next(contestantNumber, contestantNumber);
            return;
         
         
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant);

        }



    }


}
