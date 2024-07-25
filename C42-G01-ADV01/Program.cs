using System.Security.Cryptography;
using System;

namespace C42_G01_ADV01
{
    internal class Program
    {
        // 1.The Bubble Sort algorithm has a time complexity of O(n ^ 2) in its worst
        // and average cases, which makes it inefficient for large datasets.
        // How we can optimize the Bubble Sort algorithm
        // And implement the code of this optimized bubble sort algorithm
        // طبعا أنا معنديش أي أفكار خاصة بيا
        // الحل اللي لقيته على النت اني اشتغل في الاتجاهين بتوع اللستة
        // الحل التاني اني امنعه من انه يلف على اللسته كامله
        public static void TwoDirectionBubbleSort(int[] arr)
        {
            bool swapped = true;
            int start = 0;
            int end = arr.Length;

            while (swapped)
            {
                swapped = false;

                // Loop from left to right
                for (int i = start; i < end - 1; ++i)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                // If nothing moved, then array is sorted.
                if (!swapped)
                    break;

                // Otherwise, reset the swapped flag so that it can be used in the next stage
                swapped = false;

                // Move the end point back by one, because the last element is already in its correct position
                end--;

                // Loop from right to left
                for (int i = end - 1; i >= start; i--)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                // Increase the starting point, because the first element is now sorted
                start++;
            }
        }


        static void Main(string[] args)
        {
            int[] Numbers = { 4, 5, 6, 9, 3, 2, 8, 1, 7 };
            TwoDirectionBubbleSort (Numbers);
            foreach (int number in Numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
