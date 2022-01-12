using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
   public class Calculator : ICalculator
    {
        double a, b;
        char op;

        public Calculator(double a, double b, char op)
        {
            this.a = a;
            this.b = b;
            this.op = op;
        }
        public double Compute()
        {
            return Compute(a, b, op);
        }
        public double Compute(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    {
                        return a + b;

                    }
                case '-':
                    {
                        return a - b;

                    }
                case '*':
                    {
                        return a * b;

                    }
                case '/':
                    {
                        if (b == 0)
                        {
                            throw new ArgumentException();

                        }
                        return a / b;
                    }
                case '%':
                    {

                        if (b == 0)
                        {
                            throw new ArgumentException();
                        }
                        return a % b;
                    }
                default:
                    {
                        throw new ArgumentException();
                    }
            }
        }
    }
}
