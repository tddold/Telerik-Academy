using System;

class ANacci
{
    const int shift = 64;
    static void Main()
    {
        string firstMember = Console.ReadLine();
        int first = firstMember[0] - shift;

        string secondMember = Console.ReadLine();
        int second = secondMember[0] - shift;

        int roswsNumber = int.Parse(Console.ReadLine());

        Console.WriteLine((char) (first + shift));


        if (roswsNumber > 1)
        {
            int next = first + second;


            if (next > 26)
            {
                next %= 26;
            }
            string result = ((char) (second + shift)).ToString()
                          + ((char) (next + shift)).ToString();

            Console.WriteLine(result);
            first = second;
            second = next;

            for (int i = 3; i <= roswsNumber; i++)
            {
                next = first + second;

                if (next > 26)
                {
                    next %= 26;
                }
                first = second;
                second = next;
                next = first + second;

                if (next > 26)
                {
                    next %= 26;
                }
                first = second;
                second = next;
                Console.Write((char) (first + shift));
                Console.Write(new string(' ', i - 2));
                Console.WriteLine((char) (second + shift));
            }
        }

    }
}