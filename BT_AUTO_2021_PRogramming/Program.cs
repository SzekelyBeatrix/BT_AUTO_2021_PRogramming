using System;

namespace BT_AUTO_2021_PRogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Course01(args);
            // Course02(args);
            // Homework01(args);
            //Course03(args);
            Course04();
        }
        static void Course01(string[] args)
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

            {
                Console.WriteLine("Number is positive");
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
            if (number == 1)
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

            for (counter = 0; counter <= MAX_NUMBER; counter++) ;
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
        } //

        static void Course02(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2; //c2 will be null !!
            c1.SetRadius(10);
            //double area = c1.GetArea();//
            /*Console.WriteLine(c1.GetArea());*/
            c1.PrintCircle();
            Circle c3 = new Circle();
            c3.SetRadius(5);
            //Console.WriteLine(c3.GetArea());//
            c3.PrintCircle();
            foreach (string p in args)
            {
                Circle c = new Circle();
                c.SetRadius(Double.Parse(p));
                Square s = new Square();
                //s.SetSide(Double.Parse(p));
                Rectangle r = new Rectangle();
                r.SetSize(Double.Parse(p), Double.Parse(p));
                c.PrintCircle();
                s.PrintSquare();
            }

            Person p1 = new Person();
            p1.SetName("Beatrix");
            p1.SetSex('f');
            p1.Eat();
            p1.Run();
            p1.Eat();
            p1.PrintPerson();

            Rectangle r1 = new Rectangle();
            r1.SetSize(2, 3);
            r1.PrintRectangle();
        }

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
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                        break;
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

            int sum = 0;
            for (int i = 1; i <= 100; i++)
                sum += i;
            Console.WriteLine("Sum of first 100 numbers higher than 0 is: " + sum);

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

        static void Course03(string[] args)

        {
            return;
            ComputeConversion(args);
            CurrencyCalculator(156, "USD", 4.3734);
            Shape s = GetShape(12, 34, 12.4, 'a', "17d");
            //Console.WriteLine(ConcatenateStrings(args));
            Random rnd = new Random();
            GuessNumber(rnd.Next(1, 1000));
        }
        static bool IsOddNumber(int number)
        {
            if (number % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            return number % 2 != 0;
        }
        static int TestValue(int testVal, int target)
        {

            if (testVal < target)
            {
                Console.WriteLine("Number to be guess is higher!");
                return -1;
            }

            if (testVal > target)
            {
                Console.WriteLine("Number to be guess is lower!");
                return 1;
            }
            Console.WriteLine("This is the number !!");
            return 0;

        }
        static void GuessNumber(int n)
        {
            int currentNumber = 0;
            do
            {
                currentNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Number chosen is {0}", currentNumber);
            }
            while (TestValue(currentNumber, n) != 0);
        }
        static Shape GetShape(int x, int y, double a, char t, String s)

        {
            Console.WriteLine(x);
            return new Shape();
        }

        static string ConcatenateStrings(string[] args)
        {
            string returnString = "";

            foreach (string s in args)
            {
                returnString += s; //returnString = returnString + s;
            }
            return returnString;
        }
        static void ComputeConversion(string[] args)
        {

            if (args.Length != 3)
            {
                Console.WriteLine("The application receives only 3 parameters: amount, currency, exchange rate");
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", args[0], args[1], args[2]);
                //double amount = Double.Parse(args[0]);
                // string currency = args[1];
                // double conversionRate = Double.Parse(args[2]);
                //Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON", amount, currency, amount * ConversionRate);
                CurrencyCalculator(Double.Parse(args[0]), args[1], Double.Parse(args[2]));

            }
            CurrencyCalculator(156, "USD", 4.3734);
        }

        static void CurrencyCalculator(double amount, string currency, double ConversionRate)
        {
            Console.WriteLine("By converting {0} {1} into RON we obtain {2} RON", amount, currency, amount * ConversionRate);
        }

        static void Course04()
        {
            DrawFullShape(5, 3);
            Console.WriteLine();
            DrawFullShape(5, 3);
            Console.WriteLine();
            DrawShapeOutline(14, 22);

            Circle c1 = new Circle(); // instantiate c1 with default (no params) constructor
            Circle c2 = new Circle(10); // instantiate c2 with 1 params constructor
            c1.PrintCircle();
            c2.PrintCircle();

            Person p1 = new Person();
            Person p2 = new Person("Beatrix", 'f', new String[] { "Romanian" }, false, new DateTime());
            p1.PrintPerson();
            p2.PrintPerson();
        
         
        

            Rectangle r1 = new Rectangle(2, 7);
            r1.PrintRectangle();

            Square s1 = new Square(6);
            s1.PrintSquare();

            StructExample se = new StructExample();
            StructExample.MyStruct myStruct = new StructExample.MyStruct();
            myStruct.Assign(10, "abc");
            Console.WriteLine(myStruct.ComputeSum());

            StructExample.Rectangle3d r2 = new StructExample.Rectangle3d();
            r2.Assign(2, 5, 7);
            Console.WriteLine(r2.GetVolume());

        }
        public static void DrawFullShape(int width, int height)
        {
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < width; i++) ///this will print a single line with *

                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public static void DrawShapeOutline(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) ///this will print a single line with *

                {
                    if (j == 0 || j == height - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (i == 0 || i == width - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
        public static void DrawShapeCorners(int width, int height)
        {
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++) ///this will print a single line with *

                {
                    //if (j == 0 && i==0) || (j==0 && i=width-1) || (j==height-1 || i ==0) || (j==height-1 && i==width-1))
                    if (j == 0 || j == height - 1)
                    {
                        if (i == 0 || i == width - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

