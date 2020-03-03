using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes_1
{
    public abstract class Contestant
    {
        //These are established in User Stories
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public Contestant()
        {
            firstName = "";
            lastName = "";
            emailAddress= "";
            registrationNumber = 0;
           

        }
    }

}
