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
            int width = input.Length + (horizontalPadding * 2);

            string line15 = corner + new string(horizontalCharacter, width) + corner;
            string line24 = verticalCharacter + new string(' ', width) + verticalCharacter;
            string line3 = verticalCharacter + new string(' ', horizontalPadding) + input + new string(' ', horizontalPadding) + verticalCharacter;

            Console.WriteLine(line15);
            Console.WriteLine(line24);
            Console.WriteLine(line3);
            Console.WriteLine(line24);
            Console.WriteLine(line15);
        }
    }

}