using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Cylinder
    {
        //V=πr2h
        public static void GetVolCylinder()
        {
            var radius = 10;
            var height = 15;
            var volume = Math.PI * Math.Pow(radius,2) * height;

            Console.WriteLine("The volume of the Cylinder is = " + volume);
        }
    }
}
