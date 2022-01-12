using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Building : AbstractBuilding , IBuilding
    {
        Building b1 = new Building();
        b1.SetFloor("The building has 5 floors!");

        /*public virtual double ComputingArea()
        {
            return ComputingArea;
        }
        public virtual double GetNumberOfFloors()
        {
            return Floors;
        }

        public virtual double GetTotalNumberOfRooms()
        {
            return;
        }

        public virtual double TotalCapacity()
        {
            return;
        }*/
    }
}
