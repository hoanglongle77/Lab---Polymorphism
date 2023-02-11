using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Polymorphism.Problem_3
{
    internal class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height { get => height; set => height=value; }
        public double Width { get => width; set => width=value; }

        public Rectangle(double height, double width)
        {
            Height=height;
            Width=width;
        }

        public Rectangle()
        {
        }

        public override double CalculateArea()
        {
            return this.Height*this.Width;
        }

        public override double CalculatePerimeter()
        {
            return ((this.Height+this.Width)*2);
        }

        public override string Draw()
        {
            return "Draw a rectangle";
        }
    }
}
