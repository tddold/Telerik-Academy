namespace Methods
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            int sideA = 3;
            int sideB = 4;
            int sideC = 5;
            var triangleAria = CalcTriangleArea(sideA, sideB, sideC);
            Console.WriteLine(triangleAria);

            int testNumber = 5;
            var word = DigitAsWord(testNumber);
            Console.WriteLine(word);

            int[] array = new int[] { 5, -1, 3, 2, 14, 2, 3 };
            var maxNumberInArray = FindMax(array);
            Console.WriteLine(maxNumberInArray);

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Point startPoint = new Point(3, -1);
            Point endPoint = new Point(3, 2.5);
            bool vertical = IsHorizontal(startPoint.X, endPoint.X);
            bool horizontal = IsHorizontal(startPoint.Y, endPoint.Y);
            var distance = CalcDistan(startPoint, endPoint);
            Console.WriteLine(distance);
            Console.WriteLine("Horizontal? " + vertical);
            Console.WriteLine("Vertical? " + horizontal);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }

        private static object CalcDistan(Point startPoint, Point endPoint)
        {
            double firsValue = (endPoint.X - startPoint.X) * (endPoint.X - startPoint.X);
            double secondValue = (endPoint.Y - startPoint.Y) * (endPoint.Y - startPoint.Y);
            double distance = Math.Sqrt(firsValue + secondValue);
            return distance;
        }

        private static bool IsHorizontal(double start, double end)
        {
            if (start == end)
            {
                return true;
            }

            return false;
        }

        private static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            if (sideA + sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
            {
                throw new ArgumentException("Input parameter is incorect.");
            }

            double semiperimeter = (sideA + sideB + sideC) / 2;
            double semiperimeterAndSidesFormula = semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC);
            double area = Math.Sqrt(semiperimeterAndSidesFormula);
            return area;
        }

        private static string DigitAsWord(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return "Invalid number!";
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Elements not be null and must be an array!");
            }

            int maxNumber = int.MinValue;
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxNumber)
                {
                    maxNumber = elements[i];
                }
            }

            return maxNumber;
        }

        private static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }
    }
}
