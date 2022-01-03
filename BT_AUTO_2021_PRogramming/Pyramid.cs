using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Pyramid
    {
        //V= l w h/3
        public static void GetVolPyramid()
        {
            var length = 10;
            var width = 5;
            var height = 30;
            var volume = length * width * height / 3;

            Console.WriteLine("The volume of the Pyramid is = " + volume);
        }
    }
}
