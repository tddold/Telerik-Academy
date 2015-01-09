using System;

class Enigmanation
{
    public static long CalcSubExpression(string expression)
    {
        long first = expression[0] - 48;
        for (int i = 1; i < expression.Length; i++)
        {
            switch (expression[i])
            {
                case '-':
                i++;
                first -= (expression[i] - 48);
                break;
                case '+':
                i++;
                first += (expression[i] - 48);
                break;
                case '*':
                i++;
                first *= (expression[i] - 48);
                break;
                case '%':
                i++;
                first %= (expression[i] - 48);
                break;
                default:
                throw new ArgumentException();
                break;
            }
        }
        return first;
    }
    static void Main()
    {        
        string expression = Console.ReadLine();

        long first;
        int endBrackets = 0;
        if (expression[0] == '(')
        {
            endBrackets = expression.IndexOf(')', 0);
            string subExpression = expression.Substring(1, (endBrackets - 1));
            first = CalcSubExpression(subExpression);
        }
        else
        {
            first = expression[0] - 48;
        }

        for (int i = endBrackets + 1; i < expression.Length;i++)
        {
            if (expression[i] == '=')
            {
                break;
            }
            long second;
            int newIndex = i+1;
            if (expression[i+1] == '(')
            {
                newIndex = expression.IndexOf(')', i);
                string subExpression = expression.Substring(i +2,newIndex- i - 2);
                second = CalcSubExpression(subExpression);
            }
            else
            {
                second=expression[i+1] - 48;
            }
            switch (expression[i])
            {
                case '-':               
                first -= second;
                break;
                case '+':               
                first += second;
                break;
                case '*':
                first *= second;
                break;
                case '%':
                first %= second;
                break;
                default:
                throw new ArgumentException();
                break;
            }
            i = newIndex;
        }

        Console.WriteLine("{0:0.000}", first);
    }
}