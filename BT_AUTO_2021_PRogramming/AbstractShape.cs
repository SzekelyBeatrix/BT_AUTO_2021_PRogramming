using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    abstract class AbstractShape : IShape
    {
        int x = 0;
        public abstract void Draw();
        public abstract void Color();

        public void DoSmething()
        {
            Console.WriteLine("Shape is doing something!");
        }
    }
}
