using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\lokum\source\repos\log.txt", true))
            {
                file.WriteLine(number);
            }
            Console.WriteLine("Your number has been recorded.");
            Console.ReadLine();
        }
    }
}
