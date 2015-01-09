using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CircleRadius
{
    class CircleRadius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Find perimeter and area of an circle !");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.Write("Enter the radius of the cirlce : ");
            string r = Console.ReadLine();
            double radius = double.Parse(r);
            double area = Math.PI * radius * radius;
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("The area of the Circle is : {0} ",area);
            Console.WriteLine("The perimeter of the Circle is : {0}",perimeter);
        }
    }
}
