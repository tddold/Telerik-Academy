using System;

class MathExpression
{
    const double constOne = 1337;
    const double constTwo = 128.523123123;
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        double squareN = N * N;
        double expressionOneMP = 1 / (M * P);
        double expConstTwoP = constTwo * P;
        int X = (int)(M % 180);

        double result = (squareN + expressionOneMP + constOne) / (N - expConstTwoP) + Math.Sin(X);

        Console.WriteLine("{0:F6}", result);
    }
}