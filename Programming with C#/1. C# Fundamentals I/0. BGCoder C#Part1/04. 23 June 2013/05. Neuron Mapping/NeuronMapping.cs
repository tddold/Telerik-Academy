using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Neuron_Mapping
{
    class NeuronMapping
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "-1")
            {
                uint inputNumber = uint.Parse(inputLine);
                char[] inputToBinariDigits = Convert.ToString(inputNumber, 2).PadLeft(32, '0').ToCharArray();

                bool isInsideNeuron = false;
                bool beenInNeuron = false;
                bool isOnBoundary = false;

                for (int i = 0; i < inputToBinariDigits.Length; i++)
                {
                    if (inputToBinariDigits[i] == '1')
                    {
                        inputToBinariDigits[i] = '0';
                        isOnBoundary = true;

                        if (isInsideNeuron)
                        {
                            inputToBinariDigits[i] = '0';
                            beenInNeuron = true;
                            isInsideNeuron = false;
                        }
                    }
                    else
                    {
                        if (!beenInNeuron && isOnBoundary)
                        {
                            isInsideNeuron = true;
                            isOnBoundary = false;

                        }
                        if (isInsideNeuron)
                        {
                            inputToBinariDigits[i] = '1';

                        }
                    }

                }

                if (!beenInNeuron)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    uint result = Convert.ToUInt32(new string(inputToBinariDigits), 2);
                    Console.WriteLine(result);
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
