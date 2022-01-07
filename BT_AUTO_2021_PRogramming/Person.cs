using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
   public class Person :IPerson
    {
        string firstName;
        string lastName;
        string address;
        string city;
        string country;
        char sex;
        string[] nationality;
        bool isHungry;
        DateTime dob;

        public Person(string firstName, string lastName, string address, string city, string country, char sex, string[] nationality, bool isHungry, DateTime dob)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.country = country;
            this.sex = sex;
            this.nationality = nationality;
            this.isHungry = isHungry;
            this.dob = dob;
        }
        public Person (string firstName, string lastName, string address, string city, string country, char sex)
            {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.country = country;

        }

        public Person(string name, char sex, string[] nationality, bool isHungry, DateTime dob)
        {
            this.firstName = name;
            this.sex = sex;
            this.nationality = nationality;
            this.isHungry = isHungry;
            this.dob = dob;
        }
        public Person()
        {

        }



        public void Eat()
        {
            Console.WriteLine("The person is eating...");
            isHungry = true;
        }
        public void Run()
        {
            Console.WriteLine("The person is running for his health...");
            isHungry = true;
        }
        public void SetName(string personName)
        {
            firstName = personName;
        }

        public void SetSex(char sex)
        {
            this.sex = sex;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }
        public string GetCity()
        {
            return this.city;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Name of the person is {0}", firstName);
            Console.WriteLine("-> Current state for hungry is {0}", isHungry);
            Console.WriteLine("-> Person sex is {0}", sex);
        }

        public static void PrintPersonStatic(Person p)
        {
            Console.WriteLine("First name is {0} and last name is{1}", p.firstName, p.lastName);
        }
       
    }
}
