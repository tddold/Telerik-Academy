namespace LambdaExpressions
{
    using System;

    public class Program
    {
        public static string Convert(int x)
        {
            return x.ToString();
        }

        public static string SumOfInts(int x, int y)
        {
            return (x + y).ToString();
        }

        public  static void Main()
        {
            Func<int, string> lambda = number => number.ToString();

            Func<string, int> convert = text => int.Parse(text);

            Func<int, int, string> lamdaSumOfStrings = (x, y) =>
                {
                    var result = (x * y).ToString();
                    x = 10;
                    return result;
                };

            string resultFromDelegate = lambda(10);

            Action<int, int> voidDelegate = (x, y) => 
                {
                    int sum = x + y;
                    Console.WriteLine(sum);
                };

            voidDelegate(10, 50);

            Action someActionShort = () =>  Console.WriteLine(100);

            Action someAction = () =>
                {
                    Console.WriteLine(100);
                };

            Func<string> returnPesho = () => "Pesho";

            Console.WriteLine(returnPesho());
        }
    }
}
