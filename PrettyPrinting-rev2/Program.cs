using System;

namespace PrettyPrinting_rev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World!";
            char corner = '*';
            char horizontalCharacter = '-';
            char verticalCharacter = '|';

            PrintItPretty(input, corner, horizontalCharacter, verticalCharacter);
        }
        public static void PrintItPretty(string input, char corner, char horizontalCharacter, char verticalCharacter)
        {
            int horizontalPadding = 3;
            int contentWidth = input.Length + (horizontalPadding * 2);

            string horizontalBorderLine = $"{corner}{new string(horizontalCharacter,contentWidth)}{corner}";
            string verticalBorderLine = $"{verticalCharacter}{new string(' ',contentWidth)}{verticalCharacter}";
            string inputLine = $"{verticalCharacter}{new string(' ', horizontalPadding)}{input}{new string(' ', horizontalPadding)}{verticalCharacter}";

            Console.WriteLine(horizontalBorderLine);
            Console.WriteLine(verticalBorderLine);
            Console.WriteLine(inputLine);
            Console.WriteLine(verticalBorderLine);
            Console.WriteLine(horizontalBorderLine);
        }
    }

}