using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");
            
            // Asks the user for their age and stores it as a string
            Console.WriteLine("\nWhat is your age?");
            string age = Console.ReadLine();
            
            // Askes the user if they had a DUI and stores it as a string
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string DUI = Console.ReadLine();
            
            // Asks the user how many speedign tickets they have and stores it as a string
            Console.WriteLine("How many speeding tickets do you have?");
            string ticket = Console.ReadLine();

            // Will get true if age is greater than 15 and false if not
            bool qualifiedAge = Convert.ToInt32(age) > 15;
            
            // Will get true if DUI equals No and False if DUI equals anything else
            bool qualifiedDUI =  DUI == "No";
            
            // Will get true if the user has 3 or less speeding tickets and false if greater than 3
            bool qualifiedTicket = Convert.ToInt32(ticket) <= 3;

            Console.WriteLine("\nDo you qualify?");
            // If all three are True then the user will qualify
            Console.WriteLine(qualifiedAge && qualifiedDUI && qualifiedTicket);
            Console.ReadLine();
        }
    }
}
