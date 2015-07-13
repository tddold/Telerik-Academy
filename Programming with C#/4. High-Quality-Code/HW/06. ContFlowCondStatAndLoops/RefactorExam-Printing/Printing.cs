namespace RefactorExam_Printing
{
    using System;

    public class Printing
    {
        public static void Main()
        {
            decimal numberOfStudents = decimal.Parse(Console.ReadLine());
            decimal numberOfPaperSheetsThatBePrinted = decimal.Parse(Console.ReadLine());
            decimal priceOneBox = decimal.Parse(Console.ReadLine());

            decimal numberOfPaperSheetsInBox = 500;

            decimal allBoxNeeded = (numberOfStudents * numberOfPaperSheetsThatBePrinted) / numberOfPaperSheetsInBox;

            decimal result = allBoxNeeded * priceOneBox;

            Console.WriteLine("{0:F2}", result);
        }
    }
}