using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new list of employee
            List<Employee> employees = new List<Employee>
            
            {
                new Employee { FirstName = "Dalton", LastName = "Scott", Id = 1 },
                new Employee { FirstName = "Cindy", LastName = "Lara", Id = 2 },
                new Employee { FirstName = "Phil", LastName = "Marino", Id = 3},
                new Employee { FirstName = "Joe", LastName = "Exotic", Id = 4 },
                new Employee { FirstName = "Andy", LastName = "Bower", Id = 5 },
                new Employee { FirstName = "Joe", LastName = "Shepard", Id = 6 },
                new Employee { FirstName = "Justin", LastName = "Horein", Id = 7 },
                new Employee { FirstName = "Adam", LastName = "Smith", Id = 8 },
                new Employee { FirstName = "Joe", LastName = "Johnson", Id = 9 },
                new Employee { FirstName = "Gabe", LastName = "Larson", Id = 10}
            };
            List<Employee> joes = new List<Employee>();

            // For each loop to make a new list for employees with first name Joe
            foreach (Employee name in employees)
            {
                if (name.FirstName == "Joe")
                {
                    joes.Add(name);
                }
            }

            // Lambda function to make list for employees with first name Joe
            List<Employee> emp1 = employees.Where(x => x.FirstName == "Joe").ToList();

            //Lambda function to make list for employees with Id greater than 5
            List<Employee> emp2 = employees.Where(x => x.Id > 5).ToList();

        }
    }

    // Employee calss in order to make the list
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
