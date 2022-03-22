using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Part_4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> Greeting = new List<string>()
            //{
            //    "Hello", "Hi", "Hello", "Sup", "Yo", "Hola"
            //};

            //Console.WriteLine("Please input a greeting to search for:");
            //string search = Convert.ToString(Console.ReadLine());
            //for (int i = 0; i < Greeting.Count; i++)
            //{
            //    if (search == Greeting[i])
            //    {
            //        Console.WriteLine("That greeting is located at index " + i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, your input is not on the list.");
            //    }
            //}
            //Console.ReadLine();

            List<string> similar = new List<string>()
            {
                "Hello", "Hi", "Hey", "Hello", "Hey", "Wassup"
            };
            List<string> repeat = new List<string>();
            foreach (string same in similar)
            {
                Console.WriteLine(same);
                if (repeat.Contains(same))
                {
                    Console.WriteLine("This greeting was stated before.");
                }
                else
                {
                    Console.WriteLine("This greeting was not stated before");
                }
                repeat.Add(same);
            }
            Console.ReadLine();
        }
    }
}
