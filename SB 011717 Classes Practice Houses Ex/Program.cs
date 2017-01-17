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

        public void Paint(string color)    //set to public so it can be used publicly
        {
            this.color = color;             //this. refers to class House
                                            //sets field color to the string parameter input via the Paint method
        }
        public string CurrentColor()
        {
            return color;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(); //creates new object in class House

            house1.Paint("red");        //paints house1 red
            Console.WriteLine(house1.CurrentColor());   //CurrentColor returns current color of object

            house1.Paint("white");      //paints house1 white
            Console.WriteLine(house1.CurrentColor());   //CurrentColor returns current color of object

            House house2 = new House(); //creates new object in class House

            house2.Paint("yellow");     //paints house2 yellow

            Console.WriteLine("\nHouse 1 is " + house1.CurrentColor() + ",and House 2 is " + house2.CurrentColor() + ".\n");
        }
    }
}
