using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C42_G01_ADV02
{
    internal class Program
    {
        static void ReverseArrayList(ref ArrayList arrayList)
        {
            ArrayList TempArrayList = new ArrayList(arrayList.Count);
            for (int i = arrayList.Count - 1; i >= 0; i--)
            {
                TempArrayList.Add(arrayList[i]);
            }

            arrayList = TempArrayList;
        }

        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }
        static void Main(string[] args)
        {
            #region Part01
            // مش فاهم الكلمتين دول
            // Time Complexity
            // Business Case
            #endregion

            #region Q01
            // You are given an ArrayList containing a sequence of elements. try to
            // reverse the order of elements in the ArrayList in-place(in the same
            // arrayList) without using the built-in Reverse.Implement a function that
            // takes the ArrayList as input and modifies it to have the reversed order of
            // elements.

            ArrayList arrayList01 = new ArrayList(5) { 1, 2, 3, 4, 5 };
            ReverseArrayList(ref arrayList01);
            foreach (int number in arrayList01)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region Q02
            List<int> NumbersList01 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> EvenNumbersList = GetEvenNumbers(NumbersList01);

            foreach (int number in EvenNumbersList)
            {
                Console.Write($"{number} ");
            }
            #endregion

            #region Q03
            FixedSizeList<int> fixedList = new FixedSizeList<int>(3);
            fixedList.Add(1);
            fixedList.Add(2);
            fixedList.Add(3);
            fixedList.Add(4);
            #endregion
        }
    }
}
