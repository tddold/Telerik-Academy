namespace Point3D
{
    using System;

    public static class Distance
    {
        private static double xDistance;
        private static double yDistance;
        private static double zDistance;
        private static double distance;


        public static double CalculateDistance(Point3D startPointe, Point3D endPoint)
        {
            xDistance = startPointe.X - endPoint.X;
            yDistance = startPointe.Y - endPoint.Y;
            zDistance = startPointe.Z - endPoint.Z;
            distance = Math.Sqrt((Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2)));

            return distance;
        }
    }
}
