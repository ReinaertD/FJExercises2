using System;
using System.Collections.Generic;
using System.Linq;

namespace PrettyPrinting_rev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Input = "Hello World!";
            List<string> input = new List<string> { "Hello world!", "I am", "A multiline!" };

            PrintItPretty(input);
        }
        public static void PrintItPretty(List<string> input)
        {
            int horizontalPadding = 3;
            int borderThickness = 1;
            string longestString = input.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
            int width = longestString.Length + (horizontalPadding * 2) + (borderThickness * 2);
            char border = '*';

            Console.WriteLine(new string(border, width));
            Console.WriteLine(border + new string(' ', width - 2) + border);
            input.ForEach(delegate (string line)
            {
                Console.WriteLine(border + new string(' ', horizontalPadding) + line + new string(' ', horizontalPadding + (longestString.Length - line.Length)) + border);
            });
            Console.WriteLine(border + new string(' ', width - 2) + border);
            Console.WriteLine(new string(border, width));
        }
    }
}
