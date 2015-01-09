using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Drunken_Numbers
{
    class DrunkenNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] drunkenNumbers = new string[n];
            StringBuilder currentDrunkenNumber;

            for (int i = 0; i < n; i++)
            {
                currentDrunkenNumber = new StringBuilder(Console.ReadLine());

                while (currentDrunkenNumber[0] == '0' || currentDrunkenNumber[0] == '-')
                {
                    currentDrunkenNumber.Remove(0, 1);
                    if (currentDrunkenNumber.Length == 0)
                    {
                        break;
                    }
                }

                drunkenNumbers[i] = currentDrunkenNumber.ToString();
            }

            int drunenSumMitko = 0;
            int drunkenSumVlado = 0;

            for (int i = 0; i < drunkenNumbers.Length; i++)
            {
                if (String.IsNullOrEmpty(drunkenNumbers[i]))
                {
                    continue;
                }
                if (drunkenNumbers[i].Length % 2 != 0)
                {
                    string newDrunkenNumber = drunkenNumbers[i].ToString();

                    int middleDigit = (newDrunkenNumber.Length / 2) + 1;

                    int tmp = 0;
                    for (int j = 0; j < middleDigit; j++)
                    {
                        tmp += newDrunkenNumber[j] - 48;
                    }

                    drunenSumMitko += tmp;

                    tmp = 0;
                    for (int k = middleDigit - 1; k < newDrunkenNumber.Length; k++)
                    {
                        tmp += newDrunkenNumber[k] - 48;
                    }


                    drunkenSumVlado += tmp;
                }
                else
                {
                    string newDrunkenNumber = drunkenNumbers[i].ToString();
                    int middleDigit = (newDrunkenNumber.Length / 2);
                    int tmp = 0;

                    for (int j = 0; j < middleDigit; j++)
                    {
                        tmp += newDrunkenNumber[j] - 48;
                    }

                    drunenSumMitko += tmp;

                    tmp = 0;
                    for (int k = middleDigit; k < newDrunkenNumber.Length; k++)
                    {
                        tmp += newDrunkenNumber[k] - 48;
                    }

                    drunkenSumVlado += tmp;
                }
            }

            if (drunenSumMitko > drunkenSumVlado)
            {
                Console.WriteLine("M {0}", drunenSumMitko - drunkenSumVlado);
            }
            else if (drunenSumMitko < drunkenSumVlado)
            {
                Console.WriteLine("V {0}", drunkenSumVlado - drunenSumMitko);
            }
            else
            {
                Console.WriteLine("No {0}", drunenSumMitko + drunkenSumVlado);
            }
        }
    }
}
