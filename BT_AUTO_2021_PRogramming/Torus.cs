using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Torus
    {
        //V=(πr2)(2πR)
        public static void GetVolTorus()
        {
            var majorRadius = 20;
            var minorRadius = 2;
            var volume = Math.PI * Math.Pow(minorRadius, 2) * 2 * Math.PI * majorRadius;

            Console.WriteLine("The volume of the Torus is = " + volume);
        }
    }
}
