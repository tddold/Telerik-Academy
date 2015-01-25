using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Astrological_Digits_II
{
    class AstrologicalDigitsII
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            input = input.Replace("-", "");
            input = input.Replace(".", "");

            int result = 0;
            while (true)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    result += int.Parse(input[i].ToString());
                }

                if (result<= 9)
                {
                    break;
                }
                else
                {
                    input = result.ToString();
                    result = 0;
                }
            }
           
            
            Console.WriteLine(result);
        }
    }
}
