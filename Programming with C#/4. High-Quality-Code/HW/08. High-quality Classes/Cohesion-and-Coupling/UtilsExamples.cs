namespace CohesionAndCoupling
{
    using System;

    internal class UtilsExamples
    {
        internal static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", DistanceUtils.CalcDistance2D(1, -2, 3, 4)); 
            Console.WriteLine("Distance in the 3D space = {0:f2}", DistanceUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Figure3D figure3D = new Figure3D(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", figure3D.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure3D.CalcDiagonalXyz());
            Console.WriteLine("Diagonal XY = {0:f2}", figure3D.CalcDiagonalXy());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure3D.CalcDiagonalXz());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure3D.CalcDiagonalYz());
        }
    }
}
