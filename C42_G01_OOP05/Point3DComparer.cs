using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP05
{
    internal class Point3DComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Point3D? PointX = (Point3D?)x;
            Point3D? PointY = (Point3D?)y;
            
            return PointX?.DimY.CompareTo(PointY?.DimY) ?? (PointY is null ? 0 : -1);

        }
    }
}
