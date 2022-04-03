using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04._2022RoomClass
{
    class Room 
    {
       

        private int Id { get { return Id; } set { } }
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get { return true; } set { } }

        public Room(int Id)
        {
            Id++;     
        }
          public string ShowInfo()
        {
            return $@"
                   Otagin Adi - {Name}
                   Otagin qiymeti {Price} azn-dir
                   Otaq {PersonCapacity} neferlikdir
                   {IsAvailable}
                  ";

        }
        public Room(string name, int price, int personCapacity)
        {

            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
           
        }

      

        public override string ToString()
        {
            return ShowInfo();
        }

        
        
    }
}
