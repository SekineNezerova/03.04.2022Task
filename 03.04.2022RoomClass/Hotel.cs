using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04._2022RoomClass
{
    class Hotel:Object
    {
        public string Name { get; set; }
       

        private Room[] rooms;
        public Hotel(int size)
        {
            rooms = new Room[size];
        }
        public Room this[int index]
        {
            get
            { 
                return rooms[index]; 
            }
            set 
            { 
                rooms[index] = value; 
            }
        }
        public void AddRoom(int Room)
        {
            Room[] rooms = new Room[Room];
        }
        public Hotel(string Name)
        {
            this.Name = Name;
        }
        public void Reserve(int roomId)
        {
            
        }
    }
}
