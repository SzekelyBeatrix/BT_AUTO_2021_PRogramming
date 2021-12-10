using System;

namespace BT_AUTO_2021_PRogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.141592;
            const int MAX_NUMBER = 5;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are mere");
            Console.WriteLine("6+2");
            Console.WriteLine(6 + 2);

            int numberOfStudents = 5;
            int count;
            int a, b;
            a = numberOfStudents + 1;
            a = a + numberOfStudents;
            short s = 5;
            ulong ul = 65;

            float numberFloat = 5.6F;
            double numberDouble = 5.6;

            float f = (float)numberDouble;
            int numberInt = (int)f;
            long l = numberOfStudents;

            Console.WriteLine(typeof(int).IsPrimitive);

            bool myBoolean = false;
            char ch = 'a'; //'1' nu este gal cu 1

            string myString = "Ana are mere si pere";
            string result = myString + "si struguri";
            Console.WriteLine(result);

            DateTime dataCurenta = new DateTime(2021, 12, 8);
            Console.WriteLine(dataCurenta);

            Console.WriteLine(numberFloat * a);
            Console.WriteLine(5 / 6F);
            Console.WriteLine(5 % 6);

            int x = 2;
            x = x + 5;
            //sau
            x += 5; //prescutare de la x=x+5
            // x++ <=> x = x + 1
            // ++x <=> x = x + 1

            Console.WriteLine(x++);
            Console.WriteLine((x > a));

            int number = 4;
            Console.WriteLine("Number tested is" + number);

            if (number >= 0)

            { Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");

            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number!");
            }
            else
            {
                Console.WriteLine("Odd number!");
            }
            if (number <= 40 && number >= 0)

                if (number <= 20)
                {
                    Console.WriteLine("Student failed!");
                }
                else
                {
                    Console.WriteLine("Student passed!");
                }

                else
                {
                Console.WriteLine("Grade is invalid");
                }
                // One line if / else
                String message = (number % 2 == 0) ? "Even" : "Odd";
                Console.WriteLine(message);
                if (number ==1)
                {
                Console.WriteLine("Monday");
                }
                 if (number == 2)
                 {
                  Console.WriteLine("Tuesday");
                  }
            if (number == 3)
            {
                Console.WriteLine("Wednesday");
            }
            if (number == 4)
            {
                Console.WriteLine("Thursday");
            }
            if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            if (number < 1 || number > 7)
            {
                Console.WriteLine("Sorry not a valid day!");
            }

            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Not a valid day!");
                        break;
                    }

            }

            int counter = 0;
                while (counter <= MAX_NUMBER)
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            }
        // do while iti executa si daca e -1 (Current number is:0)
 
            counter = 0;
            do
            {
                Console.WriteLine("Current number is: " + counter);
                counter++;
            }
            while (counter <= MAX_NUMBER);

            for (counter = 0; counter <= MAX_NUMBER; counter++);
            {
            // Console.WriteLine("Current number is: " + counter);
             Console.WriteLine("Current number is:{0}", counter);
            }

            //foreach (string argument in args)
          
                //Console.WriteLine("The argument is: {0}", argument);
            
            int year = 1900;

            foreach (string yr in args)
            {
                int febDays = 28;
                year = int.Parse(yr);


                /* if (year % 4 ==0)
                 {
                     if (year % 100 == 0 && year % 400 !=0)
                     {
                         febDays = 29;
                     }
                  //   if (year % 100 == 0 && year % 400 == 0)
                   //  {
                   //      febDays = 28;
                   //  }
                    /* if (year % 100 !=0)
                     {
                         febDays = 29;
                     }
                    */
                if (year < 1900 || year > 2016)
                {
                    Console.WriteLine("Year is out of valid bounds(1900-2016)");
                }
                else
                {
                    if ((year % 4 == 0 && year % 100 == 0 && year % 400 != 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        febDays = 29;
                    }
                    Console.WriteLine("February has {28} days", febDays, year);
                }
            }

           // else
            //{
              //  febDays = 28;
            //}
            
        }
    }
}
