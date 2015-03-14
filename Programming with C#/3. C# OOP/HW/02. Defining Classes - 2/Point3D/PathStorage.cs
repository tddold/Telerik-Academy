namespace Point3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class PathStorage
    {
        public static void SavePath(Path point, string fileName)
        {
            string saveFilePath = string.Format("..\\..\\{0}.txt", fileName.Trim());

            // defining a streamwriter class and making a new file
            StreamWriter writer = new StreamWriter(saveFilePath);

            using (writer)
            {
                writer.Write(point);
            }
        }

        public static Path LoadFromFile(string fileName)
        {
            string loadFilePath = string.Format("..\\..\\{0}.txt", fileName.Trim());

            Path path = new Path();

            // defining a streamreader class to reade a file
            StreamReader reader = new StreamReader(loadFilePath);

            try
            {
                using (reader)
                {
                    string[] allPoints = reader.ReadToEnd()
                        .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var point in allPoints)
                    {
                        double[] coordinates = point.Trim('{').Trim('}')
                            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => double.Parse(x))
                            .ToArray();
                        path.AddPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file whit file name {0} is not found!", fileName);
                return null;
            }

            return path;
        }
    }
}
