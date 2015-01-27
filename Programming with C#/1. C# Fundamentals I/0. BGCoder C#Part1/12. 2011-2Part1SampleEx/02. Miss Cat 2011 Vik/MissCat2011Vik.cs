using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Miss_Cat_2011_Vik
{
    class MissCat2011Vik
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[11];

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                array[numbers]++;
            }
                        
            int maxNumber = int.MinValue;
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNumber < array[i])
                {
                    maxNumber = array[i];
                    index = i;
                }
            }
          
            Console.WriteLine(index);
        }
    }
}
