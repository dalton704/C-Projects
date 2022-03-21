using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
			int num1 = 12;
			int num2 = 3;

			int addition = num1 + num2;
			int subtraction = num1 - num2;
			int multiply = num1 * num2;
			int divide = num1 / num2;

			Console.WriteLine("12 + 3 = " + addition);
			Console.WriteLine("12 - 3 = " + subtraction);
			Console.WriteLine("12 * 3 = " + multiply);
			Console.WriteLine("12 / 3 = " + divide);
			Console.ReadLine();
			}
		}

	}
