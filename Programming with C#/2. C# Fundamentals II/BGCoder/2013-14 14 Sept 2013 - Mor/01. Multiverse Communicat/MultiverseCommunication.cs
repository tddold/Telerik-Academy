using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Multiverse_Communicat
{
    class MultiverseCommunication
    {
        static int baseSystem = 13;
        static int GetNumber(string text)
        {
            switch (text)
            {
                case "CHU":
                    return 0;
                    break;
                case "TEL":
                    return 1;
                    break;
                case "OFT":
                    return 2;
                    break;
                case "IVA":
                    return 3;
                    break;
                case "EMY":
                    return 4;
                    break;
                case "VNB":
                    return 5;
                    break;
                case "POQ":
                    return 6;
                    break;
                case "ERI":
                    return 7;
                    break;
                case "CAD":
                    return 8;
                    break;
                case "K-A":
                    return 9;
                    break;
                case "IIA":
                    return 10;
                    break;
                case "YLO":
                    return 11;
                    break;
                case "PLA":
                    return 12;
                    break;

                default:
                    throw new ArgumentException();
                    break;
            }
        }

        static long GetPower(int power)
        {
            long result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= baseSystem;
            }

            return result;
        }

        static void Main()
        {
            string text = Console.ReadLine();

            int position = text.Length / 3 - 1;
            long result = 0;
            for (int i = 0; i < text.Length; i += 3)
            {
                string currDigits = text.Substring(i, 3);

                result += GetNumber(currDigits) * GetPower(position);
                position--;

            }
            Console
                .WriteLine(result);
        }
    }
}
