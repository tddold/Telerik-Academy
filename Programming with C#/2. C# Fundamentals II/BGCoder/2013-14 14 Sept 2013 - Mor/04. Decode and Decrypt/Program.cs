using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Decode_and_Decrypt
{
    class Program
    {
        static void Main()
        {
            // ABBAA6BA7

            var input = Console.ReadLine();

            // get cypher
            var cypherLenght = GetCypher(input);

            // separate Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher
            var encodeMessage = EncodeMessage(input);


            // encrypt 
            var encryptMessage = new StringBuilder();
            var cypher = new StringBuilder();

            encryptMessage.AppendLine(encodeMessage.Substring(0, encodeMessage.Length - cypherLenght));
            cypher.AppendLine(encodeMessage.Substring((encodeMessage.Length - cypherLenght)));

            var result = Encrypt(encryptMessage.ToString(), cypher.ToString());

            Console.WriteLine(result);

        }

        private static string Encrypt(string message, string cypher)
        {
            message = message.Trim();
            cypher = cypher.Trim();

            var result = new StringBuilder(message);

            var maxLenght = Math.Max(message.Length, cypher.Length);


            for (int step = 0; step < maxLenght; step++)
            {
                var messagIndex = step % message.Length;
                var cypherIndex = step % cypher.Length;

                result[messagIndex] = 
                    (char) ((result[messagIndex] - 'A' ^ cypher[cypherIndex] - 'A') + 'A');
            }

            return result.ToString();

        }

        private static string EncodeMessage(string input)
        {
            var encodeMessage = new StringBuilder();
            var encodenumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    encodenumber *= 10;
                    encodenumber += input[i] - '0';
                }
                else
                {
                    if (encodenumber == 0)
                    {
                        encodeMessage.Append(input[i].ToString());
                    }
                    else
                    {
                        encodeMessage.Append(input[i], encodenumber);
                        encodenumber = 0;
                    }
                }
            }

            return encodeMessage.ToString();
        }

        private static int GetCypher(string input)
        {
            var numbers = new List<int>();
            int cypher = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(input[i] - '0');
                }
                else
                {
                    break;
                }
            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                cypher *= 10;
                cypher += numbers[i];
            }

            return cypher;
        }
    }
}
