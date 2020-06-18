using System;

namespace Battlefield
{
    class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Effect { get; set; }
        public int UseTimes { get; set; } = 1;
        public int MinEffect { get; set; }
        public int MaxEffect { get; set; }

        public void Announce(int amount = 1)
        {
            string letter = Name.Substring(0, 1).ToLower();
            if (amount == 1)
            {
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    Game.Message($"You got an {Name}!");
                }
                else
                {
                    Game.Message($"You got a {Name}!");
                }
            }
            else
            {
                Game.Message($"You got {amount} {Name}s!");
            }
            Game.Message(Description, ConsoleColor.Gray);
            Console.WriteLine();
        }
    }
}
