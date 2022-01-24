using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework.BuildingFolder
{
    public class Building : AbstractBuilding
    {


        public List<Floor> Floors { get; set; }
        public override double ComputingArea()
        {
            double area = 0;
            foreach (var floor in Floors)
            {
                foreach (var room in floor.Rooms)
                {
                    area += room.RoomArea;
                }
            }

            return area;
        }

        public override int GetNumberOfFloors()
        {
            return Floors.Count();
        }

        public override int GetTotalNumberOfRooms()
        {
            int noOfRooms = 0;
            foreach (var floor in Floors)
                noOfRooms += floor.Rooms.Count();

            return noOfRooms;
        }

        public override int TotalCapacity()
        {
            int totalCapacity = 0;
            foreach (var floor in Floors)
            {
                foreach (var room in floor.Rooms)
                {
                    totalCapacity += room.Capacity;
                }
            }

            return totalCapacity;
        }
        public void PrintBuilding()
        {
            
            Console.WriteLine("Now print all 5 floors: {0}", ComputingArea());
          
        }

    }
}
