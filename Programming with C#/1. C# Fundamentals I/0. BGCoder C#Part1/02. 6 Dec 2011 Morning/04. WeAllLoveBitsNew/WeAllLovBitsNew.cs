using System;
using System.Linq;
using System.Collections;
using System.Text;

class WeAllLovBitsNew
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());



        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            StringBuilder newStrNumber = new StringBuilder();
            string strNumber = Convert.ToString(number, 2);

            for (int j = strNumber.Length-1; j >= 0; j--)
            {
                newStrNumber.Append(strNumber[j]);
            }

            int result = 0;
            for (int k = 0; k < newStrNumber.Length; k++)
            {
                result += (int.Parse(newStrNumber[((newStrNumber.Length - 1) - k)].ToString()) * (int) Math.Pow(2, k));
            }

            Console.WriteLine(result);
        }


    }
}