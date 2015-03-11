namespace Point3D
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text;
	public static class PathStorage
	{

		public static void SavePath(List<Point3D> points)
		{
			string saveFilePath = "..\\..\\output.txt";           

			StreamWriter writer = new StreamWriter(saveFilePath);
			using (writer)
			{
				for (int i = 0; i < points.Count; i++)
				{
					writer.Write(string.Format("point {0} --> ", i));
					writer.WriteLine(string.Format("x = {0}, y = {1}, z = {2}", points[i].X, points[i].Y, points[i].Z));
				}

			}
		}

		public static Path LoadFromFile(string fileName)
		{
			string loadFilePath = string.Format( "..\\..\\{0}.txt", fileName.Trim());
			StreamReader reader = new StreamReader(loadFilePath);
			StringBuilder points = new StringBuilder();
			Path path = new Path();

			try
			{	
				using (reader)
				{
					points.Append(reader.ReadToEnd());
				}

				//foreach (var point in points)
				//{
				//    path.AddPoints(double.Parse(point.ToString()));
				//}
			}
			catch (FileNotFoundException)
			{
				
				Console.WriteLine("The file whit file name {0} is not found!", fileName);
				return null;
			}


			return points.ToString();
		}
	}
}
