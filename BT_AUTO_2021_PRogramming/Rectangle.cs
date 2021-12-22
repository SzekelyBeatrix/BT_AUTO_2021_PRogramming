using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Rectangle
    {
        double length;
        double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle ()
        {
             
        }

        public double GetLength()
        {
            return length;
        }
        public void SetLenght(double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {

            }
        }
    
        public void SetSize(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public virtual double GetArea()
        {
            return length * width;
        }

        public void PrintRectangle()
        {
            Console.WriteLine("The rectangle with length {0} and width {1} has area {2}", length, width, GetArea());
        
        }
        public override string ToString()
        {
            return "This is a rectangle with" + width + "width and" + length + "length!!";
        }
        public virtual double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public virtual double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));
        }

    }
}
