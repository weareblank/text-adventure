using System;
 namespace textadventure
{
    public static partial class Game {
        public static void PlayGame()
        {   //First real gameplay
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("\nYou open your eyes and sit up.\nYou’re in a bed in a room that you don’t recognize.\nAs you take a look at your surroundings you see a massive oaken door, an old wooden chest and an even older looking wardrobe.");
            Console.WriteLine("\nYou decide it will be best to look around the room to see if there’s anything you recognize.");
            Console.ResetColor();

            Console.ReadKey();

            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("Do you want to...");
            Console.WriteLine("(1)...Inspect the Wardrobe");
            Console.WriteLine("(2)...Search the old chest");
            Console.WriteLine("(3)...Check the door");
            Console.ResetColor();

            //Wardrobe path
            if(Console.ReadKey(true).Key == ConsoleKey.D1 || Console.ReadKey(true).Key == ConsoleKey.NumPad1)
            {
            Console.WriteLine("\nYou decide to get up and check out the wardrobe.\nAs you see yourself in a big fancy looking mirror in a corner of the room you notice that you’re wearing only linen trousers.\nAltogether you look very ragged and dirty.");
            Console.WriteLine("\nYou notice how the right closet door is slightly ajar.\nYou walk closer and open the right door completely.");
            Console.WriteLine("\nInside you find a bunch of items:");
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("\nAquired 1 silver coin");
            Console.WriteLine("Aquired linen shirt");
            Console.WriteLine("Aquired fur coat");
            Console.ResetColor();

            Console.WriteLine("\nYou put on the shirt and put the coin in your pocket. It might come in useful sometime.");

            Console.WriteLine("\n*knock* *knock* *knock*");
            Console.WriteLine("\n\"Hey {0}, so you're finally awake. And you already found the clothes I left you.\"");
            }

            //Chest path
            else if(Console.ReadKey(true).Key==ConsoleKey.D2 || Console.ReadKey(true).Key==ConsoleKey.NumPad2)
            {
                Console.WriteLine("\nYou decide to get up and check out the chest.\nAs you see yourself in a big fancy looking mirror in a corner of the room you notice that you’re wearing only linen trousers.\nAltogether you look very ragged and dirty.");
                Console.WriteLine("\nYou reach the chest and try to open the lid but unfortunately it won't move an inch.");
            }

            //Door path
            else if(Console.ReadKey(true).Key==ConsoleKey.D3 || Console.ReadKey(true).Key==ConsoleKey.NumPad3)
            {
                Console.WriteLine("\nYou decide to get up and check on the door.\nAs you see yourself in a big fancy looking mirror in a corner of the room you notice that you’re wearing only linen trousers.\nAltogether you look very ragged and dirty.");
            }

            
            

        }


    }
}
