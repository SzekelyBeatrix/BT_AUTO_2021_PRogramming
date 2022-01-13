using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    abstract class AbstractBuilding : IBuilding
    {
        public abstract void Elevator();
        public abstract void Floor();
        public abstract void UndergroundParking();

        

        public void Building()
        {
            Console.WriteLine("This is my building!");
        }
    }

}
