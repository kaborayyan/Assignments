using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP05
{
    internal static class Maths
    {
        // Project02
        // Define Class Maths that has four methods:
        // Add, Subtract, Multiply, and Divide, each of them takes two parameters.
        // Call each method in Main(). Modify the program so that
        // you do not have to create an instance of class to call the four methods.

        public static double Add (double x, double y)
        {
            return x + y;
        }
        public static double Substract (double x, double y)
        {
            return x - y;
        }
        
        public static double Multiply (double x, double y)
        {
            return x * y;
        }
                
        public static double Divide (double x, double y)
        {
            return x + y;
        }
    }
}
