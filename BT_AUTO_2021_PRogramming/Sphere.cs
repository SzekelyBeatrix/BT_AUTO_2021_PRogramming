using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Sphere
    {
        // V=4/3 πr3
        public static void GetVolSphere()
        {
            var r = 10;
            var volume = 4 / 3 * Math.PI * Math.Pow(r, 3);

            Console.WriteLine("The volume of the Sphere is = " + volume);
        }
    }
}
