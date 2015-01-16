using System;

class XExpression
{
    static void Main()
    {
        // input

        string expression = Console.ReadLine();

        long first = 0;
        int endBrackets = 0;
        string subExpression = String.Empty;

        int count = 0;
        while (count < expression.Length)
        {
            if (expression[count] == '=')
            {
                break;
            }

            if (expression[count] == '-' || expression[count] == '+' ||
                expression[count] == '/' || expression[count] == '*')
            {
                count++;
            }

            if (expression[count] == '(')
            {
                endBrackets = expression.IndexOf(')', count);
                count++;
                subExpression = expression.Substring(count, (endBrackets - count));
                first = GetOperation(count, first, expression, subExpression);
                count = endBrackets + 1;
            }
            else
            {
                int subCount = count;
                while (subCount < expression.Length)
                {
                    if (expression[subCount] == '(')
                    {
                        endBrackets = expression.IndexOf('(', count);
                        subExpression = expression.Substring(count, (endBrackets - 1));
                        first = GetOperation(count, first, expression, subExpression);
                        count = endBrackets;
                    }

                    subCount++;
                }

                endBrackets = expression.IndexOf('=', count);
                subExpression = expression.Substring(count, (endBrackets - 1));
                first = GetOperation(count, first, expression, subExpression);
                count = endBrackets;
               
            }

        }
    }

    private static long GetOperation(int count, long first, string expression, string subExpression)
    {
        switch (expression[count-2])
        {
            case '-':
                first -= CalcSubExpression(subExpression);
                break;
            case '+':
                first += CalcSubExpression(subExpression);
                break;
            case '*':
                first *= CalcSubExpression(subExpression);
                break;
            case '/':
                first /= CalcSubExpression(subExpression);
                break;
            default:
                throw new ArgumentException();
                break;
        }

        return first;
    }

    

    private static long CalcSubExpression(string subExpression)
    {
        long result = subExpression[0] - 48;

        for (int i = 1; i < subExpression.Length-1; i++)
        {
            switch (subExpression[i])
            {
                case '-':
                    i++;
                    result -= subExpression[i] - 48;
                    break;
                case '+':
                    i++;
                    result += subExpression[i] - 48;
                    break;
                case '*':
                    i++;
                    result *= subExpression[i] - 48;
                    break;
                case '/':
                    i++;
                    result /= subExpression[i] - 48;
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }
        }

        return result;
    }
}