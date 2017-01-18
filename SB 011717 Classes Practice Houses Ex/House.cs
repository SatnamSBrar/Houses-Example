using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_011717_Classes_Practice_Houses_Ex
{
    class House
    {
        private string color;               //set to private so it cannot be modified
        private int rooms;
        private int size;
        private int doors;

        public House(string color, int rooms, int size, int doors)  //set parameters for class House
        {
            this.color = color;
            this.rooms = rooms;
            this.size = size;
            this.doors = doors;
        }

        public void Paint(string color)    //set to public so it can be used publicly
        {
            this.color = color;             //this. refers to class House
                                            //sets field color to the string parameter input via the Paint method
        }
        public string CurrentColor()
        {
            return color;
        }

        public void DisplayHouseInfo()  //method to display House information
        {
            Console.WriteLine("\nHouse Color: " + color);
            Console.WriteLine("Number of Rooms: " + rooms);
            Console.WriteLine("Number of Doors: " + doors);
            Console.WriteLine("Square Feet: " + size + "\n");
        }
    }
}
