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
            contestants.Add(contestant.RegistrationNumber, contestant);
            
        }

        public Contestant PickWinner()
        {
            
            return contestants[random.Next()];
            
            //foreach (KeyValuePair<int, string> item in contestants)
            //{
            //    Console.WriteLine(item.Key, item.Value);
            //}
            //contestantWinner = random.Next(contestantNumber, contestantNumber);
            
         
         
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            for(int i = 0; i < contestants.Count; i++)
            {
                Console.WriteLine(contestants.Keys.ElementAt(i));
            }
            
            //Console.WriteLine(contestant);

        }



    }


}
