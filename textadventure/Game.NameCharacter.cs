using System;
 namespace textadventure
{
    public static partial class Game {
        public static void NameCharacter()
        {
            //Name entry 

            Console.Write("What would you like your name to be?: ");
            string charactername = Console.ReadLine();

            Console.WriteLine("Great. From now on you'll be known as " + charactername);
        }


    }
}
