using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trails3D
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] xyz = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int x = int.Parse(xyz[0]);
            int y = int.Parse(xyz[1]);
            int z = int.Parse(xyz[2]);


            //check if player can turn multiple times
            string redCommands = ConvertCommands(Console.ReadLine());
            string blueCommands = ConvertCommands(Console.ReadLine());



        }
        static string ConvertCommands(string path)
        {
            StringBuilder result = new StringBuilder();

            path = path.Replace("M", " M ");
            path = path.Replace("L", " L ");
            path = path.Replace("R", " R ");

            string[] separatedPath = path.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string lastNumber = null;

            for (int i = 0; i < separatedPath.Length; i++)
            {
                if (separatedPath[i] == "L" || separatedPath[i] == "R")
                {
                    result.Append(separatedPath[i]);
                }
                else if (separatedPath[i] == "M")
                {
                    if (lastNumber == null)
                    {
                        result.Append("M");
                    }
                    else
                    {
                        int number = int.Parse(lastNumber);
                        result.Append(new string('M', number));
                    }
                }
                else
                {
                    lastNumber = int.Parse(separatedPath[i]);

                }
            }
            return null;
        }
    }
}
