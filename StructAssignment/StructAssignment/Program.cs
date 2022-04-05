using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating the Number Struct
            Number number = new Number();

            // Assigning a decimal to the Amount value
            number.Amount = 25.1m;
            
            // Writing the amount to the console
            Console.WriteLine(number.Amount);
            Console.ReadLine();

        }
    }
}
