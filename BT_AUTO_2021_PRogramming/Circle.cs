using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Circle
    {
        double radius;
        //const double PI = 3.1415;

        public void SetRadius (double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2); //* radius * radiu poate fi Math.Pow(radius,2)
        }
        public void PrintCircle ()
        {
            Console.WriteLine("Circle with radius {0} has the area {1}", radius, GetArea());
        }
    }
}
