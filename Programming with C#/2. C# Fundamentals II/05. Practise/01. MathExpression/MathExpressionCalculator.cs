namespace _01.MathExpression
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;

    public class MathExpressionCalculator
    {
        public static List<char> aretmeticOperations = new List<char>() { '+', '-', '*', '/' };
        public static List<char> brackets = new List<char>() { '(', ')' };
        public static List<string> functions = new List<string>() { "pow", "ln", "sqrt" };

        public static string TrimInput(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    sb.Append(input[i]);
                }
            }

            return sb.ToString();
        }

        public static List<string> SeparateTokens(string input)
        {
            var result = new List<string>();
            var number = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '-' && (input[i] == 0 || input[i - 1] == ',' || input[i - 1] == '('))
                {
                    number.Append('-');
                }
                else if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    number.Append(input[i]);
                }
                else if (!char.IsDigit(input[i]) && input[i] != '.' && number.Length != 0)
                {
                    result.Add(number.ToString());
                    number.Clear();
                    i--;
                }
                else if (brackets.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (aretmeticOperations.Contains(input[i]))
                {
                    result.Add(input[i].ToString());
                }
                else if (input[i] == ',')
                {
                    result.Add(",");
                }
                else if (i + 1 < input.Length && input.Substring(i, 2).ToLower() == "ln")
                {
                    result.Add("ln");
                    i++;
                }
                else if (i + 2 < input.Length && input.Substring(i, 3).ToLower() == "pow")
                {
                    result.Add("pow");
                    i += 2;
                }
                else if (i + 3 < input.Length && input.Substring(i, 4).ToLower() == "sqrt")
                {
                    result.Add("sqrt");
                    i += 3;
                }
                else
                {
                    throw new ArgumentException("Invalid expression");
                }
            }

            if (number.Length != 0)
            {
                result.Add(number.ToString());
            }

            return result;
        }

        public static int Precedence(string aritmeticOperator)
        {
            if (aritmeticOperator == "+" || aritmeticOperator == "-")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public static Queue<string> ConvertToReverrsePolishNotation(List<string> tokens)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < tokens.Count; i++)
            {
                var currentToken = tokens[i];
                double number;

                if (double.TryParse(currentToken, out number))
                {
                    queue.Enqueue(currentToken);
                }
                else if (functions.Contains(currentToken))
                {
                    stack.Push(currentToken);
                }
                else if (currentToken == ",")
                {
                    if (!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid bracket or function separator");
                    }

                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
                else if (aretmeticOperations.Contains(currentToken[0]))
                {
                    while (stack.Count != 0 && aretmeticOperations.Contains(stack.Peek()[0]) && Precedence(currentToken) <= Precedence(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Push(currentToken);
                }
                else if (currentToken == "(")
                {
                    stack.Push("(");
                }
                else if (currentToken == ")")
                {
                    if (!stack.Contains("(") || stack.Count == 0)
                    {
                        throw new ArgumentException("Invalid bracketts position");
                    }

                    while (stack.Peek() != "(")
                    {
                        queue.Enqueue(stack.Pop());
                    }

                    stack.Pop();

                    if (stack.Count != 0 && functions.Contains(stack.Peek()))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                }
            }

            while (stack.Count != 0)
            {
                if (brackets.Contains(stack.Peek()[0]))
                {
                    throw new ArgumentException("Invalid brackets position");
                }

                queue.Enqueue(stack.Pop());
            }

            return queue;
        }

        public static void PutInvarianCulture()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        public static double GetResultFromRPN(Queue<string> queue)
        {
            Stack<double> stack = new Stack<double>();

            while (queue.Count != 0)
            {
                string currentTocken = queue.Dequeue();
                double number;

                if (double.TryParse(currentTocken, out number))
                {
                    stack.Push(number);
                }
                else if (aretmeticOperations.Contains(currentTocken[0]) || functions.Contains(currentTocken))
                {
                    if (currentTocken == "+")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(firstValue + secondValue);
                    }
                    else if (currentTocken == "-")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue - firstValue);
                    }
                    else if (currentTocken == "*")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue * firstValue);
                    }
                    else if (currentTocken == "/")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(secondValue / firstValue);
                    }
                    else if (currentTocken == "pow")
                    {
                        if (stack.Count < 2)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double firstValue = stack.Pop();
                        double secondValue = stack.Pop();

                        stack.Push(Math.Pow(secondValue, firstValue));
                    }
                    else if (currentTocken == "sqrt")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double value = stack.Pop();


                        stack.Push(Math.Sqrt(value));
                    }
                    else if (currentTocken == "ln")
                    {
                        if (stack.Count < 1)
                        {
                            throw new ArgumentException("Invalid expression");
                        }

                        double value = stack.Pop();


                        stack.Push(Math.Log(value));
                    }
                }
            }

            if (stack.Count != 0)
            {
                return stack.Pop();
            }
            else
            {
                throw new ArgumentException("Invalid expression");
            }
        }

        public static void StartCalculating()
        {
            string input = Console.ReadLine().Trim();

            while (input.ToLower() != "end")
            {
                try
                {
                    string trimInput = input.Replace(" ", string.Empty);
                    var separatedTokens = SeparateTokens(trimInput);
                    var reversePolishNotation = ConvertToReverrsePolishNotation(separatedTokens);
                    var finalResult = GetResultFromRPN(reversePolishNotation);
                    Console.WriteLine(finalResult);
                }
                catch (ArgumentException exeption)
                {
                    Console.WriteLine(exeption.Message);
                }

                input = Console.ReadLine().Trim();
            }
        }

        public static void Main()
        {
            PutInvarianCulture();
            StartCalculating();
        }
    }
}
