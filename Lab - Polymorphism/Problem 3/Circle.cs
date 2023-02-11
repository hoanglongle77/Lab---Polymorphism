using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___Polymorphism.Problem_3
{
    internal class Circle : Shape
    {
        private double radius;

        public double Radius { get => radius; set => radius=value; }

        public Circle()
        {
        }

        public Circle(double radius)
        {
            Radius=radius;
        }

        public override double CalculateArea()
        {
            return Math.Pow(this.radius,2)*Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return (this.Radius*2)*Math.PI;
        }

        public override string Draw()
        {
            return "Draw a circle";
        }
    }
}
