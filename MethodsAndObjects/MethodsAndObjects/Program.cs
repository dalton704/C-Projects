using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quitter = new Employee();
            quitter.Quit("Mark");
            Console.ReadLine();

            //// Instantiating the employee class
            //Employee employee = new Employee();

            //// Assigning the first and last name to the employee
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";
            
            //// Calling the superclass method to display the employees name onto the console.
            //employee.SayName();
            //Console.ReadLine();
        }
    }
}
