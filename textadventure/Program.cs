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

    class Item 
    {
        int coppercoin = 1, silvercoin = 10, goldcoin = 100;
    }

    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Game.NameCharacter();

            
            if (Console.ReadKey(true).Key == ConsoleKey.T)
            {
                Game.Tutorial();
            }

            else{
                Game.PlayGame();
            }           
            //Keeping window opened
            Console.ReadKey();
        }
    }
}
