using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_PRogramming
{

    public class Floor
    {
        string rooms;
        string elevator;


        public Floor (string rooms, string elevator)
        {
            this.rooms = rooms;
            this.elevator = elevator;
            
        }

        public void SetFloor(string RoomsOnTheFloor)
        {
            this.rooms = RoomsOnTheFloor;
        }
    }
}
