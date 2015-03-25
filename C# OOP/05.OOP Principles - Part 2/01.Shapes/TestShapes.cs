namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestShapes
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Rectangle(5.0, 4.0));
            shapes.Add(new Triangle(3.3, 5.8));
            shapes.Add(new Square(5.0));

            foreach (var item in shapes)
            {
                Console.WriteLine(item.ToString() + " Surface: " + item.CalculateSurface());
            }
        }
    }
}
