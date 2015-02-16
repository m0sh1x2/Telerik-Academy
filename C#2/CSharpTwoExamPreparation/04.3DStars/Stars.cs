using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._3DStars
{
    class Stars
    {
        private static int width, height, depth, starCount;
        private static char[, ,] cube;

        private static Dictionary<char, int> starType = new Dictionary<char, int>();


        static void Main(string[] args)
        {
            ReadInput();
            FindStars();
            PrintMessage();
        }

        private static void PrintMessage()
        {

            var sorted = starType.OrderBy(x => x.Key); //.ThenBy(x => x.Value);

            Console.WriteLine(starCount);
            foreach (var star in sorted)
            {
                Console.WriteLine("{0} {1}", star.Key, star.Value);
            }
        }

        private static void FindStars()
        {
            for (int w = 1; w < width - 1; w++)
            {

                for (int h = 1; h < height - 1; h++)
                {

                    for (int d = 1; d < depth - 1; d++)
                    {
                        FindSingleStar(w, h, d);
                    }

                }

            }
        }

        private static void FindSingleStar(int currentWidth, int currentHeight, int currentDepth)
        {
            char currChar = cube[currentWidth, currentHeight, currentDepth];
            bool isStar =
                    currChar == cube[currentWidth - 1, currentHeight, currentDepth] &&
                    currChar == cube[currentWidth + 1, currentHeight, currentDepth] &&
                    currChar == cube[currentWidth, currentHeight - 1, currentDepth] &&
                    currChar == cube[currentWidth, currentHeight + 1, currentDepth] &&
                    currChar == cube[currentWidth, currentHeight, currentDepth - 1] &&
                    currChar == cube[currentWidth, currentHeight, currentDepth + 1];
            if (isStar)
            {
                starCount++;

                if (starType.ContainsKey(currChar))
                {
                    starType[currChar]++;
                }
                else
                {
                    starType.Add(currChar, 1);
                }
            }
        }

        private static void ReadInput()
        {
            string[] rawNumbers = Console.ReadLine().Split(' ');
            width = int.Parse(rawNumbers[0]);
            height = int.Parse(rawNumbers[1]);
            depth = int.Parse(rawNumbers[2]);

            cube = new char[width, height, depth];

            for (int h = 0; h < height; h++)
            {
                string[] lineFragment = Console.ReadLine().Split();

                for (int d = 0; d < depth; d++)
                {
                    string cubeContent = lineFragment[d];

                    for (int w = 0; w < width; w++)
                    {
                        cube[w, h, d] = cubeContent[w];
                    }

                }

            }

        }
    }
}
