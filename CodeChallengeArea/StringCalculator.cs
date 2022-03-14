using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            //var numbersArray = numbers.Split(new string[] { ",", "//", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var numbersArray = numbers.Split(new string[] { ",", "//", ";" , "*", "%", "\n", "***" }, StringSplitOptions.RemoveEmptyEntries);
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

            if (negativeNumbers.Any())
            {
                var negativesBuilder = new StringBuilder();
                negativeNumbers.ForEach(x => negativesBuilder.AppendJoin(" ",x.ToString()));

                throw new ApplicationException($"Negatives not allowed: {negativesBuilder}");
            }

            return total;
        }

        private static (List<int>, int) ValidateStringNumbers(string[] numbersArray)
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
