using System;

namespace Battlefield
{
    class Color
    {
        public static void Text(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
        public static void Reset()
        {
            Console.ForegroundColor = White;
        }

        public static ConsoleColor White = ConsoleColor.White;
        public static ConsoleColor Gray = ConsoleColor.Gray;
        public static ConsoleColor Cyan = ConsoleColor.Cyan;
        public static ConsoleColor Green = ConsoleColor.Green;
        public static ConsoleColor Red = ConsoleColor.Red;
    }
}
