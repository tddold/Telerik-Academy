namespace RefactorExam_BitsToBits
{
    using System;
    using System.Text;

    public class BitsToBits
    {
        public static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int input = int.Parse(Console.ReadLine());

                string number = Convert.ToString(input, 2).PadLeft(30, '0');
                sb.Append(number);
            }

            int firstOneResult = 1;
            int secondOneResult = 1;
            int thirdOneResult = 1;
            int zeroResult = 0;

            CalculateResult(sb, ref firstOneResult, ref secondOneResult, ref thirdOneResult, ref zeroResult);

            PrintResult(length, firstOneResult, zeroResult);
        }

        private static void PrintResult(int length, int firstOneResult, int zeroResult)
        {
            if (length == 1)
            {
                Console.WriteLine(zeroResult);
            }
            else
            {
                Console.WriteLine(zeroResult);
                Console.WriteLine(firstOneResult);
            }
        }

        private static void CalculateResult(StringBuilder sb, ref int firstOneResult, ref int secondOneResult, ref int thirdOneResult, ref int zeroResult)
        {
            int currCountZero = 1;
            int currCountOne = 1;

            for (int j = 0; j < sb.Length - 1; j++)
            {
                if (sb[j] == '0')
                {
                    currCountOne = 1;

                    if (sb[j] == sb[j + 1])
                    {
                        currCountZero++;

                        if (zeroResult < currCountZero)
                        {
                            zeroResult = currCountZero;
                        }
                    }
                }
                else
                {
                    currCountZero = 1;

                    if (sb[j] == sb[j + 1])
                    {
                        currCountOne++;

                        if (firstOneResult < currCountOne)
                        {
                            firstOneResult = currCountOne;
                        }
                        else if (secondOneResult < currCountOne)
                        {
                            secondOneResult = currCountOne;
                        }
                        else if (thirdOneResult < currCountOne)
                        {
                            thirdOneResult = currCountOne;
                        }
                    }
                }
            }
        }
    }
}
