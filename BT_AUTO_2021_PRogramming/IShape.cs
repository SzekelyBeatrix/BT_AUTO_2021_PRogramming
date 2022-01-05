using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    interface IShape
    {
        void Draw();
        void Color();

        //This is valid for C# >= versiune 8.0
       void State()
        {
            Console.WriteLine("State of theShape");
        }

    }
}
