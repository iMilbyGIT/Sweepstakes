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

        public string PickWinner(List<Contestant> contestants)
        {
            var random = new Random();
            int index = random.Next(contestants.Count);
            Console.WriteLine(contestants[index]);
            return contestants.ToString(); 
        }

        private void RegisterContestant(Contestant contestant)
        {
            contestant.AddContestant(contestant);
        }

        private void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.RegNumber);
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            
        }
    }
}
