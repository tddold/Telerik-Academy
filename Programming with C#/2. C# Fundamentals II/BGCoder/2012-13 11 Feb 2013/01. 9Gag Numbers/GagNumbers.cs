using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._9Gag_Numbers
{
    class GagNumbers
    {
        static void Main()
        {
            string input = "***!!!"; // Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            ulong result = 0;
            ulong pow = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
                sb.ToString().st

                switch (sb.ToString())
                {
                    case "-!":
                        result += (ulong)Math.Pow(0, pow);pow++;
                        sb.Clear();
                        break;
                    case "**":
                        result += (ulong)Math.Pow(1, pow);pow++;
                        sb.Clear();
                        break;
                    case "!!!":
                        result += (ulong)Math.Pow(2, pow);pow++;
                        sb.Clear();
                        break;
                    case "&&":
                        result += (ulong)Math.Pow(3, pow);pow++;
                        sb.Clear();
                        break;
                    case "&-":
                        result += (ulong)Math.Pow(4, pow);pow++;
                        sb.Clear();
                        break;
                    case "!-":
                        result += (ulong)Math.Pow(5, pow);pow++;
                        sb.Clear();
                        break;
                    case "*!!!":
                        result += (ulong)Math.Pow(6, pow);pow++;
                        sb.Clear();
                        break;
                    case "&*!":
                        result += (ulong)Math.Pow(7, pow);pow++;
                        sb.Clear();
                        break;
                    case "!!**!-":
                        result += (ulong)Math.Pow(8, pow);pow++;
                        sb.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
