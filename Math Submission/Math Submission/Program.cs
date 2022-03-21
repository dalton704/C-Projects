using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Takes the users inputed number and multiplies it by 50
            Console.WriteLine("Please input a number to be multiplied:");
            string number = Console.ReadLine();
            int num1 = Convert.ToInt32(number) * 50;
            Console.WriteLine(number + " times 50 equals " + num1);
            
            // Takes the users inputed number and adds 25 to it
            Console.WriteLine("\nPlease input a number to be added:");
            string add = Console.ReadLine();
            int num2 = Convert.ToInt32(add) + 25;
            Console.WriteLine(add + " plus 25 equals " + num2);


            // Takes the users inputed number and divides it by 12.5
            Console.WriteLine("\nPlease input a number to be divided:");
            string divide = Console.ReadLine();
            double num3 = Convert.ToDouble(divide) / 12.5;
            Console.WriteLine(divide + " divided by 12.5 equals " + num3);

            // Takes the users inputed number and checks if it is greater than 50
            Console.WriteLine("\nPlease input a number to be compared:");
            string greater = Console.ReadLine();
            bool num4 = Convert.ToInt32(greater) > 50;
            Console.WriteLine("Is " + greater + " greater than 50? " + num4);

            // Takes the users inputed number and prints the remainder to the console
            Console.WriteLine("\nPlease input a number to find the remainder:");
            string remain = Console.ReadLine();
            int num5 = Convert.ToInt32(remain) % 7;
            Console.WriteLine("The remainder of " + remain + " divided by 7 is " + num5);
            Console.ReadLine();

        }
    }
}
