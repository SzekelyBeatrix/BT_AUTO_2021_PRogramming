using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.BuildingFolder
{
    public abstract class AbstractBuilding :IBuilding
    {
        public abstract double ComputingArea();
        public abstract int GetNumberOfFloors();
        public abstract int GetTotalNumberOfRooms();
        public abstract int TotalCapacity();
    }
}
