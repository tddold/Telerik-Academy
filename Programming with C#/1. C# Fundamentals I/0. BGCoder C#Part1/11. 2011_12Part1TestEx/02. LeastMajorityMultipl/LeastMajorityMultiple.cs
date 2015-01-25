using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.LeastMajorityMultipl
{
    class LeastMajorityMultiple
    {
        const int secuensNumbers = 5;
        static void Main()
        {
            // http://bgcoder.com/Contests/Practice/Index/3#1

            //if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
            //{
            //    Console.SetIn(new StreamReader("input.txt"));
            //}

            // input
            List<int> arrayNumbers = new List<int>();            

            for (int i = 0; i < secuensNumbers; i++)
            {
                arrayNumbers.Add(int.Parse(Console.ReadLine()));
            }

            // logic
            int count = 1;
            
            bool isResult = false;
            int result = 0;
            while (true)
            {
                int countDivide = 0;
                for (int i = 0; i < arrayNumbers.Count; i++)
                {
                    if (count % arrayNumbers[i] == 0)
                    {
                        countDivide++;
                        if (countDivide == 3)
                        {
                            isResult = true;
                            result = count;
                            break;
                        }
                    }
                }

                count++;
                if (isResult)
                {
                    break;
                }
            }



            Console.WriteLine(result);
            //Console.Write(string.Join(",", arrayNumbers));
            //Console.WriteLine();
        }


    }
}
