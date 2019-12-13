using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        //    public string FirstName { get; set; }
        //    public string LastName { get; set; }
        //    public string EmailAddress { get; set; }
        //    public int RegNumber { get; set; }
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int regNumber = 1;
        public List<Contestant> contestants = new List<Contestant>();
        // public Contestant contestant = new Contestant();

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
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }
            set
            {
                this.emailAddress = value;
            }
        }
        public int RegNumber
        {
            get
            {
                return this.regNumber;
            }
            set
            {
                this.regNumber = regNumber++;
            }
        }
        //public int GenerateRegNumber()
        //{
        //    return this.regNumber++;
        //}
    }
}
