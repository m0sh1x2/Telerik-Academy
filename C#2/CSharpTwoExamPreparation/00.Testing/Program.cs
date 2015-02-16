using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

// define structure with all parameters needed for our game elements
// it can be anything - wall, enemy, pac man, door ect.
// think of a structure as a variable type like int, double, string ect.
// our structure is called element and it will have all the 
// properties that we`ll define in it
// we can create new objects of type elements the same way we
// define new strings, integers, floats and any other object
// element pacMan = new element();
// pacMan.skin = 'o'; //will set variable pacMan character to 'o'
struct Element
{
    public int x;   // x coordinate
    public int y;   // y coordinate

    // the type of game object will be defined by the ASCII character
    // for example enemies can be char 'Y', pacman can be char 'o'
    public char skin;
    public ConsoleColor colour; //sets color of char (game object)
}

class PacMan3D
{
    // this method will draw our object on the console when called
    // on the specified position and with specified character and
    // colour. Method is small code with specialized function
    // that can be called anytime in the main code block to do
    // its job. Instead of writing over and over again the same
    // lines of code, we just call the method by its name
    static void RenderObject(int x, int y, char skin,
        ConsoleColor colour = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = colour;
        Console.Write(skin);
    }

    // next is our main method, think of it as our core game code
    // that will call other defined methods (additional game codes)
    // to do certain tasks. This is the place from where our program
    // starts running.
    static void Main()
    {
        // first we set the console width and height (game resolution)
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 30;

        //next we create our hero pacMan as a variable of type element
        Element pacMan = new Element();
        // initial pacman position in center of screen
        pacMan.x = Console.WindowWidth / 2;
        pacMan.y = Console.WindowHeight / 2;
        pacMan.skin = (char)9787; // utf8 decimal code 9787 (smile face) is our hero character
        pacMan.colour = ConsoleColor.Yellow;

        while (true)
        {
            // first we listen for use input and if a key is pressed then we enter the cycle
            while (Console.KeyAvailable)
            {
                // we assign the pressed key value to a variable pressedKey
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                // next we start checking the value of the pressed key and take action if neccessary
                if (pressedKey.Key == ConsoleKey.LeftArrow) // if left arrow is pressed then
                {
                    if (pacMan.x - 1 >= 0)  // if we reached the leftmost part of the screen do nothing
                    {
                        pacMan.x = pacMan.x - 1;    // if we haven`t recached the leftomost part of screen change x position of element pacMan one character ot the left
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (pacMan.x + 1 < Console.WindowWidth)
                    {
                        pacMan.x = pacMan.x + 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (pacMan.y - 1 >= 0)
                    {
                        pacMan.y = pacMan.y - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    // I don`t use the last line (WindowHeight -1) for game field because
                    // there is a bug with the console bottom right pixel
                    // the cursor is shifted to previous line after printig to it so it must be
                    // exluded or our hero gets teleported. Assume that last line of screen is unusable
                    if (pacMan.y + 1 < Console.WindowHeight - 1)
                    {
                        pacMan.y = pacMan.y + 1;
                    }
                }
            }

            Console.Clear();    //resets the screen (clears the screen for next frame printing)

            // From this point on we have a blank (empty) console screen and start writing the next "frame" to it.
            // This means that we print all the elements in their new coordinates. And return to the beginning of the while
            // cycle to start calculating their next coordinates before clearing the screen again and printing the next frame.

            // Next we call the method we created earlier RenderObject. It prints character in pacMan.skin variable to x and y 
            // coordinates of variables pacMan.x and pacMan.y with colour of variable pacMan.colour.
            RenderObject(pacMan.x, pacMan.y, pacMan.skin, pacMan.colour);

            Thread.Sleep(100);  //this controls the framerate (speed of game) - the time to wait before returning to the beginning of the while cycle and starting to print the new state of all objects to console screen again
        }
    }
}
