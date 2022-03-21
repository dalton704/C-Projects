using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int othertotal = 12 + 22;
            //int combined = total + othertotal;
            //Console.WriteLine(combined.ToString());
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Fice = " difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine("product");
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient1 = 100.0 / 17.0;
            //Console.WriteLine(quotient1);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 70;

            bool isWarm = currentTemperature >= roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
