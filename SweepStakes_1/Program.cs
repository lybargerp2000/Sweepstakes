//using SweepStakes_1.Dictionary;
//using DataStructuresCode.HashSet;
//using DataStructuresCode.LinkedList;
//using DataStructuresCode.List;
//using DataStructuresCode.ObservableCollection;
//using DataStructuresCode.Queue;
//using DataStructuresCode.SortedList;
//using DataStructuresCode.Stack;

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
            SweepstakesStackManager sweepstakes = new SweepstakesStackManager();
            MarketingFirm marketingFirm = new MarketingFirm(sweepstakes);

            //Dictionary
            //Console.WriteLine("Dictionary");
            //SweepstakesDictionary dictionary = new SweepstakesDictionary();
            //dictionary.DisplayAnimalCategorization();
            //dictionary.DisplayMonthSeason();
            //dictionary.DisplayEmployeeIdName();
        }
    }
}
