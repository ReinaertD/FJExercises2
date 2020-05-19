using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrettyPrinting_rev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Input = "Hello World!";
            List<string> input = new List<string> { "Hello world!", "I am", "A multiline!" };

            PrettyPrintDesignDTO design = new PrettyPrintDesignDTO()
            {
                HorizontalPadding = 3,
                BorderThickness = 1,
                BorderCharacter = '*'
            };

            Console.WriteLine(PrintItPretty(input,design));
        }
        public static StringBuilder PrintItPretty(List<string> input, PrettyPrintDesignDTO dto)
        {
            int longestStringLength = input.Max(s => s.Length);
            int width = longestStringLength + (dto.HorizontalPadding * 2) + (dto.BorderThickness * 2);

            string horizontalBorderLine = new string(dto.BorderCharacter, width);
            string verticalBorderLine = dto.BorderCharacter + new string(' ', width - 2) + dto.BorderCharacter;

            StringBuilder textResult = new StringBuilder();
            textResult.AppendLine(horizontalBorderLine);
            textResult.AppendLine(verticalBorderLine);
            foreach (string line in input)
            {
                textResult.AppendLine($"{dto.BorderCharacter}{new string(' ', dto.HorizontalPadding)}{line}{new string(' ', dto.HorizontalPadding + (longestStringLength - line.Length))}{dto.BorderCharacter}");
            }
            textResult.AppendLine(verticalBorderLine);
            textResult.AppendLine(horizontalBorderLine);
            return textResult;
        }
    }

    public class PrettyPrintDesignDTO
    {
        public int HorizontalPadding { get; set; }
        public int BorderThickness { get; set; }
        public char BorderCharacter { get; set; }
    }
}
