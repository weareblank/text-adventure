using System;
 namespace textadventure
{
    public static partial class Game {
        public static void StartGame()
        {
            //Welcoming Message

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Maybe this will be replaced by fancy ascii art
            //setting title to center

            string title = "Fate";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", title));

            string startmessage = "\nThis is a text adventure where you’ll be exploring a world, find items and hopefully help some people with their problems.\nPress enter to start";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (startmessage.Length / 2)) + "}", startmessage));

            Console.ReadLine();

            Console.ResetColor();

        }


    }
}
