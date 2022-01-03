using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Cube
    {
        //V=a3
        public static void GetVolCube()
        {
            var a = 30;
            var volume = Math.Pow(a, 3);

            Console.WriteLine("The volume of the Cube is = " + volume);
        }
    }
}
