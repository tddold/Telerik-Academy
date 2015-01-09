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
            const int uintSizeInBits = sizeof(uint) * 8;
            string inputLine = Console.ReadLine();

            while (inputLine != "-1")
            {
                uint inputNumber = uint.Parse(inputLine);


                bool isInsideNeuron = false;
                bool beenInNeuron = false;
                bool isOnBoundary = false;


                for (int i = 0; i < uintSizeInBits; i++)
                {
                    uint mask = 1U << i;
                    if ((inputNumber & mask) != 0)
                    {
                        inputNumber &= (~mask);
                        isOnBoundary = true;

                        if (isInsideNeuron)
                        {
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
                            inputNumber |= mask;

                        }
                    }

                }

                if (!beenInNeuron)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(inputNumber);
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
