using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using System.Net.NetworkInformation;
namespace Assignments
{
    internal class Program
    {
        static void SwapValueByValue(int FirstNumber, int SecondNumber)
        {
            int Temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = Temp;
        }

        static void SwapValueByRef(ref int FirstNumber, ref int SecondNumber)
        {
            int Temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = Temp;
        }

        static int SumArrayByValue(int[] Numbers)
        {
            int Sum = 0;
            Numbers[0] = 100;
            for (int i = 0; i < Numbers.Length; i++)
            {
                Sum += Numbers[i];
            }
            return Sum;
        }

        static int SumArrayByRef(ref int[] Numbers)
        {
            int Sum = 0;
            Numbers[0] = 100;
            for (int i = 0; i < Numbers.Length; i++)
            {
                Sum += Numbers[i];
            }
            return Sum;
        }

        static void SumAndSub(int X, int Y, out int Sum, out int Sub)
        {
            Sum = X + Y;
            Sub = X - Y;
        }

        static int SumDigits(int Number)
        {
            string Sequence = Convert.ToString(Number);
            int Sum = 0;
            for (int i = 0; i < Sequence.Length; i++)
            {
                Sum += Convert.ToInt32(Sequence[i]);
            }
            return Sum;
        }

        static int[] MinMaxArray(ref int[] Numbers)
        {
            int Min = Numbers[0];
            int Max = Numbers[0];
            for (int i = 1; i < Numbers.Length; i++)
            {
                if (Min < Numbers[i])
                {
                    Min = Numbers[i];
                }
                if (Max > Numbers[i])
                {
                    Max = Numbers[i];
                }
            }
            int[] Result = { Min, Max };
            return Result;
        }
        static void Main(string[] args)
        {
            #region Q01
            // 1- Explain the difference between passing (Value type parameters)
            // by value and by reference then write a suitable C# example.

            // Passing Value type parameters by reference sends the variable itself into the functions but passing by values sends the value only and the actual Variable remains intact
            int X = 10;
            int Y = 20;
            Console.WriteLine(X); // 10
            Console.WriteLine(Y); //20

            SwapValueByValue(X, Y);
            Console.WriteLine("After Value Swap");
            Console.WriteLine(X); //10
            Console.WriteLine(Y); //20

            SwapValueByRef(ref X, ref Y);
            Console.WriteLine("After Reference Swap");
            Console.WriteLine(X); //20
            Console.WriteLine(Y); //10 
            #endregion

            #region Q02
            // 2- Explain the difference between passing(Reference type parameters)
            // by value and by reference then write a suitable C# example.

            // On passing them by value, we've created two addresses to the same information in the heap
            int[] Ages = { 10, 20, 30 };
            Console.WriteLine(SumArrayByValue(Ages)); // 150
            Console.WriteLine(Ages[0]); // 100

            // On passing them by reference, we're changing the object itself temorarily. It's the same result but different mechanism
            int[] Salaries = { 1000, 1500, 1500 };
            Console.WriteLine(SumArrayByRef(ref Salaries)); // 3100
            Console.WriteLine(Salaries[0]); // 100

            #endregion

            #region Q03
            // 3- Write a C# Function that accept 4 parameters from user and
            // return result of summation and subtracting of two numbers
            int A = 100, B = 70;
            int SumResult, SubResult;
            SumAndSub(A, B, out SumResult, out SubResult);
            Console.WriteLine(SumResult);
            Console.WriteLine(SubResult);
            #endregion

            #region Q04
            // 4- Write a program in C# Sharp to create a function to calculate the sum of
            // the individual digits of a given number.
            Console.WriteLine(SumDigits(75));
            // في غلط عندي بس مش عارف ايه هو بيديني 108 والمفروض 12
            #endregion

            // 5- Create a function named "IsPrime", which receives an integer number
            // and retuns true if it is prime, or false if it is not
            // معرفش حسابيا ازاي


            #region Q06
            // 6- Create a function named MinMaxArray, to return the minimum and
            // maximum values stored in an array, using reference parametersintintint
            //
            int[] TestNumbers = { 5, 12, 27, 1 };
            int[] Result = MinMaxArray(ref TestNumbers);
            for (int i = 0; i < Result.Length; i++)
                Console.WriteLine(Result[i]);
            #endregion

            // 7- Create an iterative(non-recursive) function to calculate the factorial
            // of the number specified as parameter
            // معرفش حسابيا ازاي

            // 8- Create a function named "ChangeChar" to modify a letter in a certain
            //position(0 based) of a string, replacing it with a different letter
        }
    }
}
