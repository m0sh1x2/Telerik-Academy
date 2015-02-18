using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Globalization;

struct Element
{
    // define new object type with structure
    // screen position x,y
    public int x;
    public int y;
    // type of game object is defined by ASCII char
    public char skin;
    public ConsoleColor colour;
}

class PacMan3D
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        #region Memory Initialization

        // set console size (screen resolution)
        Console.BufferHeight = Console.WindowHeight = 21;
        Console.BufferWidth = Console.WindowWidth = 40;

        // set playfield size
        int playfieldHeight = Console.WindowHeight - 1;
        int playfieldWidth = Console.WindowWidth - 20;

        // define hero pacMan as a variable of type element
        Element pacMan = new Element();
        // initial pacman position in center of playfield
        pacMan.x = playfieldWidth / 2;
        pacMan.y = playfieldHeight / 2;
        pacMan.skin = (char)9787; // utf8 decimal code 9787 (smile face) is our hero character
        pacMan.colour = ConsoleColor.Yellow;




        //making list for multiple enemies
        List<Element> BadGuys = new List<Element>();
        // define enemies as a variable of type element
        Element newBadGuy = new Element();
        for (int i = 0; i < 7; i++)
        {
            // initial badguy position on the playfield playfield  
            Random randomizerBadGuy = new Random();
            int positionBadGuyX = randomizerBadGuy.Next(1, 6);
            int positionBadGuyY = randomizerBadGuy.Next(1, 6);
            newBadGuy.x = playfieldHeight / positionBadGuyX;
            newBadGuy.y = playfieldWidth / positionBadGuyY;
            newBadGuy.skin = '\u2666'; // utf8 decimal code 2736 (black star) is our enemy character
            newBadGuy.colour = ConsoleColor.Red;
            BadGuys.Add(newBadGuy);
        }
        // define labyrinth variable and build example
        string[] labyrinth = new string[playfieldHeight];

        Random rand = new Random();


        for (int row = 0; row < playfieldHeight; row++)
        {
            for (int col = 0; col < playfieldWidth; col++)
            {

                if (row == playfieldHeight / 2 && col == playfieldWidth / 2)
                {
                    labyrinth[row] += " ";
                    continue;
                }
                int chance = rand.Next(1, 101);
                if (chance < 20)
                {
                    labyrinth[row] += "\u2588";
                }
                else
                {
                    labyrinth[row] += " ";
                }

            }
        }

        #endregion

        while (true)
        {


            #region Build Frame

            //badguy move pathern
            Random switchBadGuy = new Random();
            int switched = switchBadGuy.Next(4);
            switch (switched)
            {
                case 0:
                    if (newBadGuy.x > 1)
                    {
                        if (labyrinth[newBadGuy.y][newBadGuy.x - 1] != '\u2588')
                        {
                            newBadGuy.x = newBadGuy.x - 1;
                        }
                    }
                    break;
                case 1:
                    if (newBadGuy.x < playfieldWidth - 1)
                    {
                        if (labyrinth[newBadGuy.y][newBadGuy.x + 1] != '\u2588')
                        {

                            newBadGuy.x = newBadGuy.x + 1;
                        }
                    }
                    break;
                case 2:
                    if (newBadGuy.y > 1)
                    {
                        if (labyrinth[newBadGuy.y - 1][newBadGuy.x] != '\u2588')
                        {
                            newBadGuy.y = newBadGuy.y - 1;
                        }
                    }
                    break;
                case 3:
                    if (newBadGuy.y < playfieldHeight - 1)
                    {
                        if (labyrinth[newBadGuy.y + 1][newBadGuy.x] != '\u2588')
                        {
                            newBadGuy.y = newBadGuy.y + 1;
                        }
                    }
                    break;
                default:
                    continue;
            }

            // move PacMan
            while (Console.KeyAvailable)
            {
                // we assign the pressed key value to a variable pressedKey
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                // next we start checking the value of the pressed key and take action if neccessary
                if (pressedKey.Key == ConsoleKey.LeftArrow && pacMan.x > 1) // if left arrow is pressed then
                {
                    if (labyrinth[pacMan.y][pacMan.x - 1] != '\u2588')
                    {
                        pacMan.x = pacMan.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow && pacMan.x < playfieldWidth - 1)
                {
                    if (labyrinth[pacMan.y][pacMan.x + 1] != '\u2588')
                    {

                        pacMan.x = pacMan.x + 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow && pacMan.y > 1)
                {
                    if (labyrinth[pacMan.y - 1][pacMan.x] != '\u2588')
                    {
                        pacMan.y = pacMan.y - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow && pacMan.y < playfieldHeight - 1)
                {
                    if (labyrinth[pacMan.y + 1][pacMan.x] != '\u2588')
                    {
                        pacMan.y = pacMan.y + 1;
                    }
                }

            }


            #endregion

            #region Print Frame

            Console.Clear();    // fast screen clear
            PrintLabyrinth(labyrinth);
            PrintElement(pacMan);
            PrintElement(newBadGuy);
            #endregion

            Thread.Sleep(100);  // control game speed
        }
    }

    static void PrintElement(Element thisObject)
    {
        // print object of type Element
        Console.SetCursorPosition(thisObject.x, thisObject.y);
        Console.ForegroundColor = thisObject.colour;
        Console.Write(thisObject.skin);
    }

    static void PrintLabyrinth(string[] thisArray)
    {
        Console.SetCursorPosition(0, 0);
        Console.ForegroundColor = ConsoleColor.White;
        for (int i = 0; i < thisArray.Length; i++)
        {
            Console.WriteLine(thisArray[i]);
        }
    }
}