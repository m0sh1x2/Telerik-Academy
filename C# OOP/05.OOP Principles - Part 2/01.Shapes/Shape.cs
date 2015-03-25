using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;
        public Shape(double squareSides)
        {
            this.Height = squareSides;
            this.Width = squareSides;
        }
        public Shape(double width, double height)
        {
            this.Height = height;
            this.width = width;
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        public abstract double CalculateSurface();
        public double Width { get { return this.width; } private set { this.width = value; } }
        public double Height { get { return this.height; } private set { this.height = value; } }
    }
}
