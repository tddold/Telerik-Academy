namespace Delegates
{
    using System;

    // these delegates will contain one method
    public delegate void SomeDelagete(int number);
    public delegate void SomeStringParamDelegate(string text);
    public delegate int ConvertStrings(string text);

    // this guy will have more methods
    public delegate int MulticastDelegate(int frs, int scd);

    public class DLG
    {
        public static void SomeMethod(int nmb)
        {
            Console.WriteLine(nmb);
        }

        public static void AnotherMethod(string text)
        {
            Console.WriteLine(text);
        }

        public static int Sum(int first, int second)
        {
            int result = first + second;
            Console.WriteLine(result);
            return result;
        }

        public static int Product(int first, int second)
        {
            int result = first * second;
            Console.WriteLine(result);
            return result;
        }

        public static int Remainder(int first, int second)
        {
            int result = first % second;
            Console.WriteLine(result);
            return result;
        }

        public static void Main()
        {
            SomeDelagete dlg = new SomeDelagete(SomeMethod);
            // dlg(10);

            // does not compile because of string parameter
            // dlg = new SomeDelagete(AnotherMethod);

            // dlg = new SomeDelagete(Console.WriteLine);
            var textDlg = new SomeStringParamDelegate(Console.WriteLine);

            // dlg(100);
            // textDlg("1000");

            ConvertStrings cnvrtDlg = new ConvertStrings(int.Parse);

            int someNumber = cnvrtDlg("100");
            // Console.WriteLine(someNumber);

            dlg = Console.WriteLine;

            MulticastDelegate multiFunctions = Sum;
            multiFunctions += Product;
            multiFunctions += Remainder;

            for (int i = 0; i < 50; i++)
            {
                multiFunctions += Sum;
                multiFunctions += Product;
                multiFunctions += Remainder;
            }

            multiFunctions -= Remainder;

            // int result = multiFunctions(10, 6);
            // Console.WriteLine("Delagete result: " + result);

            SomeStringParamDelegate annDlg = delegate(string text)
            {
                Console.WriteLine("Zdrasti " + text);
            };

            annDlg("Ivaylo!");
        }
    }
}
