using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writes to the console what the exact time is.
            Console.WriteLine("Today's date is: " + DateTime.Now);

            // Asking the user for a number            
            Console.WriteLine("\nPlease input a number:");
            // Saves the users input as X
            int X = Convert.ToInt32(Console.ReadLine());
            // Creating a variable for current time
            DateTime currentTime = DateTime.Now;
            // Creating a variable for the current time plus the users inputed amount of hours
            DateTime laterTime = currentTime.AddHours(X);
            // Writing to the console the time it will be with the added users hours
            Console.WriteLine("The time will be {0} in {1} hours.", laterTime, X);
            Console.ReadLine();

        }
    }
}
