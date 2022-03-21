using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays The Tech Academy and Student daily Report on the top of the page on seperate lines
            Console.WriteLine("The Tech Academy" +
                "\nStudent Daily Report");
          
            // Asks the user to unput their name and saves it as a string
            Console.WriteLine("\nWhat is your name?");
            string yourName = Console.ReadLine();
            
            // Asks the user to unput what course they are on and saves it as a string
            Console.WriteLine("What Course are you on?");
            string course = Console.ReadLine();

            //Asks the user to input what page number they are on as a string and converts it to an integer
            Console.WriteLine("What page number are you on?");
            string page = Console.ReadLine();
            int pageNum = Convert.ToInt32(page);
            
            // Asks the user to input true or false depending on their answer as a string and then converts their answer to boolean
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);
            
            // Asks the user for an positive experiences as a string
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positive = Console.ReadLine();
            
            // Asks the user for any other feedback as a string
            Console.WriteLine("Is there any other feeback you'd like to provide? Please be specific.");
            string feeback = Console.ReadLine();
            
            // Asks the user to input how many hours theu studied today and converts it to an integer
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursTotal = Convert.ToInt32(hours);
            
            //Displays the ending thanks for taking the Daily Report
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

            }
        }
}
