using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        public string name;
        public Contestant contestant;
        IDictionary<int, string> sweepDict = new Dictionary<int, string>();

        public Sweepstakes(string name)
        {
            this.name = name;
        }

        private void RegisterContestant(Contestant contestant)
        {
            contestant.AddContestant(contestant);
        }

        private void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegNumber);
        }
    }
}
