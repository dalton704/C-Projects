using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        // If emp1 and emp2 id's are equal will return true.
        public static bool operator == (Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        // If emp1 and emp2 id's are not equal will return true
        public static bool operator != (Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }
    }
}
