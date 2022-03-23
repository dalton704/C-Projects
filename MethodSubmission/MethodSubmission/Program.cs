using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some math operations!");
            Console.WriteLine("\nPlease input a number:");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYou can input another number at this time if you would like to.");
            try
            {
                int numTwo = Convert.ToInt32(Console.ReadLine());
                int result = MathOperations.Addition(numOne, numTwo);
                Console.WriteLine("\nI have taken the sum of your numbers and multiplied it by ten.");
                Console.WriteLine("Your result is: \n" + result);
            }
            catch
            {
                int result = MathOperations.Addition(numOne);
                Console.WriteLine("I have multiplied your number by ten.");
                Console.WriteLine("Your result is: \n" + result);
            }
               

            
            

            Console.ReadLine();

        }
    }
}
