using System;
 namespace textadventure
{
    public static partial class Game {
        public static void Tutorial()
        {   
            Console.WriteLine("Welcome to the tutorial");

            Console.Write("Narrative text will be ");
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("White");
            Console.ResetColor();

            Console.Write("Other people's speech will be ");
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Blue");
            Console.ResetColor();            

            Console.Write("Your speech will be ");
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Green");
            Console.ResetColor();

            Console.Write("Instructions and Events will be ");
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("Purple");
            Console.ResetColor();

        }


    }
}
