using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            const string cons1 = "Your name is: ";
            const string cons2 = "Your favorite number is: ";
            Console.WriteLine("Enter your name or favorite number: ");
            var answer = Console.ReadLine();
            if (float.TryParse(answer, out float x))
            {
                Console.WriteLine(cons2);
                Chain newChain = new Chain(x);
            }
            else
            {
                Console.WriteLine(cons1);
                Chain newChain = new Chain(answer);
            }
            Console.ReadLine();
        }
    }
}
