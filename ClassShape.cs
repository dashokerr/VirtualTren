using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTren
{
    internal class ClassShape
    {
        public virtual double GerArea()
        {
            return 0;
        }
    }

    internal class Rectangle : ClassShape
    {
        int width;
        int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GerArea()
        {
            return width * height;
        }
    }
    internal class Circle : ClassShape
    {
        int R;
        

        public Circle(int R)
        {
           this.R = R;
        }

        public override double GerArea()
        {
            return double.Pi * Math.Pow(R, 2);
        }
    }

}
