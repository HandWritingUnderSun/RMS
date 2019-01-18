using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMS.Model
{
    public class Room
    {
        private int _RoomID;
        public int RoomID
        {
            get { return _RoomID; }
            set { _RoomID = value; }
        }

        private string _RoomName;
        public string RoomName
        {
            get { return _RoomName; }
            set { _RoomName = value; }
        }

        public Room()
        { }

        public Room(int roomID, string roomName)
        {
            RoomID = roomID;
            RoomName = roomName;
        }
    }
}
