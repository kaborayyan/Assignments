using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP04
{
    internal class Rectangle : IRectangle
    {
        public int Base { get; set; }
        public int Height { get; set; }
        public decimal Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a Rectangle, its Base = {Base}, its Height = {Height} and its Area = {Area}");
        }
    }
}
