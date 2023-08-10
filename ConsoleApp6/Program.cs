using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    using System;


class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter birthdate  (full numbers) (ddMMyyyy): "); // writes what is within the ""
            string input = Console.ReadLine(); // Makes it so the program can interact with the numbers that are put in

            DateTime birthday = DateTime.ParseExact(input, "ddMMyyyy", null); // creates the 
            DateTime now = DateTime.Now; // takes the date it is today and uses it to say how old you are if am not mistaken.

            TimeSpan difference = now - birthday; // makes the calculations needed for the anwser it will give later down

            int years = difference.Days / 365; // Has info about days in a year
            int days = difference.Days % 365; // has info about the days in the days of the year

            Console.WriteLine($"You are {years} years and {days} days old."); // writes out how old you are in years and days
        }
    }


}
// used online help for this one more then the others i must admit. also much like the other projtects this one is not to fond of the debugging start option