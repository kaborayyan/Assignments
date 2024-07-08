using System.ComponentModel;
using System.Data;

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
            Permission Admin = (Permission)6;
            Console.WriteLine(Admin);
            Admin = Admin ^ Permission.Delete;
            Console.WriteLine(Admin);
            #endregion

            #region Q04

            #endregion
        }
    }
}
