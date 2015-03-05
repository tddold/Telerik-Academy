namespace PHPVariables
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PHP
    {
        public static string ReadInput()
        {
            string currentLine = Console.ReadLine().Trim();

            StringBuilder phpCode = new StringBuilder();

            while (currentLine != "?>")
            {
                phpCode.AppendLine(currentLine);
                currentLine = Console.ReadLine().Trim();
            }

            return phpCode.ToString();
        }

        public static bool IsValidVariableSymbol(char symbol)
        {
            if (char.IsLetterOrDigit(symbol) || symbol == '_')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static HashSet<string> ExtractWords(string inputCode)
        {
            HashSet<string> allVariables = new HashSet<string>();

            bool inOneLineComment = false;
            bool inMultiLineComment = false;
            bool inSingleQuoteString = false;
            bool inDoubleQuoteString = false;
            bool inVariable = false;

            StringBuilder currentVariable = new StringBuilder();

            for (int i = 0; i < inputCode.Length; i++)
            {
                char currentSymbol = inputCode[i];

                // we are in one line comment
                if (inOneLineComment)
                {
                    if (currentSymbol == '\n')
                    {
                        // one line comment ends here
                        inOneLineComment = false;
                        continue;
                    }
                    else
                    {
                        // we are still in one line comment, move to next char
                        continue;
                    }
                }

                // we are in multi line comment
                if (inMultiLineComment)
                {
                    if (currentSymbol == '*' 
                        && i + 1 < inputCode.Length
                        && inputCode[i + 1] == '/')
                    {
                        inMultiLineComment = false;
                        i++; //next symbol is checked we do not need it
                        continue;
                    }
                    else
                    {
                        continue; // we are in comment so we dont care
                    }
                }

                //we are in variable
                if (inVariable)
                {
                    if (IsValidVariableSymbol(currentSymbol))
                    {
                        currentVariable.Append(currentSymbol);
                        continue;
                    }
                    else
                    {
                        if (currentVariable.Length > 0)
                        {
                            allVariables.Add(currentVariable.ToString());
                        }

                        currentVariable.Clear();
                        inVariable = false;
                    }
                }

                // we are in single quote string
                if (inSingleQuoteString)
                {
                    if (currentSymbol == '\'')
                    {
                        inSingleQuoteString = false;
                        continue;
                    }
                }

                // we are in double quote string 
                if (inDoubleQuoteString)
                {
                    if (currentSymbol == '"')
                    {
                        inDoubleQuoteString = false;
                        continue;
                    }
                }

                if (!inSingleQuoteString && !inDoubleQuoteString)
                {
                    // starting one line comment with #
                    if (currentSymbol == '#')
                    {
                        inOneLineComment = true;
                        continue;
                    }

                    // starting one line comment with //
                    if (currentSymbol == '/'
                        && i + 1 < inputCode.Length
                        && inputCode[i + 1] == '/')
                    {
                        inOneLineComment = true;
                        i++;
                        continue;
                    }

                    // starting multi line comment
                    if (currentSymbol == '/'
                        && i + 1 < inputCode.Length
                        && inputCode[i + 1] == '*')
                    {
                        inMultiLineComment = true;
                        i++;
                        continue;
                    }
                }
                else
                {
                    // we are in string and next symbol must be escaped
                    if (currentSymbol == '\\')
                    {
                        i++;
                        continue;
                    }
                }

                // we are starting single quote string
                if (currentSymbol == '\'')
                {
                    inSingleQuoteString = true;
                    continue;
                }

                // we are starting double quote string
                if (currentSymbol == '\"')
                {
                    inDoubleQuoteString = true;
                    continue;
                }

                // if we reached here - we may be in variable
                if (currentSymbol == '$')
                {
                    inVariable = true;
                    continue;
                }
            }

            return allVariables;
        }

        public static void PrintResult(HashSet<string> result)
        {
            Console.WriteLine(result.Count);

            foreach (var variable in result)
            {
                Console.WriteLine(variable);
            }
        }

        public static void Main()
        {
            string inputCode = ReadInput();
            var result = ExtractWords(inputCode);
            PrintResult(result);
        }
    }
}
