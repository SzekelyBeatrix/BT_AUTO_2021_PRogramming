using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.BuildingFolder
{
    public interface IBuilding
    {
        double ComputingArea();
        int GetNumberOfFloors();
        int GetTotalNumberOfRooms();
        int TotalCapacity();
    }
}
