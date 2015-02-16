using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._3DStarsByMe
{
    class StarsByMe
    {

        public static int witdh, height, depth, starCount;
        public static char[, ,] cube;

        public static Dictionary<char, int> starType = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            ReadInput();
            FindStars();
            PrintResult();
        }

        private static void PrintResult()
        {
            Console.WriteLine(starCount);

            var sortedStars = starType.OrderBy(x => x.Key);

            foreach (var star in sortedStars)
            {
                Console.WriteLine("{0} {1}", star.Key, star.Value);
            }
        }

        private static void FindStars()
        {
            for (int w = 1; w < witdh - 1; w++)
            {
                for (int h = 1; h < height - 1; h++)
                {
                    for (int d = 1; d < depth - 1; d++)
                    {
                        FinDsingleStar(w, h, d);
                    }
                }
            }
        }

        private static void FinDsingleStar(int w, int h, int d)
        {
            char currentChar = cube[w, h, d];

            bool isStar =
                currentChar == cube[w - 1, h, d] &&
                currentChar == cube[w + 1, h, d] &&
                currentChar == cube[w, h - 1, d] &&
                currentChar == cube[w, h + 1, d] &&
                currentChar == cube[w, h, d - 1] &&
                currentChar == cube[w, h, d + 1];
            if (isStar)
            {
                starCount++;
                if (starType.ContainsKey(currentChar))
                {
                    starType[currentChar]++;
                }
                else
                {
                    starType.Add(currentChar, 1);
                }
            }
        }

        private static void ReadInput()
        {
            string[] rawInput = Console.ReadLine().Split();
            witdh = int.Parse(rawInput[0]);
            height = int.Parse(rawInput[1]);
            depth = int.Parse(rawInput[2]);

            cube = new char[witdh, height, depth];

            for (int h = 0; h < height; h++)
            {
                string[] lineFragment = Console.ReadLine().Split();

                for (int d = 0; d < depth; d++)
                {
                    string cubeContent = lineFragment[d];
                    for (int w = 0; w < witdh; w++)
                    {
                        cube[w, h, d] = cubeContent[w];
                    }
                }
            }
        }
    }
}
