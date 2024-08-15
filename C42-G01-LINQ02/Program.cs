using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static C42_G01_LINQ02.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C42_G01_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            // 1. Find all products that are out of stock.
            Console.WriteLine("All products that are out of stock");
            Console.WriteLine("==========");
            var Result01 = ProductsList.Where(P => P.UnitsInStock == 0);
            foreach (var item in Result01) Console.WriteLine(item);

            // 2. Find all products that are in stock and cost more than 3.00 per unit.
            Console.WriteLine("\nThe products that are in stock and cost more than 3.00 per unit");
            Console.WriteLine("==========");
            var Result02 = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00m);
            foreach (var item in Result02) Console.WriteLine(item);

            // 3. Returns digits whose name is shorter than their value.
            Console.WriteLine("\nDigits whose name is shorter than their value");
            Console.WriteLine("==========");
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var Result03 = Arr.Where((X, I) => I > X.Length);
            foreach (var item in Result03) Console.Write($"{item} ");
            #endregion

            #region LINQ - Element Operators
            // 1. Get first Product out of Stock
            Console.WriteLine("\nGet first Product out of Stock");
            Console.WriteLine("==========");
            var Result04 = ProductsList.Where((P, I) => I == 0 && P.UnitsInStock == 0);
            foreach (var item in Result04) Console.WriteLine(item);

            // 2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            Console.WriteLine("\nProduct whose Price > 1000, unless there is no match, in which case null is returned");
            Console.WriteLine("==========");
            var Result05 = ProductsList.Where(P => P.UnitPrice > 1000);
            foreach (var item in Result05) Console.WriteLine(item);

            // 3.Retrieve the second number greater than 5
            Console.WriteLine("\nRetrieve the second number greater than 5");
            Console.WriteLine("==========");
            int[] Arr01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result06 = Arr01.Where(X => X > 5).ElementAt(1);
            Console.WriteLine(Result06);
            #endregion

            #region LINQ - Aggregate Operators
            // 1. Uses Count to get the number of odd numbers in the array
            Console.WriteLine("\nThe number of odd numbers in the array");
            Console.WriteLine("==========");
            int[] Arr02 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var Result07 = Arr02.Count(P => P % 2 != 0);
            Console.WriteLine(Result07);

            // 2. Return a list of customers and how many orders each has.
            Console.WriteLine("\nList of customers and how many orders each has");
            Console.WriteLine("==========");
            var Result08 = CustomersList.Select(C => new { Name = C.CustomerName, Orders = C.Orders.Length });
            foreach (var item in Result08) Console.WriteLine(item);

            // 3. Return a list of categories and how many products each has
            Console.WriteLine("\nList of categories and how many products each has");
            Console.WriteLine("==========");
            var Result09 = ProductsList.GroupBy(P => P.Category).Select(G => new { Category = G.Key, Count = G.Count() });
            foreach (var item in Result09) Console.WriteLine(item);

            // 4. Get the total of the numbers in an array.
            Console.WriteLine("\nGet the total of the numbers in an array");
            Console.WriteLine("==========");
            int[] Arr03 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int Sum = Arr03.Sum();
            Console.WriteLine(Sum);

            // الجزء ده متشرحش
            // 5. Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            // 6.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            // 7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            // 8.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            // 9.Get the total units in stock for each product category.
            Console.WriteLine("\nTotal units in stock for each product category");
            Console.WriteLine("==========");
            var Result10 = ProductsList.GroupBy(P => P.Category).Select(G => new { Category = G.Key, TotalUnits = G.Sum(P => P.UnitsInStock) });
            foreach (var item in Result10) Console.WriteLine(item);

            // 10.Get the cheapest price among each category's products
            Console.WriteLine("\nThe cheapest price among each category's products");
            Console.WriteLine("==========");
            var Result11 = ProductsList.GroupBy(P => P.Category).Select(G => new { Category = G.Key, Cheapest = G.Min(P => P.UnitPrice) });
            foreach (var item in Result11) Console.WriteLine(item);

            // 11.Get the products with the cheapest price in each category(Use Let)
            Console.WriteLine("\nThe products with the cheapest price in each category(Use Let)");
            Console.WriteLine("==========");
            var Result12 = ProductsList.GroupBy(P => P.Category).Select(G => G.OrderBy(P => P.UnitPrice).First());
            foreach (var item in Result12) Console.WriteLine(item);

            // 12.Get the most expensive price among each category's products.
            Console.WriteLine("\nThe most expensive price among each category's products");
            Console.WriteLine("==========");
            var Result13 = ProductsList.GroupBy(P => P.Category).Select(G => new { Category = G.Key, MostExpensive = G.Max(P => P.UnitPrice) });
            foreach (var item in Result13) Console.WriteLine(item);

            // 13.Get the products with the most expensive price in each category.
            Console.WriteLine("\nThe products with the most expensive price in each category(Use Let)");
            Console.WriteLine("==========");
            var Result14 = ProductsList.GroupBy(P => P.Category).Select(G => G.OrderByDescending(P => P.UnitPrice).First());
            foreach (var item in Result14) Console.WriteLine(item);

            // 14.Get the average price of each category's products.
            Console.WriteLine("\nThe average price among each category's products");
            Console.WriteLine("==========");
            var Result15 = ProductsList.GroupBy(P => P.Category).Select(G => new { Category = G.Key, AverageExpensive = G.Average(P => P.UnitPrice) });
            foreach (var item in Result15) Console.WriteLine(item);
            #endregion

            #region LINQ - Ordering Operators
            // 1. Sort a list of products by name
            Console.WriteLine("\nSort a list of products by name");
            Console.WriteLine("==========");
            var Result16 = ProductsList.OrderBy(P => P.ProductName);
            foreach (var item in Result16) Console.WriteLine(item);

            // 2. Use a custom comparer to do a case-insensitive sort of the words in an array.
            string[] Arr04 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            Console.WriteLine("\nDo a case-insensitive sort of the words in an array");
            Console.WriteLine("==========");
            var Result17 = Arr04.OrderBy(W => W.ToLower());
            foreach (var item in Result17) Console.WriteLine(item);

            // 3. Sort a list of products by units in stock from highest to lowest.
            Console.WriteLine("\nList of products by units in stock from highest to lowest");
            Console.WriteLine("==========");
            var Result18 = ProductsList.OrderByDescending(P => P.UnitsInStock);
            foreach (var item in Result18) Console.WriteLine(item);

            // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr05 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine("\nSort a list of digits, first by length of their name, and then alphabetically by the name itself");
            Console.WriteLine("==========");
            var Result19 = Arr05.OrderBy(P => P.Length).ThenBy(P => P);
            foreach (var item in Result19) Console.WriteLine(item);


            // 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            string[] Arr06 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            Console.WriteLine("\nSort first by-word length and then by a case-insensitive sort of the words in an array");
            Console.WriteLine("==========");
            var Result20 = Arr06.OrderBy(P => P.Length).ThenBy(P => P.ToLower());
            foreach (var item in Result20) Console.WriteLine(item);


            // 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            Console.WriteLine("\nSort a list of products, first by category, and then by unit price, from highest to lowest");
            Console.WriteLine("==========");
            var Result21 = ProductsList.OrderByDescending(P => P.Category).ThenBy(P => P.UnitPrice);
            foreach (var item in Result21) Console.WriteLine(item);


            // 7. Sort first by-word length and then by a case -insensitive descending sort of the words in an array.
            string[] Arr07 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            Console.WriteLine("\nSort first by-word length and then by a case-insensitive descending sort of the words in an array");
            Console.WriteLine("==========");
            var Result22 = Arr06.OrderByDescending(P => P.Length).ThenBy(P => P.ToLower());
            foreach (var item in Result22) Console.WriteLine(item);

            // 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] Arr08 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Console.WriteLine("\nCreate a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array");
            Console.WriteLine("==========");
            var Result23 = Arr08.Where(P => P[1] == 'i').Reverse().ToList();
            foreach (var item in Result23) Console.WriteLine(item);

            #endregion

            #region LINQ – Transformation Operators

            // 1. Return a sequence of just the names of a list of products.
            Console.WriteLine("\nReturn a sequence of just the names of a list of products");
            Console.WriteLine("==========");
            var Result24 = ProductsList.Select(P => P.ProductName);
            foreach (var item in Result24) Console.WriteLine(item);

            // 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            Console.WriteLine("\nProduce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types)");
            Console.WriteLine("==========");
            var Result25 = words.Select(W => new { Uppercase = W.ToUpper(), Lowercase = W.ToLower() }).ToList();
            foreach (var item in Result25) Console.WriteLine(item);


            // 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            Console.WriteLine("\nProduce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type");
            Console.WriteLine("==========");
            var Result26 = ProductsList.Select(P => new { Name = P.ProductName, Price = P.UnitPrice });
            foreach (var item in Result26) Console.WriteLine(item);

            // 4. Determine if the value of int in an array match their position in the array.
            int[] Arr09 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine("\nDetermine if the value of int in an array match their position in the array");
            Console.WriteLine("==========");
            var Result27 = Arr09.Select((X, I) => new { Value = X + ":", Match = X == I });
            foreach (var item in Result27) Console.WriteLine(item);


            // 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            Console.WriteLine("\nReturns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.");
            Console.WriteLine("==========");

            var Result28 = from a in numbersA
                           from b in numbersB
                           where a < b
                           select new { a, b };

            foreach (var item in Result28) Console.WriteLine(item);

            // 6. Select all orders where the order total is less than 500.00.
            Console.WriteLine("\nSelect all orders where the order total is less than 500.00");
            Console.WriteLine("==========");
            var Result29 = CustomersList.SelectMany(C => C.Orders).Where(O => O.Total < 500);
            foreach (var item in Result29) Console.WriteLine(item);


            // 7. Select all orders where the order was made in 1998 or later.
            Console.WriteLine("\nSelect all orders where the order was made in 1998 or later");
            Console.WriteLine("==========");
            var Result30 = CustomersList.SelectMany(C => C.Orders).Where(O => O.OrderDate.Year >= 1998);
            foreach (var item in Result30) Console.WriteLine(item);
            #endregion

            #region LINQ - Set Operators
            // 1. Find the unique Category names from Product List
            Console.WriteLine("\nFind the unique Category names from Product List");
            Console.WriteLine("==========");
            var Result31 = ProductsList.Select(P => P.Category).Distinct();
            foreach (var item in Result31) Console.WriteLine(item);


            // 2. Produce a Sequence containing the unique first letter from both product and customer names.
            Console.WriteLine("\nProduce a Sequence containing the unique first letter from both product and customer names");
            Console.WriteLine("==========");
            var Result32 = ProductsList.Select(P => P.ProductName[0]).Concat(CustomersList.Select(C => C.CustomerName[0])).Distinct();
            foreach (var item in Result32) Console.Write($"{item} ");

            // 3. Create one sequence that contains the common first letter from both product and customer names.
            Console.WriteLine("\nCreate one sequence that contains the common first letter from both product and customer names");
            Console.WriteLine("==========");
            var Result33 = ProductsList.Select(P => P.ProductName[0]).Intersect(CustomersList.Select(C => C.CustomerName[0]));
            foreach (var item in Result33) Console.Write($"{item} ");

            // 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            Console.WriteLine("\nCreate one sequence that contains the first letters of product names that are not also first letters of customer names");
            Console.WriteLine("==========");
            var Result34 = ProductsList.Select(P => P.ProductName[0]).Except(CustomersList.Select(C => C.CustomerName[0]));
            foreach (var item in Result34) Console.Write($"{item} ");

            // 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            // 
            #endregion

            #region LINQ - Partitioning Operators
            // 1. Get the first 3 orders from customers in Washington
            Console.WriteLine("\nGet the first 3 orders from customers in Washington");
            Console.WriteLine("==========");
            var Result35 = CustomersList.Where(C => C.City == "Washington").SelectMany(C => C.Orders).Take(3);
            foreach (var item in Result35) Console.WriteLine(item);

            // 2. Get all but the first 2 orders from customers in Washington.
            Console.WriteLine("\nGet all but the first 2 orders from customers in Washington.");
            Console.WriteLine("==========");
            var Result36 = CustomersList.Where(C => C.City == "Washington").SelectMany(C => C.Orders).Skip(2);
            foreach (var item in Result36) Console.WriteLine(item);


            // 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] Numbers01 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            Console.WriteLine("\nReturn elements starting from the beginning of the array until a number is hit that is less than its position in the array");
            Console.WriteLine("==========");
            var Result37 = Numbers01.TakeWhile((num, index) => num >= index).ToList();
            foreach (var item in Result37) Console.Write($"{item} ");

            // 4. Get the elements of the array starting from the first element divisible by 3.
            int[] Numbers02 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine("\nGet the elements of the array starting from the first element divisible by 3");
            Console.WriteLine("==========");
            var Result38 = Numbers02.SkipWhile(N => N % 3 != 0);
            foreach (var item in Result38) Console.Write($"{item} ");

            // 5. Get the elements of the array starting from the first element less than its position.
            int[] Numbers03 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            Console.WriteLine("\nReturn elements starting from the beginning of the array until a number is hit that is less than its position in the array");
            Console.WriteLine("==========");
            var Result39 = Numbers03.SkipWhile((num, index) => num >= index).ToList();
            foreach (var item in Result39) Console.Write($"{item} ");
            #endregion

            #region LINQ - Quantifiers
            // 1. Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            // 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.



            // 3. Return a grouped a list of products only for categories that have all of their products in stock.

            #endregion

            #region LINQ – Grouping Operators

            // 1. Use group by to partition a list of numbers by their remainder when divided by 5
            Console.WriteLine("\nUse group by to partition a list of numbers by their remainder when divided by 5");
            Console.WriteLine("==========");            
            List<int> Numbers04 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var Result41 = Numbers04.GroupBy(N => N % 5).Select(G => new
            {
                Remainder = G.Key,
                Numbers = G.ToList()
            }).ToList();
            foreach (var item in Result41) Console.WriteLine(item);

            // 2. Uses group by to partition a list of words by their first letter.
            // Use dictionary_english.txt for Input

            // 3. Consider this Array as an Input
            string[] Arr10 = { "from", "salt", "earn", " last", "near", "form"};
            // Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            Console.WriteLine("\nUse Group By with a custom comparer that matches words that are consists of the same Characters Together");
            Console.WriteLine("==========");
            
            
            #endregion

        }
    }
}
