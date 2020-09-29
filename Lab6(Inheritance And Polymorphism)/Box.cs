using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_Inheritance_And_Polymorphism_
{
    class Box
    {
        //Attributes of the Box 
        private double hieght, length, breadth;
        //Constructor To Initialize the Box Object 
        public Box()
        {
            hieght = 0;
            breadth = 0;
            length = 0;
        }
        //Param Constructor to initialize the values
        public Box(double width_val,double breadth_val,double hieght_val)
        {
            hieght = hieght_val;
            breadth = breadth_val;
            length = width_val;
        }
        //The Below Function Displays The Attributes and The Volume of the Box 
       public void displayInfo()
        {
            Console.WriteLine($"Length:{length}\nBreadth:{breadth}\nHieght:{hieght}\nVolume:{calVol(length,breadth,hieght)}\n");
        }
        //The Below Is Similar to str.equals(anotherString) in java
        //Btw the Below Function checks whether the attributes are same not the volume
        public Boolean equals(Box anotherBox)
        {
            if ((this.length==anotherBox.length)&& (this.hieght == anotherBox.hieght)&& (this.breadth == anotherBox.breadth)) return true;
            return false;
        }
        //Returns the Volume
        public double calVol(double w,double b,double h)
        {
            return w * h * b;
        }
    }
}
