using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;

namespace C42_G01_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01 & Q02
            // Define a struct "Person" with properties "Name" and "Age". Create an array
            // of three "Person" objects and populate it with data.Then, write a C# program to
            // display the details of all the persons in the array.

            // Create a struct called "Person" with properties "Name" and "Age". Write a C#
            // program that takes details of 3 persons as input from the user and displays the
            // name and age of the oldest person.

            Person Employee = new Person(3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the name of person No {i}: ");
                string Name = Console.ReadLine();
                Console.WriteLine($"Enter the age of person No {i}: ");
                int Age = Convert.ToInt32(Console.ReadLine());
                Employee.AddPerson(i,Name,Age);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Employee[i]);
            }

            Console.WriteLine(Employee.TheOldest());
            #endregion

            #region Q03

            #endregion
        }
    }
}
