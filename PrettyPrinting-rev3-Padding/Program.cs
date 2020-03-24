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
            int horizontalPadding = 5;
            int verticalPadding = 2;

            PrintItPretty(input, corner, horizontalCharacter, verticalCharacter, horizontalPadding, verticalPadding);
        }
        public static void PrintItPretty(string input, char corner, char horizontalCharacter, char verticalCharacter, int horizontalPadding, int verticalPadding)
        {
            int width = input.Length + (horizontalPadding * 2);

            string line15 = corner + new string(horizontalCharacter, width) + corner;
            string line24 = verticalCharacter + new string(' ', width) + verticalCharacter;
            string line3 = verticalCharacter + new string(' ', horizontalPadding) + input + new string(' ', horizontalPadding) + verticalCharacter;

            Console.WriteLine(line15);
            for (int i = 0; i <= verticalPadding; i++)
            {
                Console.WriteLine(line24);
                i++;
            }
            Console.WriteLine(line3);
            for (int i = 0; i <= verticalPadding; i++)
            {
                Console.WriteLine(line24);
                i++;
            }
            Console.WriteLine(line15);
        }
    }
}
