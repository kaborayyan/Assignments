using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP04
{
    internal class Circle : ICircle
    {
        public int Radius { get; set; }
        public decimal Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a Circle, its Radius = {Radius} and its Area = {Area}");
        }
    }
}
