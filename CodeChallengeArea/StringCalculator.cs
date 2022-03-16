using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeChallengeArea
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var delimiters = GetDelimiters(numbers);
            var numbersArray = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            var (negativeNumbers, total) = ValidateAndSumStringNumbers(numbersArray);

            if (negativeNumbers.Any())
            {
                var negativesBuilder = new StringBuilder();
                negativeNumbers.ForEach(x => negativesBuilder.AppendJoin(" ", x.ToString()));

                throw new ApplicationException($"Negatives not allowed: {negativesBuilder}");
            }

            return total;
        }

        private static List<string> GetDelimiters(string numbers)
        {
            var delimiters = new List<string> { "\n", "," };
            if (numbers.StartsWith("//"))
            {
                var dynamicDelimiters = numbers.Split("//", StringSplitOptions.RemoveEmptyEntries);
                var matches = Regex.Matches(dynamicDelimiters[0], @"[\[].*[\]]");
                
                if (matches.Count == 0)
                {
                    var firstChar = dynamicDelimiters[0].Substring(0, 1);
                    delimiters.Add(firstChar);
                    return delimiters;
                }
                var newDelimiters = matches[0].ToString().Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var delimiter in newDelimiters)
                {
                    delimiters.Add(delimiter);
                }
            }

            return delimiters;
        }

        private static (List<int>, int) ValidateAndSumStringNumbers(string[] numbersArray)
        {
            var negativeNumbers = new List<int>();
            var total = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (int.TryParse(numbersArray[i].ToString(), out int number))
                {
                    if (number < 0)
                    {
                        negativeNumbers.Add(number);
                    }

                    if (number > 1000)
                    {
                        number = 0;
                    }

                    total += number;
                }
            }

            return (negativeNumbers, total);
        }
    }
}