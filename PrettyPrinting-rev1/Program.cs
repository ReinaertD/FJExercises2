using System;

namespace PrettyPrinting_rev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World!";

            PrintItPretty(input);
        }
        public static void PrintItPretty(string input)
        {
            int horizontalPadding = 3;
            int borderThickness = 1;
            int width = input.Length + (horizontalPadding * 2) + (borderThickness * 2);
            char border = '*';

            string line15 = new string(border, width);
            string line24 = border + new string(' ', width - 2) + border;
            string line3 = border + new string(' ', horizontalPadding) + input + new string(' ', horizontalPadding) + border;

            Console.WriteLine(line15);
            Console.WriteLine(line24);
            Console.WriteLine(line3);
            Console.WriteLine(line24);
            Console.WriteLine(line15);
        }
    }
}
