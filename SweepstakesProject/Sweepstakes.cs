using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        private string name;
        public Contestant contestant;
        Dictionary<int, string> dict = new Dictionary<int, string>();
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public string PickWinner(Contestant contestant)
        {
            var random = new Random();
            int index = random.Next(contestant.Count);
            Console.WriteLine(contestant[index]);
            return contestant.ToString(); 
        }
        public void RegisterContestant(Contestant contestant)
        {
            dict.Add(contestant.RegNumber, contestant.FirstName +" "+ contestant.LastName);
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.RegNumber);
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.ReadLine();
        }
    }
}
