using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02__Miss_Cat_2011
{
    class MissCat2011
    {
        static void Main()
        {
            //if (Environment.CurrentDirectory.ToLower().EndsWith("bin\\debug"))
            //{
            //    Console.SetIn(new StreamReader("input.txt"));
            //}

            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            StringBuilder result = new StringBuilder();
            bool[] isChecked = new bool[n];
            int lastCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (!isChecked[i])
                {
                    int count = 1;
                    isChecked[i] = true;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[i] == array[j])
                        {
                            isChecked[j] = true;
                            count++;
                        }
                    }

                    if (result.Length == 0)
                    {
                        result.Append(array[i].ToString());
                        lastCount = count;
                    }
                    else if (lastCount == count)
                    {

                        if (int.Parse(result[0].ToString()) > array[i])
                        {
                            result.Remove(0, 1);
                            result.Append(array[i].ToString());
                        }

                    }
                    else if (lastCount < count)
                    {
                        lastCount = count;
                        result.Remove(0, 1);
                        result.Append(array[i].ToString());
                    }
                }
            }

            Console.WriteLine(result);
            ////Console.WriteLine(string.Join(",", array));
        }
    }
}
