using System;
 namespace textadventure
{
    public static partial class Game {
        public static void Tutorial()
        {   
            Console.WriteLine("\nWelcome to the tutorial");

            Console.Write("\nNarrative text will be ");
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("White");
            Console.ResetColor();

            Console.Write("\nHints will be ");
            Console.ForegroundColor=ConsoleColor.DarkGray;
            Console.WriteLine("Grey");
            Console.ResetColor(); 

            Console.Write("\nOther people's speech will be ");
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Blue");
            Console.ResetColor();            

            Console.Write("\nYour speech will be ");
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Green");
            Console.ResetColor();

            Console.Write("\nEvents will be ");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("Purple");
            Console.ResetColor();

            Console.Write("\nItems will be ");
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("Yellow");
            Console.ResetColor(); 

            Console.ReadKey();

        }


    }
}
