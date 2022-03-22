using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("\nPlease enter the weight of your package to be shipped.");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Your package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nPlease enter the package width.");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPlease enter the package height.");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPlease enter the package length.");
                int length = Convert.ToInt32(Console.ReadLine());

                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Your package is too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double dimensions = Convert.ToDouble((width * length * height) * weight / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + dimensions);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }

        }
    }
}
