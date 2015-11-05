namespace JediMeditation
{
    using System;
    using System.Collections.Generic;

    public class Solve
    {
        private static void Main()
        {
            var numberOfJedi = int.Parse(Console.ReadLine());

            string[] allJedi = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var jediMaster = new Queue<string>();
            var jediKnight = new Queue<string>();
            var padawan = new Queue<string>();

            if (allJedi.Length != numberOfJedi)
            {
                throw new Exception("Wrong input.");
            }

            for (int i = 0; i < allJedi.Length; i++)
            {
                switch (allJedi[i][0])
                {
                    case 'm':
                        jediMaster.Enqueue(allJedi[i]);
                        break;
                    case 'k':
                        jediKnight.Enqueue(allJedi[i]);
                        break;
                    case 'p':
                        padawan.Enqueue(allJedi[i]);
                        break;
                    default:
                        throw new Exception("Wrong input.");
                }
            }

            var result = string.Format("{0} {1} {2}", string.Join(" ", jediMaster), string.Join(" ", jediKnight), string.Join(" ", padawan));
            Console.WriteLine(result);
        }
    }
}
