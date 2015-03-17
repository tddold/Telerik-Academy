namespace FuncAndAction
{
    using System;
    using System.Linq.Expressions;

    public class FandA
    {
        public static void Execute<T>(Action<T> action, T parameter)
        {
            action(parameter);
        }

        public static void SomeIntegerOperation(int number)
        {
            Console.WriteLine(number + 10);
        }

        public static void SomeHeavyMethod(int first, string second, double third)
        {
            Console.WriteLine(first + " " + second + " " + third);
        }

        public static string SumToString(int first, int second)
        {
            return (first + second).ToString();
        }

        public static void Main()
        {
            Action<int> printNumber = Console.WriteLine;

            // printNumber(100);
            int number = 5;

            Execute(Console.WriteLine, number);
            Execute(SomeIntegerOperation, number);

            Action<int, string, double> someHeavyAction;

            someHeavyAction = SomeHeavyMethod;
            someHeavyAction(100, "pesho", 5.6);

            Func<int, int, string> someFunc = SumToString;
            string result = someFunc(10, 20);

            Console.WriteLine(result);
        }
    }
}
