using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Person
    {
        // Assigned variables for First and Last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Created a Void Method that will display the persons first and last name of the person
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
