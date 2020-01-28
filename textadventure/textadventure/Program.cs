/*
[Fate of Cynthia]
by Anika Reinhold, started on 01/21/2020
*/

using System;

namespace textadventure
{   
    public static partial class Game 
    {
        //In the other files
    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Game.NameCharacter();

            Console.WriteLine("\nPress T for the tutorial \nPress any other key to start playing");

            if (Console.ReadKey(true).Key == ConsoleKey.T)
            {
                Game.Tutorial();
            }

            Game.PlayGame();          
            //Keeping window opened
            Console.ReadKey();
        }
    }
}
