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

            #region Q06
            Employee[] EmpArray = new Employee[3];
            EmpArray[0] = new Employee(1, "Karim",1, 4000, 16, 12, 2017, Gender.Male);
            EmpArray[1] = new Employee(2, "Noha",4, 5000, 20, 11, 2020, Gender.Female);
            EmpArray[2] = new Employee(3, "Fayez",15, 6000, 12, 08, 2017, Gender.Male);
            #endregion
        }
    }
}
