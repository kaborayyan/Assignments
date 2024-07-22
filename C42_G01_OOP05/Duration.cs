using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP05
{
    internal class Duration
    {

        // Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int X)
        {
            Hours = X / 3600;
            Minutes = (X % 3600) / 60;
            Seconds = (X % 3600) % 60;
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }
    }
}
