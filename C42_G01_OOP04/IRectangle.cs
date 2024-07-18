using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP04
{
    internal interface IRectangle: IShape
    {
        public int Base {  get; set; }
        public int Height { get; set; }
    }
}
