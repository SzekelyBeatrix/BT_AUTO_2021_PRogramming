using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{
    class Room
    {
        string roomArea;
        string roomType;
        string accessories;
        double capacity;

        public Room(string roomArea, string roomType, string accessories, double capacity)
        {
            this.roomArea = roomArea;
            this.roomType = roomType;
            this.accessories = accessories;
            this.capacity = capacity;

        }
        public void SetRoomArea(string roomArea)
        {
            this.roomArea = roomArea;
        }
        public void SetRoomType(string roomType)
        {
            this.roomType = roomType;
        }
        public void SetAccessories(string accessories)
        {
            this.accessories = accessories;
        }
        public void SetCapacity(double capacity)
        {
            this.capacity = capacity;
        }
    }
}
