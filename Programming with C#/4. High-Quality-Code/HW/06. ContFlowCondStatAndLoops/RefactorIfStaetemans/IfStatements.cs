namespace RefactorIfStaetemans
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IfStatements
    {
        private const int MinX = 0;
        private const int MaxX = 10;
        private const int MinY = 0;
        private const int MaxY = 10;

        public static void Main()
        {
            // Task1
            Patato patato = new Patato();

            // TODO 
            if (patato != null)
            {
                if (patato.IsPeeled && !patato.IsRotten)
                {
                    Cook(patato);
                }
            }
            else
            {
                throw new ArgumentNullException("Patato is not assigned!");
            }

            // Task2
            int x = 2;
            int y = 5;

            bool checkX = IsInRange(x, MinX, MaxX);
            bool checkY = IsInRange(y, MinY, MaxY);

            if (checkX && (checkY && IsVisitCell()))
            {
                VisitCell();
            }
        }

        /// <summary>
        /// Method for Task2.
        /// </summary>
        /// <param name="value">Value is checked if is range.</param>
        /// <param name="min">Start range.</param>
        /// <param name="max">End range.</param>
        /// <returns>Result the check.</returns>
        private static bool IsInRange(int value, int min, int max)
        {
            if (min <= value && value <= max)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Method for Task2.
        /// </summary>
        /// <returns>Result the check.</returns>
        private static bool IsVisitCell()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method for Task2.
        /// </summary>
        private static void VisitCell()
        {
            throw new NotImplementedException("TODO");
        }

        /// <summary>
        /// Method for Task1.
        /// </summary>
        /// <param name="potato">For cooking.</param>
        private static void Cook(Patato patato)
        {
            throw new NotImplementedException("TODO");
        }
    }
}
