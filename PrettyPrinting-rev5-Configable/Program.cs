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

            List<string> inputList = GetInput();
            foreach(string input in inputList)
            {
                Console.WriteLine(input);
            }

        }

        public static List<string> GetInput()
        {
            Console.WriteLine("Start GetInput");
            Console.WriteLine("Type continue to finish your input");
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

}