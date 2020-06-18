using System;
using System.Threading;

namespace Battlefield
{
    class Program
    {
        static void Main()
        {
            Game.SetSpeed();
            for (; ; )
            {
                try
                {
                    Play();
                }
                catch (Exception e)
                {
                    Color.Text(Color.Red);
                    Game.Message("Error occured...");
                    Console.WriteLine(e);
                }
                finally
                {
                    Color.Text(Color.Green);
                    Console.WriteLine("Restarting...");
                    Thread.Sleep(2000);
                    Color.Reset();
                }
            }
        }

        public static void Play()
        {
            Console.WriteLine();

            Game.Message("You wake up on a soft bed, staring up at the ceiling.");
            Game.Message("You don't seem to remember much, just about this moment.");
            Game.Message("An exhausted man runs into the room, holding a mace.");
            Game.Character("???", "You're finally awake! Sorry, they had to give you anesthesia to keep you alive.");

            Game.Character("???", "Oh, and also, my name is Alex. What's yours?");
            Console.Write("> ");
            Color.Text(Color.Green);
            Data.Name = Console.ReadLine();
            Color.Reset();

            Game.Character($"You ({Data.Name})", $"I'm {Data.Name}.", Color.Green);
            Game.Character("Alex", $"Nice to meet you, {Data.Name}. Now let's get you into The Battlefield!");
            Game.Character("Alex", "Here. You'll need these.");

            Data.Items.Add(Data.Mace);
            Data.Items.Add(Data.SweetApple);
            Data.Items.Add(Data.SweetApple);
            Data.Items.Add(Data.SweetApple);
            Data.Mace.Announce();
            Data.SweetApple.Announce(3);

            Game.Message("Alex helps you");

            Game.Exit();
        }
    }
}