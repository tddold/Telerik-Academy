namespace Point3D
{
    using System;
    using System.Collections.Generic;
    public class Path
    {
        // list to store all the points
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

        // with this method i add a new element to the list
        public void AddPoints(Point3D point)
        {
            this.points.Add(point);
        }
    }
}
