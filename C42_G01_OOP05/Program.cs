namespace C42_G01_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q01 inside Class Point3D
            // Q02 inside Class Point3D
            Point3D P01 = new Point3D(10, 10, 10);
            Console.WriteLine(P01);

            #region Q03
            // Read from the User the Coordinates for 2 points P1, P2
            // (Check the input using try Pares, Parse, Convert).
            
            Console.WriteLine("Please enter three new points:");
            int X = Convert.ToInt32(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out int Y);
            int Z = int.Parse(Console.ReadLine());

            Point3D P02 = new Point3D(X, Y, Z);
            Console.WriteLine(P02);
            #endregion

            #region Q04
            if (P01 == P02)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They're not equal");
            }
            #endregion

            Point3D P03 = new Point3D(20,20,20);

            #region Q05
            // Define an array of points and sort this array based on X & Y coordinates.

            Point3D[] ArrayOfPoints = { P01, P02, P03 };

            Array.Sort(ArrayOfPoints, new Point3DComparer());
            for (int i = 0; i < ArrayOfPoints.Length; i++)
            {
                Console.WriteLine(ArrayOfPoints[i]);
            }
            #endregion

            #region Project02
            Console.WriteLine(Maths.Add(5.0,3.0));
            #endregion

            #region Project03
            Duration D01 = new Duration(666);
            Console.WriteLine(D01);
            #endregion
        }
    }
}
