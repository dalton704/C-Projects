using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overloading the "==" operator to check if the employee ID's are equal.

            Employee emp1 = new Employee() { Id = 1 };
            Employee emp2 = new Employee() { Id = 2 };
            Console.WriteLine(emp1 == emp2);
            Console.ReadLine();
        }
    }
}
