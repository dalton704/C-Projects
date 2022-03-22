using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] favFoods = new string[] { "Spaghetti", "Tacos", "Chicken Alfredo", "Pizza" };
            Console.WriteLine("What are your four favorite food?");
            for (int i = 0; i < favFoods.Length; i++)
            {
                favFoods[i] = favFoods[i] + " " + Console.ReadLine();
            }
            
            foreach (string food in favFoods)
            {
                Console.WriteLine(food);
       
            }
            Console.ReadLine();
        }
    }
}
