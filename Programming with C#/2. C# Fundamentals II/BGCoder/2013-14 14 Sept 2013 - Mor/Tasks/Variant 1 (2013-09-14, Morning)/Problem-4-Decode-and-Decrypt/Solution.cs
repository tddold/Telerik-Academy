using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDecrypt
{
    class Program
    {
        const char BaseLetter = 'A';

        static void Main(string[] args)
        {
            string encodedCypherText = Console.ReadLine();

            int cypherLength = GetMessageCypherLength(encodedCypherText);
            int cypherLengthNumberSubstringLength = cypherLength.ToString().Length;

            string encodedCypherTextAndCypher = encodedCypherText.Substring(0, encodedCypherText.Length - cypherLengthNumberSubstringLength);

            string cypherTextAndCypher = Decode(encodedCypherTextAndCypher);

            string cypher = cypherTextAndCypher.Substring(cypherTextAndCypher.Length - cypherLength);
            string cypherText = cypherTextAndCypher.Substring(0, cypherTextAndCypher.Length - cypherLength);

            string message = Decrypt(cypherText, cypher);

            Console.WriteLine(message);
        }

        static int GetMessageCypherLength(string encodedCypherText)
        {
            int lengthSubstringStartIndex = -1;
            for (int index = encodedCypherText.Length - 1; index > 0; index--)
            {
                char currentSymbol = encodedCypherText[index];
                if (!Char.IsDigit(currentSymbol))
                {
                    lengthSubstringStartIndex = index + 1;
                    break;
                }
            }

            string lengthSubstring = encodedCypherText.Substring(lengthSubstringStartIndex);
            int cypherLength = int.Parse(lengthSubstring);

            return cypherLength;
        }

        static string Decode(string encodedText)
        {
            StringBuilder decodedTextBuilder = new StringBuilder();

            int index = 0;
            int currentNumber = 0;
            while (index < encodedText.Length)
            {
                if (Char.IsDigit(encodedText[index]))
                {
                    currentNumber = encodedText[index] - '0' + (currentNumber * 10);
                }
                else
                {
                    char currentSymbol = encodedText[index];
                    if (currentNumber > 0)
                    {
                        decodedTextBuilder.Append(new string(currentSymbol, currentNumber));
                        currentNumber = 0;
                    }
                    else
                    {
                        decodedTextBuilder.Append(currentSymbol);
                    }
                }

                index++;
            }

            return decodedTextBuilder.ToString();
        }

        static string Decrypt(string cypherText, string cypher)
        {
            StringBuilder messageBuilder = new StringBuilder(cypherText);

            int longer = Math.Max(cypherText.Length, cypher.Length);

            for (int index = 0; index < longer; index++)
            {
                int indexInCypherText = index % cypherText.Length;
                int indexInCypher = index % cypher.Length;

                int charInCypherTextOffset = messageBuilder[indexInCypherText] - BaseLetter;
                int charInCypherOffset = cypher[indexInCypher] - BaseLetter;

                messageBuilder[indexInCypherText] = (char)(BaseLetter + (charInCypherTextOffset ^ charInCypherOffset));
            }

            return messageBuilder.ToString();
        }
    }
}
