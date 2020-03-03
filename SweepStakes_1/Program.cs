
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SweepStakes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ISweepstakesManager manager = null;
            string choice = UserInterface.PickStackOrQueu();
            switch (choice)
            {
                case "Stack":
                    manager = new SweepstakesStackManager();
                    break;

                case "Queue":
                    manager = new SweepstakesQueeManager();

                    break;

            }
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}
