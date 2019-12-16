using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int regNumber;
        public List<Contestant> contestants;
        public Contestant contestant;

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
        public string FirstName
        {
            get 
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }
        public int RegNumber
        {
            get
            {
                return regNumber;
            }
            set
            {
                regNumber = regNumber++;
            }
        }
    }
}
