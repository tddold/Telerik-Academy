using System;

class XExpression
{
    static void Main()
    {
        // input
        string expression = Console.ReadLine();

        double first;
        int endBracket = 0;

        if (expression[0] == '(')
        {
            endBracket = expression.IndexOf(')', 0);
            string subExpresion = expression.Substring(1, endBracket - 1);
            first = CalcSubExpression(subExpresion);
        }
        else
        {
            first = expression[0] - 48;
        }

        double second;
        int newIndex = 0;
        for (int i = endBracket + 1; i < expression.Length; i++)
        {
            newIndex = i + 1;
            if (expression[i] == '=')
            {
                break;
            }

            if (expression[newIndex] == '(')
            {
                endBracket = expression.IndexOf(')', i);
                string subExpresion = expression.Substring(i + 2, endBracket - i - 2);
                second = CalcSubExpression(subExpresion);
                newIndex = endBracket;
            }
            else
            {
                second = expression[newIndex] - 48;
            }

            first = GetOperatorBetweenFirstAndSecondAndCalc(expression, first, second, i);

            i = newIndex;
        }

        //print
        Console.WriteLine("{0:0.00}", first);
    }

    private static double GetOperatorBetweenFirstAndSecondAndCalc(string expression, double first, double second, int i)
    {
        switch (expression[i])
        {
            case '+':
                first += second;
                break;
            case '-':
                first -= second;
                break;
            case '*':
                first *= second;
                break;
            case '/':
                first /= second;
                break;
            default:
                throw new ArgumentException();
                break;
        }

        return first;
    }

    private static double CalcSubExpression(string subExpresion)
    {
        double first = subExpresion[0] - 48;
        for (int i = 1; i < subExpresion.Length; i++)
        {
            switch (subExpresion[i])
            {
                case '+':
                    i++;
                    first += subExpresion[i] - 48;
                    break;
                case '-':
                    i++;
                    first -= subExpresion[i] - 48;
                    break;
                case '/':
                    i++;
                    first /= subExpresion[i] - 48;
                    break;
                case '*':
                    i++;
                    first *= subExpresion[i] - 48;
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }
        }

        return first;
    }
}