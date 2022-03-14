using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeChallengeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var solution = new Solution();
            //solution.RunLengthEncoding("aaabbcdddd");
            //solution.Test();
            //solution.NumberOfOcurrences("abcABC");

            //var numbers = "//;\n1;2\n;4,*j";
            //var numbers = "//;\n1;-2\n;-4";
            //var numbers = "//;\n1;2\n;1001";
            //var numbers = "//[*][%]\n1*2%3";
            var numbers = "//[***]\n1***2***3";
            var strCalculator = new StringCalculator();
            Console.WriteLine(strCalculator.Add(numbers));
        }
    }

    public class Solution
    {
        public string RunLengthEncoding(string input)
        {
            // Your code goes here          
            var builder = new StringBuilder();

            if (input != null)
            {
                var matches = Regex.Matches(input, @"(.)\1+");
                
                for (int i = 0; i < matches.Count; i++)
                {
                    var occurrence = matches[i].Length;
                    var letter = matches[i].Value.ToArray()[0];
                    
                    //for (int j = 0; j < input.Length - 1; j++)
                    //{
                    //    char singleLetter;

                    //    if (input[j] != input[j + 1] && 
                    //        input[j].ToString() != matches[i].Groups[1].ToString())
                    //    {
                    //        singleLetter = input[j];
                    //    }
                    //}

                    builder.Append($"{occurrence}{letter}");
                }

                Console.WriteLine(builder.ToString());

                return builder.ToString();
            }
            return string.Empty;
        }

        public int Test()
        {
            var numbers = new int[] {2, 3, 4, 6 };

            int sum = 0;
            for (var i = 0; i < numbers.Count(); i++)
            {
                sum += numbers[i];

            }
            Console.WriteLine(sum / numbers.Length);
            return sum / numbers.Length;
        }

        public int NumberOfOcurrences(string input)
        {
            var matches = Regex.Matches(input, @"[a|A]{1,}");
            Console.WriteLine(matches.Count);

            return matches.Count;
        }

    }
}
