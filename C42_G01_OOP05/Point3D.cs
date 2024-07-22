using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP05
{
    internal class Point3D : IComparable, ICloneable
    {

        #region Q01
        // Define 3D Point Class and the basic Constructors
        // (use chaining in constructors).
        public int DimX { get; set; }
        public int DimY { get; set; }
        public double DimZ { get; set; }
        public Point3D(int dimX, int dimY, double dimZ)
        {
            DimX = dimX;
            DimY = dimY;
            DimZ = dimZ;
        }
        public Point3D(int dimX, int dimY) : this(dimX, dimY, 0)
        {
        }
        public Point3D(int dimX) : this(dimX, 0)
        {
        }

        
        #endregion

        #region Q02
        // Override the ToString Function to produce this output:
        // Point3D P = new Point3D(10, 10, 10);
        // Console.WriteLine(P.ToString( ));
        // Output: “Point Coordinates: (10, 10, 10)”.
        public override string ToString()
        {
            return $"Point Coordinates: ({DimX}, {DimY}, {DimZ})";
        }
        #endregion

        #region Q04
        // Relation Operator Overloading
        public static bool operator ==(Point3D Left, Point3D Right)
        {
            if (Left.DimX == Right.DimX && Left.DimY == Right.DimY)
            {
                return Left.DimZ == Right.DimZ;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Point3D Left, Point3D Right)
        {
            if (Left.DimX != Right.DimX && Left.DimY != Right.DimY)
            {
                return Left.DimZ != Right.DimZ;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Q05
        // Define an array of points and sort this array based on X & Y coordinates.
        public int CompareTo(object? obj)
        {
            Point3D PassedPoint = (Point3D)obj; // Totally unsafe
            if (this.DimX > PassedPoint.DimX)
            {
                return 1;
            }
            else if (this.DimX < PassedPoint.DimX)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        #endregion

        #region Q06
        // Implement ICloneable interface to be able to clone the object.
        public Point3D(Point3D newPoint)
        {
        }
        public object Clone()
        {
            return new Point3D(this);
        }
        #endregion

    }
}
