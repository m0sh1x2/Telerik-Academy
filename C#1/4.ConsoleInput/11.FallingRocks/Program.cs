using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _11.FallingRocks
{
    class Program
    {
        // Main variables
        static int speed = 100;
        static int width = 90;
        static int height = 30;
        static int positonX = 0;
        static int positionY = 0;
        static bool gameOver = false;

        //Directions
        static int left = 50;
        static int right = 29;



        //Player
        static int playerDirection = left;
        static int playerScore = 0;

        // Game stuff
        static string dwarf = "(0)";
        static string[] rocks = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
        static int max = rocks.Length - 1;
        static int test1 = 4;
        static int test2 = 1;
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            testRocks testRock1 = new testRocks();
            testRocks testRock2 = new testRocks();
            testRocks testRock3 = new testRocks();
            testRocks testRock4 = new testRocks();
            testRocks testRock5 = new testRocks();
            testRocks testRock6 = new testRocks();
            testRocks testRock7 = new testRocks();
            testRocks testRock8 = new testRocks();
            testRocks testRock9 = new testRocks();

            testRocks testRock10 = new testRocks();
            testRocks testRock11 = new testRocks();
            testRocks testRock12 = new testRocks();
            testRocks testRock13 = new testRocks();
            testRocks testRock14 = new testRocks();
            testRocks testRock15 = new testRocks();
            testRocks testRock16 = new testRocks();
            testRocks testRock17 = new testRocks();
            testRocks testRock18 = new testRocks();
            testRocks testRock19 = new testRocks();

            //Console.WriteLine(random);
            setGameCanvas();

            while (true)
            {
                
                playerScore += 1;
                getScore();
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    //Console.Write(key);
                    setPlayerDirection(key);
                }

                //Console.Clear();

                setPlayerCordinates(left, right);

                //letItFall(5);
                testRock1.letItFall(10, 1);
                if (playerScore >= 10)
                {
                    testRock2.letItFall(50, 2);
                }
                if (playerScore >= 20)
                {
                    testRock3.letItFall(30, 3);
                }
                if (playerScore >= 30)
                {
                    testRock4.letItFall(30, 4);
                }
                if (playerScore >= 40)
                {
                    testRock5.letItFall(40, 5);
                }
                if (playerScore >= 50)
                {
                    testRock6.letItFall(15, 6);
                }
                if (playerScore >= 60)
                {
                    testRock7.letItFall(13, 7);
                }
                if (playerScore >= 70)
                {
                    testRock8.letItFall(7, 8);
                }
                if (playerScore >= 80)
                {
                    testRock9.letItFall(25, 9);
                }
                // mORE MORE MORE 

                if (playerScore >= 90)
                {
                    testRock10.letItFall(30, 10);
                }
                if (playerScore >= 100)
                {
                    testRock11.letItFall(1, 1);
                }
                if (playerScore >= 110)
                {
                    testRock12.letItFall(25, 2);
                }
                if (playerScore >= 120)
                {
                    testRock13.letItFall(55, 3);
                }
                if (playerScore >= 130)
                {
                    testRock14.letItFall(42, 4);
                }
                if (playerScore >= 140)
                {
                    testRock15.letItFall(25, 5);
                }
                if (playerScore >= 150)
                {
                    testRock16.letItFall(50, 6);
                }
                if (playerScore >= 160)
                {
                    testRock17.letItFall(57, 7);
                }
                if (playerScore >= 170)
                {
                    testRock18.letItFall(5, 8);
                }
                if (playerScore >= 180)
                {
                    testRock19.letItFall(3, 9);
                }
                if (playerScore >= 200)
                {
                    speed = 100;
                    fatalEnd();
                    if (test2 >= 28)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Over SO SAD !");
                        break;
                    }
                }

                
                Thread.Sleep(speed);
                if (gameOver == true)
                {
                    
                    break;
                }
            }
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Game over :(");
        }
        static void fatalEnd()
        {
            test2--;

            Console.SetCursorPosition(1, test2);
            Console.Write("                                                              ");
            test2++;
            Console.SetCursorPosition(1, test2);
            test2++;
            Console.Write("--------------------------------------------------------------");
            if (test2 >= 29)
            {
                Console.SetCursorPosition(65, 5);
                Console.WriteLine("Game Over");
                test2 = 1;
                

            }

        }
        class testRocks
        {
            int test2 = 1;
            public void letItFall(int theRandom, int type)
            {


                test2--;
                Console.SetCursorPosition(theRandom, test2);
                Console.Write("   ");
                test2++;
                Console.SetCursorPosition(theRandom, test2);
                Random rnd = new Random();
                int random = rnd.Next(0, max);

                string returnRock = rocks[type];
                if (test2 >= 29)
                {

                    Console.SetCursorPosition(theRandom, test2);
                    //Console.Write("  ");
                    test2 = 0;
                    returnRock = " ";
                }
                test2++;
                Console.Write(returnRock);
                //Console.Write(test2);

                // COLISION DETECTION !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if ((theRandom-2 == left || theRandom == left || (theRandom - 1) == left) && test2 == 29)
                {
                    //Console.Clear();
                    Console.SetCursorPosition(65, 4);
                    Console.Write("Game Over !");
                    gameOver = true;
                }
            }
        }
        static void getScore()
        {
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : {0}", playerScore);
            Console.SetCursorPosition(65, 2);
            Console.Write("Position : {0}",left);

            
        }
        static void setGameCanvas()
        {
            Console.WindowWidth = width;
            Console.WindowHeight = height;

            Console.BufferWidth = width;
            Console.BufferHeight = height;


            for (int i = 0; i < 30; i++)
            {
                Console.SetCursorPosition(63, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : {0}", playerScore);
        }
        //static void letItFall(int theRandom)
        //{


        //    test2--;
        //    Console.SetCursorPosition(theRandom, test2);
        //    Console.Write("   ");
        //    test2++;
        //    Console.SetCursorPosition(theRandom, test2);
        //    Random rnd = new Random();
        //    int random = rnd.Next(0, max);

        //    if (test2 >= 29)
        //    {
        //        Console.SetCursorPosition(theRandom, test2);
        //        Console.Write("                                                         ");
        //        test2 = 0;
        //    }

        //    test2++;
        //    Console.Write(rocks[random]);


        //}


        static void setPlayerCordinates(int x, int y)
        {

            Console.SetCursorPosition(x - 1, y);
            Console.Write(" ");
            Console.SetCursorPosition(x, y);
            Console.Write(dwarf);
            Console.Write(" ");

        }
        static void setPlayerDirection(ConsoleKeyInfo key)
        {

            if (key.Key == ConsoleKey.LeftArrow)
            {


                left--;
                if (left <= 1)
                {
                    left = 2;
                }
            }
            if (key.Key == ConsoleKey.RightArrow)
            {

                if (left >= 59)
                {
                    left = 58;
                }
                left++;
            }

        }
    }
}
