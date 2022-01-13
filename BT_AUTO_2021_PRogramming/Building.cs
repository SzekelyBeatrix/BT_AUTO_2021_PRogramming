using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Building : AbstractBuilding , IBuilding
    {
        Building mybuilding = new Building();
        //mybuilding.SetArea();
        //mybuilding.SetNumberOfFloors();
        //mybuilding.GetNumberOfFloors();
        //mybuilding.SetTotalCapacity();
        //mybuilding.PrintBuilding();


        const int MAX_CAPACITY = 300;
       double area;
       double floors;
       double rooms;
       double capacity;
       private double length;
       private double width;

        public Building(double area, double floors, double rooms, double capacity, double length, double width)
        {
            this.area = area;
            this.floors = floors;
            this.rooms = rooms;
            this.capacity = capacity;
            this.length = length;
            this.width = width;
        }

        public Building()
        {
        }



        /*public void Floor()
        {
            
        }
        public void Elevator()
        {

        }
        public void UndergroundParking()
        {

        }
        Building b1 = new Building();
        b1.SetFloor("The building has 5 floors!"); */

        public virtual double ComputingArea()
        {
            return length * width;
        }
        public void SetArea(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public void PrintArea()
        {
            Console.WriteLine("The building with length {0} and width {1} has area {2}", length, width, ComputingArea());
        }

        public virtual double GetNumberOfFloors()
        {
            return floors;
        }
        public void SetNumberOfFloors(double floors)
        {
            if (floors > 5)
            {
                this.floors = floors;
            }
            else
            {
                Console.WriteLine("The building has just 5 floors!");
            }
        }
        public virtual double GetTotalNumberOfRooms()
        {
            return rooms;
        }

        public virtual double TotalCapacity()
        {
            return capacity;
        }
        public void SetTotalCapacity(double capacity)
        {
            if (capacity <= 300)
            {
                this.capacity = capacity;
            }
            else
            {
                Console.WriteLine("The capacity of the building exceed the maximum of the 300 people!");
            }
        }

        public override string ToString()
        {
            return "This is a building with" + width + "width and" + length + "length!!";
        }

        /*public override void Building()
        {
            Console.WriteLine("This is a 5 floors building with a capacity of 300 people!");
        }*/

        public override void Elevator()
        {
            throw new NotImplementedException();
        }

        public override void Floor()
        {
            throw new NotImplementedException();
        }

        public override void UndergroundParking()
        {
            throw new NotImplementedException();
        }
    }
}
