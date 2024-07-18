using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP04
{
    internal interface ICircle : IShape
    {
        public int Radius { get; set; }
    }
}
