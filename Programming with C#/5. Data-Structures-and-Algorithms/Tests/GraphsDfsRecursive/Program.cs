namespace GraphsDfsRecursive
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Node
    {
        public int Vertex { get; set; }

        public int Level { get; set; }
    }

    public class Program
    {
        private const int N = 6;
        private const int M = 7;
        static List<int>[] verties = new List<int>[N];
        static string input = @"1 3
5 4
3 4
5 3
1 2
5 2
3 6";

        public static void Main()
        {
            ReadInput();
            Dfs(verties, 0);
        }

        private static void Dfs(List<int>[] verties, int v)
        {
            var start = new Node
            {
                Vertex = v,
                Level = 0
            };

            Dfs(verties, start, new HashSet<int>());
        }

        private static void Dfs(List<int>[] verties, Node v, HashSet<int> visited)
        {
            if (visited.Contains(v.Vertex))
            {
                return;
            }

            Console.WriteLine("{0} -> {1} | {2}{0}", v.Vertex + 1, v.Level, new string('-', v.Level));
            // used v
            visited.Add(v.Vertex);

            foreach (var neighbor in verties[v.Vertex])
            {
                var next = new Node
                {
                    Vertex = neighbor,
                    Level = v.Level + 1
                };

                Dfs(verties, next, visited);
            }
        }

        private static void ReadInput()
        {
            var edges = input.Split('\n');

            foreach (var edge in edges)
            {
                var parts = edge.Split(' ');
                var v1 = int.Parse(parts[0]) - 1;
                var v2 = int.Parse(parts[1]) - 1;

                if (verties[v1] == null)
                {
                    verties[v1] = new List<int>();
                }


                if (verties[v2] == null)
                {
                    verties[v2] = new List<int>();
                }


                verties[v1].Add(v2);
                verties[v2].Add(v1);
            }

        }
    }
}
