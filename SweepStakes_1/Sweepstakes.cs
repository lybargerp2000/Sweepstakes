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
        public Sweepstakes()
        {
            contestants = new Dictionary<int, Contestant>();

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
            
        }

        public Contestant PickWinner()
        {
            return contestants[random.Next(contestants.Count)];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Email Address: " + contestant.EmailAddress + " First Name: " + contestant.FirstName + "Last Name: " + contestant.LastName + "Registration Number: " + contestant.RegistrationNumber);
        }
    }

}
