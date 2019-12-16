using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class UserInterface
    {
        static int regNum = 0;
        public static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("What is your email address?");
            return Console.ReadLine();
        }

        public static int GetRegNumber()
        {
            regNum += 1;
            Console.WriteLine("Your registered number is: " + regNum);
            return regNum;
        }
    }
}
