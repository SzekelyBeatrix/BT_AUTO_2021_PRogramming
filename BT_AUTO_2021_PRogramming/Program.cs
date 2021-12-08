using System;

namespace BT_AUTO_2021_PRogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_SIZE = 100;
            const double PI = 3.141592;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ana are mere");
            Console.WriteLine("6+2");
            Console.WriteLine(6+2);

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
            Console.WriteLine((x > a);


        }
    }
}
