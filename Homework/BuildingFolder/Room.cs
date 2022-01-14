using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.BuildingFolder
{
    public class Room
    {
        public double RoomArea { get; set; }
        public RoomType RoomType { get; set; }
        public List<string> Accessories { get; set; }
        public int Capacity { get; set; }
    }
}
