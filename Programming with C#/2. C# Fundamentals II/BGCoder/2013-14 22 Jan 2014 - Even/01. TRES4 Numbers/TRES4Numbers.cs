using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TRES4_Numbers
{
    class TRES4Numbers
    {
        static ulong baseSystem = 9;


        static string GetNumbers(int digits)
        {
            string result = "NO";
            switch (digits)
            {
                case 0:
                    return "LON+";
                    break;
                case 1:
                    return "VK-";
                    break;
                case 2:
                    return "*ACAD";
                    break;
                case 3:
                    return "^MIM";
                    break;
                case 4:
                    return "ERIK|";
                    break;
                case 5:
                    return "SEY&";
                    break;
                case 6:
                    return "EMY>>";
                    break;
                case 7:
                    return "/TEL";
                    break;
                case 8:
                    return "<<DON";
                    break;
            }
            return result;
        }


        static void Main()
        {
            ulong input = ulong.Parse(Console.ReadLine());

            string[] numbersNineSystem = {"LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON"};

            StringBuilder result = new StringBuilder();

            double currNumber = 0;

            if (input == 0)
            {
                result.Append("LON+");
            }
            else
            {
                while (input > 0)
                {
                    int digits = (int)(input % baseSystem);
                    result.Insert(0, numbersNineSystem[digits]);
                    input /= baseSystem;
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
