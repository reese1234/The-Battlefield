using System.Collections.Generic;

namespace Battlefield
{
    class Data
    {
        public static string Name;
        public static int Health = 50;
        public static int MaxHealth = 50;

        public static int Frendship = 0;

        public static List<Item> Items = new List<Item>();
        public static List<Enemy> Enemies = new List<Enemy>();

        public static Item Mace = new Item
        {
            Name = "Mace",
            Description = "A reliable weapon from Alex. Deals 4-8 damage.",
            Effect = "Attack",
            MinEffect = 4,
            MaxEffect = 8,
            UseTimes = 100
        };

        public static Item SweetApple = new Item
        {
            Name = "Sweet Apple",
            Description = "A sweet red apple fresh from a tree. Restores 1-3 health and has 3 bites.",
            Effect = "Health",
            MinEffect = 1,
            MaxEffect = 3,
            UseTimes = 3
        };


        public static Enemy Hoppy = new Enemy
        {
            Name = "Hoppy",
            MaxHealth = 20,
            MinAttack = 1,
            MaxAttack = 3
        };
    }
}