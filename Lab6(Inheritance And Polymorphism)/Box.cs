using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_Inheritance_And_Polymorphism_
{
    class Box
    {
        private double hieght, length, breadth;
        public Box()
        {
            hieght = 0;
            breadth = 0;
            length = 0;
        }
        public Box(double width_val,double breadth_val,double hieght_val)
        {
            hieght = hieght_val;
            breadth = breadth_val;
            length = width_val;
        }
       public void displayInfo()
        {
            Console.WriteLine($"Length:{length}\nBreadth:{breadth}\nHieght:{hieght}\nVolume:{calVol(length,breadth,hieght)}");
        }
        public Boolean equals(Box anotherBox)
        {
            if ((this.length==anotherBox.length)&& (this.hieght == anotherBox.hieght)&& (this.breadth == anotherBox.breadth)) return true;
            return false;
        }
        public double calVol(double w,double b,double h)
        {
            return w * h * b;
        }
    }
}
