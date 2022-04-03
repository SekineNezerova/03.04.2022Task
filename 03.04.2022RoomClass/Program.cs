using System;

namespace _03._04._2022RoomClass
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Room room = new Room("r100",90,4);
            Room room1 = new Room("r101", 50, 2);
            Room room2 = new Room("r102", 120, 6);
            Room room3 = new Room("r103", 50, 2);
          
            Hotel hotel = new Hotel(4);

            hotel[0]=room;
            hotel[1] = room1;
            hotel[2] = room2;
            hotel[3] = room3;
            Console.WriteLine(hotel[1]);
            Console.WriteLine(room.ToString());
            
        }
    }
}
