using System;
using System.Collections.Generic;
using System.Linq;

namespace PrettyPrinting_rev1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrettyPrintDesignDTO prettyPrintDesign = new PrettyPrintDesignDTO
            {
                Corner = '*',
                HorizontalCharacter = '-',
                VerticalCharacter = '|',
                HorizontalPadding = 5,
                VerticalPadding = 2,
                LineSpacing = 2
            };

            //Console.WriteLine("What text do you want prettified(not petrified)? Press enter for each line and when you are done type 'continue'.");
            List<string> inputList = GetInput();
            Console.WriteLine(inputList.Count); 
            foreach(string input in inputList)
            {
                Console.WriteLine(input);
            }

            //Console.WriteLine("Do you want to configure the settings? y/n");
            //if (String.Compare(Console.ReadLine(), "y", true) != 1)
            //{
            //    Console.WriteLine("Input a single character as design characters");
            //    Console.WriteLine("...for the top and bottom.");
            //    horizontalCharacter = GetDesign();
            //    Console.WriteLine("...for the sides.");
            //    verticalCharacter = GetDesign();
            //    Console.WriteLine("...for the corners.");
            //    corner = GetDesign();
            //    Console.WriteLine("Input a number ranging from 0 to 9.");
            //    Console.WriteLine("...for the distance between the middle and top.");
            //    verticalPadding = GetSpacing();
            //    Console.WriteLine("...for the distance between the left and the middle.");
            //    horizontalPadding = GetSpacing();
            //    Console.WriteLine("...for the spacing between the lines.");
            //    lineSpacing = GetSpacing();

            //}

            //PrintItPretty(input, corner, horizontalCharacter, verticalCharacter, horizontalPadding, verticalPadding, lineSpacing);
        }

        public static List<string> GetInput()
        {
            Console.WriteLine("Start GetInput");
            List<string> inputList = new List<string>();
            string input;
            do {
                input = Console.ReadLine();
                Console.WriteLine(String.Compare(input, "continue", true));
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty");
                } else if (String.Compare(input, "continue", true) == 1)
                {
                    inputList.Add(input);
                    Console.WriteLine($"added {input}");
                }                    
            } while (String.Compare(input,"continue",true)==1);
            Console.WriteLine("End GetInput");
            return inputList;
        }

        public static char GetChar()
        {
            string input = Console.ReadLine();
            char design;
            if (!char.TryParse(input, out design))
            {
                Console.WriteLine("Must be a single character!");
                design = GetChar();
            }
            return design;
        }

        public static int GetInt()
        {
            string input = Console.ReadLine();
            int spacing;
            if (!int.TryParse(input, out spacing) || spacing < 0 || spacing > 9)
            {
                Console.WriteLine("Must be a number between 0 and 9!");
                spacing = GetInt();
            }
            return spacing;
        }

        //public static void PrintItPretty(List<string> input, char corner, char horizontalCharacter, char verticalCharacter, int horizontalPadding, int verticalPadding, int lineSpacing)
        //{
        //    string longestString = input.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
        //    int width = longestString.Length + (horizontalPadding * 2);

        //    string line15 = corner + new string(horizontalCharacter, width) + corner;
        //    string line24 = verticalCharacter + new string(' ', width) + verticalCharacter;
        //    string line3 = verticalCharacter + new string(' ', horizontalPadding) + input + new string(' ', horizontalPadding) + verticalCharacter;

        //    Console.WriteLine(line15);
        //    for (int i = 0; i < verticalPadding; i++)
        //    {
        //        Console.WriteLine(line24);
        //    }
        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        Console.WriteLine(verticalCharacter + new string(' ', horizontalPadding) + input[i] + new string(' ', horizontalPadding + (longestString.Length - input[i].Length)) + verticalCharacter);
        //        if (i != input.Count - 1)
        //        {
        //            for (int x = 0; x < lineSpacing; x++)
        //            {
        //                Console.WriteLine(line24);
        //            }
        //        }
        //    }
        //    for (int i = 0; i < verticalPadding; i++)
        //    {
        //        Console.WriteLine(line24);
        //    }
        //    Console.WriteLine(line15);
        //}
    }
    public class PrettyPrintDesignDTO
    {
        public char Corner { get; set; }
        public char HorizontalCharacter { get; set; }
        public char VerticalCharacter { get; set; }
        public int HorizontalPadding { get; set; }
        public int VerticalPadding { get; set; }
        public int LineSpacing { get; set; }
    }

    public class PrettyPrint
    {
       public PrettyPrint()
        {

        } 
    }
}