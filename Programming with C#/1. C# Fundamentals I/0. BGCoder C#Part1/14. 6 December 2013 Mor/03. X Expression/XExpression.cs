using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.X_Expression
{
    class XExpression
    {
        static void Main()
        {
            //StreamReader reader = new StreamReader("..\\..\\input.txt");
            //Console.SetIn(reader);

            string expr = Console.ReadLine();

            double result = 0;
            double subResult = 0;            
            char operation = '+';
            char subOperation = '+';
            bool isSubExp = false;
            bool end = false;

            for (int i = 0; i < expr.Length; i++)
            {
                if (isSubExp)
                {
                    if (Char.IsDigit(expr[i]))
                    {
                        switch (subOperation)
                        {
                            case '+':
                                subResult += expr[i] - '0';
                                break;
                            case '-':
                                subResult -= expr[i] - '0';
                                break;
                            case '*':
                                subResult *= expr[i] - '0';
                                break;
                            case '/':
                                subResult /= expr[i] - '0';
                                break;
                        }
                    }
                    else if (expr[i] == ')')
                    {
                        switch (operation)
                        {
                            case '+':
                                result += subResult;
                                break;
                            case '-':
                                result -= subResult;
                                break;
                            case '*':
                                result *= subResult;
                                break;
                            case '/':
                                result /= subResult;
                                break;
                        }

                        subOperation = '+';
                        subResult = 0;
                        isSubExp = false;

                    }
                    else
                    {
                        subOperation = expr[i];
                    }
                }
                else
                {
                    if (Char.IsDigit(expr[i]) && i == 0)
                    {
                        result += expr[i] - '0';
                    }
                    else if (expr[i] == '(')
                    {
                        isSubExp = true;
                    }
                    else if (Char.IsDigit(expr[i]))
                    {
                        switch (operation)
                        {
                            case '+':
                                result += expr[i] - '0';
                                break;
                            case '-':
                                result -= expr[i] - '0';
                                break;
                            case '*':
                                result *= expr[i] - '0';
                                break;
                            case '/':
                                result /= expr[i] - '0';
                                break;
                            case '=':
                                end = true;
                                break;
                        }
                    }
                    else
                    {
                        operation = expr[i];
                    }
                }

                if (end)
                {
                    break;
                }
            }

            Console.WriteLine("{0:F2}", result);
        }        
    }
}
