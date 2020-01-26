using System;
 namespace textadventure
{
    public static partial class Game {
        public static void PlayGame()
        {   //First real gameplay
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("You open your eyes and sit up.\nYou’re in a bed in a room that you don’t recognize.\nAs you take a look at your surroundings you see a massive oaken door, an old wooden chest and an even older looking wardrobe.");
            Console.WriteLine("You decide it will be best to look around the room to see if there’s anything you recognize.");
            Console.ResetColor();

            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("Do you want to...");
            Console.WriteLine("(1)...Inspect the Wardrobe");
            Console.WriteLine("(2)...Search the old chest");
            Console.WriteLine("(3)...Check the door");
            Console.ResetColor();

            //Wardrobe path
            if(Console.ReadKey(true).Key == ConsoleKey.D1 || Console.ReadKey(true).Key == ConsoleKey.NumPad1)
            {
            Console.WriteLine("You decide to get up and check out the wardrobe.\nAs you see yourself in a big fancy looking mirror in a corner of the room you notice that you’re wearing only linen trousers.\nAltogether you look very ragged and dirty.\nYou notice how the right closet door is slightly ajar.\nYou walk closer and open the right door completely.");
            Console.WriteLine("Inside you find a bunch of items:");
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("Aquired 1 silver coin");
            Console.WriteLine("Aquired linen shirt");
            Console.WriteLine("Aquired fur coat");
            Console.ResetColor();
            }
            else{
                Console.WriteLine("Hier gibt's noch nichts :P");
            }
        }


    }
}
