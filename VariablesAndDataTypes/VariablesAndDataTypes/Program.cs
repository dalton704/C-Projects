﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Control + K + C For massive comment out

            //Console.WriteLine("What is you name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char randomLetter = 'X';
            char questionMark = '\u2103';
            
            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.8934894;

            float secondsLeft = 2.62f;

            short temperatureonMars = -341;

            int currentAge = 30;
            string yearsOld = currentAge.ToString();
            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);


            Console.Write(rainingStatus);
            Console.ReadLine();
              

        }
    }
}
