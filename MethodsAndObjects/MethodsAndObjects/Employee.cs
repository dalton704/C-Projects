﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // Creating class employee while inheriting the Person class
    class Employee : Person, IQuittable
    {
        int ID { get; set; }
        public void Quit(string name)
        {
            Console.WriteLine("I, " + name + ", Quit!");
        }
    }
}
