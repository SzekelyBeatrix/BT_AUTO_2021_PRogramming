using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Homework1
    {
        static void Homework01(string[] args)
        {
            Console.WriteLine(args.Length);

            if (args.Length == 3)
            {

                float a = float.Parse(args[0]);

                float b = float.Parse(args[2]);

                string op = args[1];
                float result = 0;


                // implement calculator logic here
                switch (op)
                {
                    case "+":
                        {
                            result = a + b;
                            break;
                        }
                    case "-":
                        {
                            result = a - b;
                            break;
                        }
                    case "*":
                        {
                            result = a * b;
                            break;
                        }
                    case "/":
                        {
                            result = a / b;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;

                }
                if (result != 0)
                    Console.WriteLine("Result is: " + result);

            }
            else
            {

                Console.WriteLine("3 args are needed!");

            }

            //Ex1 The sum of the firt 100 numbers
            int No = 101;
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum for the first 100 numbers higher than 0 is: " + sum);


            //Ex2 Palindrome nr
            Console.WriteLine("Type a number, and then press Enter");
            {
                int nr = int.Parse(Console.ReadLine());
                int cNr = nr;
                int newNr = 0;
                while (nr != 0)
                {
                    newNr = newNr * 10 + nr % 10;
                    nr = nr / 10;
                }

                if (cNr == newNr)
                    Console.WriteLine("The number is palindrome");
                else
                    Console.WriteLine("The number is not palindrome");
            }
            //All the prime numbers lower than a given number
            int number = int.Parse(Console.ReadLine());
            for (int i = number; i >= 2; i--)
            {
                int prim = 1;
                for (int d = 2; d <= i / 2; d++)
                    if (i % d == 0)
                        prim = 0;
                if (prim == 1)
                    Console.WriteLine(i);
            }

        }
    }
}
