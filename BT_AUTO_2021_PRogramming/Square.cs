﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    sealed class Square : Rectangle
    {
        double side;
        public double Side { get => side; set => side = value; }

        public Square(double side)
        {
            this.side = side;
        }
        public Square()
        {

        }
        public void SetSide(double side)
        {
            this.side = side;
        }
        public override double GetArea()
        {
            return Math.Pow(side, 2);
           
        }

        public void PrintSquare()
        {
            Console.WriteLine("The square with side {0} has the area {1}", side, GetArea());
        }
        public override string ToString()
        {
            return "This is a square with side " + side;
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a square!");

        }
    }
}
