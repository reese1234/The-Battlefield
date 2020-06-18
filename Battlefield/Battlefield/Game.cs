using System;
using System.Threading;

namespace Battlefield
{
    class Game
    {
        public static int GameSpeed = 50;

        public static void Message(string message, ConsoleColor color = ConsoleColor.White)
        {
            Color.Text(color);
            foreach (char letter in message)
            {
                Console.Write(letter);
                Thread.Sleep(GameSpeed);
            }
            Color.Reset();
            Console.WriteLine();
        }
        public static void Character(string name, string message, ConsoleColor color = ConsoleColor.Cyan)
        {
            Color.Text(color);
            Console.Write($"{name}: ");
            Color.Text(Color.Gray);
            foreach (char letter in message)
            {
                Console.Write(letter);
                Thread.Sleep(GameSpeed);
            }
            Color.Reset();
            Console.WriteLine();
        }

        public static int Rnd(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max + 1);
        }

        public static void SetSpeed()
        {
            Message("Set a typing speed: 0 - Slowest, 50 - Default, 100 - Fastest");
            for (; ; )
            {
                Console.Write("> ");
                Color.Text(Color.Green);
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out _);
                if (isNumber == false)
                {
                    Message("That's not a number or between 0 and 100.", Color.Red);
                    continue;
                }
                if (!(input == "") && Convert.ToInt32(input) >= 0 && Convert.ToInt32(input) <= 100)
                {
                    GameSpeed = 100 - Convert.ToInt32(input);
                }
                Message("Are you happy with this speed? Y/N");
                Console.Write("> ");
                Color.Text(Color.Green);
                if (Console.ReadLine().ToLower().Contains("y"))
                {
                    break;
                }
                Color.Reset();
            }
        }
        public static void Exit()
        {
            Message("\n\nWould you like to exit? Y/N");
            Console.Write("> ");
            Color.Text(Color.Green);
            if (Console.ReadLine().ToLower().Contains("y"))
            {
                Environment.Exit(0);
            }
        }
    }
}
