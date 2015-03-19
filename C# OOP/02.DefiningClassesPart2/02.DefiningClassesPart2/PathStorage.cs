namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    public static class PathStorage
    {
        public static string path = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + @"\Paths.txt";

        public static void SavePathToTextFile(PointXYZ point)
        {
            string[] lines = File.ReadAllLines(path);
            bool writeTheLine = true;
            //Path to desktop

            if (!File.Exists(path))
            {

                // Create a file to write to. 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(new string('-', 10));
                }
            }

            //Check for dublicates
            foreach (var line in lines)
            {
                if (line == point.ToString())
                {
                    writeTheLine = false;
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                if (writeTheLine == true)
                {
                    Console.WriteLine("Point Saved To File !");
                    sw.WriteLine("{0}", point.ToString());
                }
                else
                {
                    Console.WriteLine("Point {0} already exists !", point.ToString());
                }
            }
        }
        public static void LoadPathsFromTextFile()
        {
            string[] lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
