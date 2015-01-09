using System;

class Program
{
    static void Main()
    {
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        int position = 0;

        string bits = "";

        for (int i = 0; i < N; i++)
        {
            bits += Convert.ToString(uint.Parse(Console.ReadLine()), 2);
        }

        // Console.WriteLine(bits);
        if (K < 2)
        {
            if (bits[0] != bits[1])
            {
                sum++;
            }
            for (int i = 1; i < bits.Length - 1; i++)
            {
                if (bits[i] != bits[i + 1] && bits[i] != bits[i - 1])
                {
                    sum++;
                }
            }
            if (bits[bits.Length - 1] != bits[bits.Length - 2])
            {
                sum++;
            }
        }
        else
        {
            bool go = false;
            while (position <= bits.Length - K)
            {
                for (int i = position + 1; i < position + K; i++)
                {
                    if (bits[position] != bits[i])
                    {
                        position = i;
                        go = true;
                        break;
                    }
                }

                if (go)
                {
                    go = false;
                    continue;
                }

                if (position + K < bits.Length)
                {
                    if (bits[position] != bits[position + K])
                    {
                        sum++;
                        position += K;
                    }
                    else
                    {
                        position += K;
                        char tmp = bits[position];
                        while (bits[position] == tmp)
                        {
                            position++;
                        }
                    }
                }
                else
                {
                    sum++;
                    break;
                }
            }
        }
        Console.WriteLine(sum);
    }
}