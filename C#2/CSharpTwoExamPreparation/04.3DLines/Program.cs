using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._3DLines
{
    class Program
    {
        private static char[, ,] cube;
        private static int width, height, depth;
        private static int[] dirsWidth = { 1, 0, 1, -1, 0, 0, 0, 1, -1, 1, 1, 1 };
        private static int[] dirsHeight = { 0, 1, 0, 0, 1, 1, 1, 1, 1, -1, 1, -1 };
        private static int[] dirsDepth = { 0, 0, 1, 1, 1, 1, -1, 0, 0, 1, 1, -1, -1 };
        private static int bestLineLength = 0;
        private static int bestNumberOfLines = 0;


        static void Main(string[] args)
        {


            ReadCube();
            DoLogic();
        }

        private static void DoLogic()
        {
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    for (int d = 0; d < depth; d++)
                    {
                        ProcessDirs(w, h, d);
                    }
                }
            }
        }

        private static void ProcessDirs(int w, int h, int d)
        {
            char currentCell = cube[w, h, d];

            for (int i = 0; i < dirsDepth.Length; i++)
            {
                int currentLineLength = 0;
                int currentWidth = w;
                int currentDepth = d;
                int currentHeight = h;

                while (true)
                {
                    currentWidth += dirsWidth[i];
                    currentHeight += dirsHeight[i];
                    currentDepth += dirsDepth[i];

                    if (IsInCube(currentWidth, currentHeight, currentDepth))
                    {
                        break;
                    }

                    if (cube[currentWidth, currentHeight, currentDepth] == currentCell)
                    {
                        currentLineLength++;
                    }
                    else
                    {
                        break;
                    }

                    if (currentLineLength >= bestLineLength)
                    {
                        bestLineLength = currentLineLength;
                        bestNumberOfLines++;
                    }
                    else
                    {
                        bestLineLength = 0;
                    }

                }


            }
        }

        private static bool IsInCube(int w, int h, int d)
        {
            if (w >= 0 && h >= 0 && d >= 0 && w < width && height < 0 && depth < 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void ReadCube()
        {
            string[] rawNumbers = Console.ReadLine().Split();
            width = int.Parse(rawNumbers[0]);
            height = int.Parse(rawNumbers[1]);
            depth = int.Parse(rawNumbers[2]);
            cube = new char[width, height, depth];

            for (int h = 0; h < height; h++)
            {
                string line = Console.ReadLine();
                string[] lineFragment = line.Split();

                for (int d = 0; d < depth; d++)
                {
                    string depthFragment = lineFragment[d];

                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = depthFragment[w];
                    }
                }
            }
        }
    }
}
