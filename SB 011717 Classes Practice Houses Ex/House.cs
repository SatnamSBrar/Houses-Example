﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_011717_Classes_Practice_Houses_Ex
{
    class House
    {
        //fields
        private string color;               //set to private so it cannot be modified
        private int rooms;
        private int size;
        private int doors;
        private string name;

        //properties
        public string Name                  //declares property Name
        {
            get { return this.name; }
            set { this.name = value; }      //allows public to input value for property
        }

        //constructors
        public House()                                              //sets default parameters for class House
        {
            this.color = "Light Blue";
            this.rooms = 6;
            this.size = 5000;
            this.doors = 3;
        }

        public House(string color, int size)                        //sets parameters for class House
        {
            this.color = color;
            this.size = size;
        }

        public House(string color, int rooms, int size, int doors)  //set different parameters for class House
        {
            this.color = color;
            this.rooms = rooms;
            this.size = size;
            this.doors = doors;
        }

        //methods
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
