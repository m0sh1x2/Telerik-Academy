using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    public class Square : Shape
    {
        public Square(double squareSides)
            : base(squareSides)
        {

        }


        public override double CalculateSurface()
        {
            return base.Width * base.Height;
        }
    }
}
