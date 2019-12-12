using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int regNumber;
        List<Contestant> contestants = new List<Contestant>();

        public Contestant(string firstName, string lastName, string emailAddress, int regNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.regNumber = regNumber;
        }
        public void AddContestant(Contestant contestant)
        {
            contestants.Add(contestant);
        }
    }
}
