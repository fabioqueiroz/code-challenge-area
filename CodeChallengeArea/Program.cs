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
            #region String Calculator
            //var numbers = "//;\n1;2\n;4,*j";
            //var numbers = "//;\n1;-2\n;-4";
            var numbers = "//;\n1;2\n;1001";
            //var numbers = "//[*][%]\n1*2%3";
            //var numbers = "//[***]\n1***2***3";
            var strCalculator = new StringCalculator();
            Console.WriteLine(strCalculator.Add(numbers));
            #endregion

            #region LinkedList

            // start
            var startLinkedList = new GenericLinkedList<int>();
            startLinkedList.InsertAtStart(3);
            startLinkedList.InsertAtStart(2);
            startLinkedList.InsertAtStart(1);

            startLinkedList.PrintList(); // 1 2 3

            // middle and end
            var linkedList = new GenericLinkedList<int>();
            linkedList.InsertAtStart(1);
            linkedList.InsertAtTheEnd(2);
            linkedList.InsertInTheMiddle(3);

            linkedList.PrintList(); // 1 3 2

            // remove at the start
            Console.WriteLine("Length: " + startLinkedList.Length);
            Console.WriteLine("GetElement: " + startLinkedList.GetElement(0));
            startLinkedList.RemoveAt(0);
            startLinkedList.PrintList(); // 2 3

            // remove at the end
            linkedList.RemoveAt(2);
            linkedList.PrintList(); // 1 3

            #endregion
        }
    }   
}
