using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    public class Employee : Person
    {
        double salary;

        public Employee(string firstName, string lastName, string address, string city, string country, double salary) : base(firstName, lastName, address, city, country)
        {
            this.salary = salary;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
        public static void PrintPersonStatic(Employee p)
        {
            //Person.PrintPersonStatic(p);
            Console.WriteLine("Employee first name {0} last name {1} salary {2}", p.GetFirstName(), p.GetLastName(), p.salary);
        }

    }
}