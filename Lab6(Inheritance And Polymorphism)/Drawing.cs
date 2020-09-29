using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_Inheritance_And_Polymorphism_
{
    class Drawing
    {
        public virtual void draw()
        {
            Console.WriteLine("Draw");
        }
    }
    class Line : Drawing
    {
        public override void draw()
        {
            Console.WriteLine("Draw Line");
            base.draw();
        }

    }
    class Circle : Drawing
    {
        public override void draw()
        {
            Console.WriteLine("Draw Circle");
            base.draw();
        }
    }
    class Square : Drawing
    {
        public override void draw()
        {
            Console.WriteLine("Draw Square");
            base.draw();
        }

    }
   
}
