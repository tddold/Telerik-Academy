namespace Point3D
{
    using System;

    public static class Distance
    {
        private static double distanceX;
        private static double distanceY;
        private static double distanceZ;
        private static double distance;

        public static double CalculateDistance(Point3D startPointe, Point3D endPoint)
        {
            distanceX = startPointe.X - endPoint.X;
            distanceY = startPointe.Y - endPoint.Y;
            distanceZ = startPointe.Z - endPoint.Z;
            distance = Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2) + Math.Pow(distanceZ, 2));

            return distance;
        }
    }
}
