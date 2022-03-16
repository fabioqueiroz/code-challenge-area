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
            //var numbers = "//;\n1;2\n;4,*j";
            //var numbers = "//;\n1;-2\n;-4";
            var numbers = "//;\n1;2\n;1001";
            //var numbers = "//[*][%]\n1*2%3";
            //var numbers = "//[***]\n1***2***3";
            var strCalculator = new StringCalculator();
            Console.WriteLine(strCalculator.Add(numbers));
        }
    }   
}
