using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C42_G01_OOP02
{
    // Q02
    // Develop a Class to represent the Hiring Date Data:
    // consisting of fields to hold the day, month and Years.
    internal class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int D, int M, int Y)
        {
            Day = D;
            Month = M;
            Year = Y;
        }
    }
}
