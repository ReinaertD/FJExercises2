using System;

namespace PrettyPrinting_rev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World!";
            PrettyPrintDesignDTO design = new PrettyPrintDesignDTO()
            {
                CornerCharacter = '*',
                VerticalCharacter = '|',
                HorizontalCharacter = '-',
                HorizontalPadding = 5,
                VerticalPadding = 2
            };

            PrintItPetty(input, design);
        }
        public static void PrintItPetty(string input, PrettyPrintDesignDTO design)
        {
            int contentWidth = input.Length + (design.HorizontalPadding * 2);

            string horizontalBorderLine = $"{design.CornerCharacter}{new string(design.HorizontalCharacter, contentWidth)}{design.CornerCharacter}";
            string verticalBorderLine = $"{design.VerticalCharacter}{new string(' ', contentWidth)}{design.VerticalCharacter}";
            string inputLine = $"{design.VerticalCharacter}{new string(' ', design.HorizontalPadding)}{input}{new string(' ', design.HorizontalPadding)}{design.VerticalCharacter}";

            Console.WriteLine(horizontalBorderLine);
            for(int i = 0; i<= design.VerticalPadding; i++)
            {
                Console.WriteLine(verticalBorderLine);
                i++;
            }
            Console.WriteLine(inputLine);
            for(int i = 0; i<= design.VerticalPadding; i++)
            {
                Console.WriteLine(verticalBorderLine);
                i++;
            }
            Console.WriteLine(horizontalBorderLine);
        }
    }

    public class PrettyPrintDesignDTO
    {
        public char CornerCharacter { get; set; }
        public char HorizontalCharacter { get; set; }
        public char VerticalCharacter { get; set; }
        public int HorizontalPadding { get; set; }
        public int VerticalPadding { get; set; }

       }
}
