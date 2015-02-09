using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Tron3D
{
    class Program
    {
        //TODO Go on line 104 !!! Video Time : 58:06


        static int oldX, oldY, oldZ;
        static string redMoves, blueMoves;
        static int X, Y;
        static bool[,] used;
        static int currentRedX;
        static int currentRedY;
        static int currentBlueX;
        static int currentBlueY;

        static int redDirection;
        static int blueDirection;
        // Directions: 
        // 0-> Right
        // 1-> Down
        // 2-> Left
        // 3-> Up
        // 4-> 0 (%)
        // -1 -> 3
        // rotate right -> direction++;
        // rotate left -> direction--;

        static int RotateLeft(int direction)
        {
            int newDirection = direction - 1;
            if (newDirection == -1)
            {
                newDirection = 3;
            }
            return newDirection;
        }

        static int RotateRight(int direction)
        {
            int newDirection = direction - 1;
            if (newDirection == 4)
            {
                newDirection = 0;
            }
            return newDirection;
        }


        static void Main(string[] args)
        {

            ReadInput();

            X = oldX + 1;
            Y = oldZ + oldY + oldY + oldZ;

            used = new bool[X + 1, Y];

            currentRedX = X / 2;
            currentRedY = oldY / 2;

            currentBlueX = X / 2;
            currentBlueY = oldY + oldZ + (oldY / 2);

            redDirection = 0; // right
            blueDirection = 2; //left

            var redIndex = 0;
            var blueIndex = 0;

            while (true)
            {
                #region MoveRed
                int newRedX = currentRedX;
                int newRedY = currentRedY;

                while (redIndex < redMoves.Length && redMoves[redIndex] != 'M')
                {
                    if (redMoves[redIndex] == 'L')
                    {
                        redDirection = RotateLeft(redDirection);
                    }
                    else //if (redMoves[redIndex] == 'R')
                    {
                        redDirection = RotateRight(redDirection);
                    }

                    redIndex++;
                }

                //move

                MovePlayer(ref newRedX, ref newRedY, redDirection);
                redIndex++;

                #endregion

                #region MoveBlue
                int newBlueX = currentBlueX;
                int newBlueY = currentBlueY;
                while (blueIndex < blueMoves.Length && blueMoves[blueIndex] != 'M')
                {
                    if (blueMoves[blueIndex] == 'L')
                    {
                        blueDirection = RotateLeft(blueDirection);
                    }
                    else //if (redMoves[redIndex] == 'R')
                    {
                        blueDirection = RotateRight(blueDirection);
                    }

                    redIndex++;
                }

                MovePlayer(ref newBlueX, ref newBlueY, blueDirection);
                blueIndex++;
                #endregion
                #region Fix Y cords
                if (newRedY >= Y)
                {
                    newRedY = 0;
                }

                if (newRedY < 0)
                {
                    newRedY = Y - 1;
                }

                if (newBlueY >= Y)
                {
                    newBlueY = 0;
                }

                if (newBlueY < 0)
                {
                    newBlueY = Y - 1;
                }
                #endregion

                bool redLoses = Loses(newRedX, newRedY);
                bool blueLoses = Loses(newBlueX, newBlueY);

                if (redLoses && blueLoses)
                {
                    Console.WriteLine("DRAW");
                }
                else if (redLoses)
                {
                    Console.WriteLine("BLUE");
                }
                else if (blueLoses)
                {
                    Console.WriteLine("RED");
                }




                currentRedX = newRedX;
                currentRedY = newRedY;
                currentBlueX = newBlueX;
                currentBlueY = newBlueY;


                if (redLoses || blueLoses)
                {

                    int startRedX = oldX / 2;
                    int startRedY = oldY / 2;
                    int diffRedX = Math.Abs(currentRedX - startRedX);
                    int diffRedY = Math.Abs(currentRedY - startRedY);
                    int diffRed = diffRedX + diffRedY;
                    if (redLoses && blueLoses)
                    {
                        Console.WriteLine(diffRedY - 1);
                    }
                    else
                    {
                        Console.WriteLine(diffRed);
                    }


                    break;
                }
                used[newRedX, newRedY] = true;
                used[newBlueX, newBlueY] = true;

            }
        }

        public static bool Loses(int playerX, int playerY)
        {
            if (playerX < 0)
            {
                return true;
            }
            if (playerX > X)
            {
                return true;
            }
            if (used[playerX, playerY])
            {
                return true;
            }


            return false;
        }

        public static void MovePlayer(ref int currentX, ref int currentY, int direction)
        {
            if (direction == 0)
            {
                currentY++;
            }
            else if (direction == 1)
            {
                currentBlueX++;
            }
            else if (direction == 2)
            {
                currentY--;
            }
            else if (direction == 3)
            {
                currentX--;
            }
        }

        public static void ReadInput()
        {
            string xyz = Console.ReadLine();
            var xyzStringPart = xyz.Split(' ');
            oldX = int.Parse(xyzStringPart[0]);
            oldY = int.Parse(xyzStringPart[1]);
            oldZ = int.Parse(xyzStringPart[2]);

            redMoves = Console.ReadLine();
            blueMoves = Console.ReadLine();

        }
    }
}
