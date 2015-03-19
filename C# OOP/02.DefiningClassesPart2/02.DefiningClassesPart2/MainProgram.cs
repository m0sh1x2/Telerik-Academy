namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainProgram
    {
        static void Main(string[] args)
        {
            var consoleTirs = new string('-', 40);

            PointXYZ A = new PointXYZ(5, 6, 2);
            PointXYZ B = new PointXYZ(-7, 11, -13);

            Console.WriteLine(consoleTirs);
            Console.WriteLine("The distance between the two points : ");
            Console.WriteLine(PointXYZ.CalculateDistance(A, B));
            Console.WriteLine(consoleTirs);

            Console.WriteLine("Adding points: " );
            PathStorage.SavePathToTextFile(B);
            PathStorage.SavePathToTextFile(A);
            Console.WriteLine(consoleTirs);
            //Paths from text file
            Console.WriteLine("Paths from file : " );
            PathStorage.LoadPathsFromTextFile();
            Console.WriteLine(consoleTirs);

            var paths = new Path();
        }
    }
}
