using System.ComponentModel;
using System.Data;
using static C42_G01_OOP01.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Drawing;

namespace C42_G01_OOP01
{
    internal class Program
    {
        public enum WeekDays : int
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        public enum Season : int
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        [Flags]
        public enum Permission : byte // to be able to use binary
        {
            Delete = 1,
            Write = 2,
            Read = 4,
            Execute = 8
        }

        public enum Color : int
        {
            Red,
            Green,
            Blue
        }
        static void Main(string[] args)
        {
            #region Q01
            // Create an enum called "WeekDays" with the days of the week (Monday to Sunday) 
            // as its members.Then, write a C# program that prints out all the days of the week
            // using this enum
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine((WeekDays)i);
            }
            #endregion

            #region Q02
            // Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter)
            // as its members.
            // Write a C# program that takes a season name as input from the user
            // and displays the corresponding month range for that season.
            // Note range for seasons (spring march to may , summer june to august,
            // autumn September to November, winter December to February)

            Console.WriteLine("Please eneter a season");
            Enum.TryParse<Season>(Console.ReadLine(), true, out Season UserInput);
            Console.WriteLine(UserInput.ToString());
            switch (UserInput)
            {
                case Season.Spring:
                    Console.WriteLine("March, April and May");
                    break;
                case Season.Summer:
                    Console.WriteLine("June, July and August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("September, October and November");
                    break;
                case Season.Winter:
                    Console.WriteLine("December, January and February");
                    break;
            }
            #endregion

            #region Q03
            // Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            // Create Variable from previous Enum to Add and Remove Permission
            // from variable, check if specific Permission is existed inside variable

            Permission Admin = (Permission)6;
            Console.WriteLine(Admin & Permission.Execute);
            Admin = Admin ^ Permission.Delete;
            Console.WriteLine(Admin);
            #endregion

            #region Q04
            // Create an enum called "Colors" with the basic colors (Red, Green, Blue) as
            // its members. Write a C# program that takes a color name as input from
            // the user and displays a message indicating whether the input color is a
            // primary color or not.

            Console.WriteLine("Please eneter a color");
            string UserText = Console.ReadLine();
            bool flag = Enum.TryParse<Color>(UserText, true, out Color UserColor);
            if (flag)
            {
                Console.WriteLine($"{UserColor} is a basic color.");
            }
            else
            {
                Console.WriteLine($"{UserText} is not a basic color.");
            }

            #endregion

            #region Q05
            // Create a struct called "Point" to represent a 2D point with properties "X"
            // and "Y". Write a C# program that takes two points as input from the user
            // and calculates the distance between them.
            Point UserPoint = new Point();
            Console.Write("Enter the first point: ");
            UserPoint.X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second point: ");
            UserPoint.Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UserPoint.CalculateDistance());
            #endregion
        }
    }
}
