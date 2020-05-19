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

            string horizontalBorderLine = new string(border, width);
            string verticalBorderLine = $"{border}{new string(' ', width-2)}{border}";
            string inputLine = $"{border}{new string(' ',horizontalPadding)}{input}{new string(' ',horizontalPadding)}{border}";

            Console.WriteLine(horizontalBorderLine);
            Console.WriteLine(verticalBorderLine);
            Console.WriteLine(inputLine);
            Console.WriteLine(verticalBorderLine);
            Console.WriteLine(horizontalBorderLine);
        }
    }
}
