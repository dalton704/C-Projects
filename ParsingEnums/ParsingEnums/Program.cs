using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isvalid = false;
            while(!isvalid)
            {
                try
                {
                    Console.WriteLine("Enter the current day of the week");
                    string dayinput = Console.ReadLine();

                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();
                    isvalid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

