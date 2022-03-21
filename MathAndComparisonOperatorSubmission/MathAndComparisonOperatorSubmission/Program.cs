using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            // Person 1 credentials
            Console.WriteLine("\n\tPerson 1:");
            Console.WriteLine("Hourly Rate");
            string Rate1 = Console.ReadLine();
            int hour1 = Convert.ToInt32(Rate1);

            Console.WriteLine("Hours worked per week");
            string work1 = Console.ReadLine();
            int week1 = Convert.ToInt32(work1);


            //Person 2 Credentials
            Console.WriteLine("\n\tPerson 2:");
            Console.WriteLine("Hourly Rate");
            string Rate2 = Console.ReadLine();
            int hour2 = Convert.ToInt32(Rate2);

            Console.WriteLine("Hours worked per week");
            string work2 = Console.ReadLine();
            int week2 = Convert.ToInt32(work2);

            //Calculating annual salaries
            int one = (hour1 * week1) * 12;
            int two = (hour2 * week2) * 12;

            // Displays annual salary of Person 1
            Console.WriteLine("Person 1 has an annual salary of " + one);
            
            // Displays annual salary of Person 2
            Console.WriteLine("\nPerson 2 has an annual salary of " + two);

            // COmpares salary of the 2 people to see if person 1 makes more than person 2
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool whoMakesMore = one > two;
            Console.WriteLine(whoMakesMore);
            Console.ReadLine();

        }
    }
}
