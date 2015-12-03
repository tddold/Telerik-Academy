namespace GraphsDfs
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


    class Program
    {
        private const int N = 6;
        private const int M = 7;
        private static readonly HashSet<int> Visited = new HashSet<int>();
        private static readonly List<int>[] verties = new List<int>[N];
        static string input = @"1 3
5 4
3 4
5 3
1 2
5 2
3 6";

        static void Main()
        {
            ReadInput();
            Dfs(verties, 0);
        }

        private static void Dfs(List<int>[] verties, int v)
        {
            var nodes = new Stack<Node>();
            nodes.Push(new Node
            {
                Vertex = v,
                Level = 0
            });
            Visited.Add(v);

            while (nodes.Count > 0)
            {
                var currentNode = nodes.Pop();
                Console.WriteLine("{0} -> {1} | {2}{0}", currentNode.Vertex + 1, currentNode.Level, new string('-', currentNode.Level));

                foreach (var neighbor in verties[currentNode.Vertex])
                {
                    if (!Visited.Contains(neighbor))
                    {
                        nodes.Push(new Node
                        {
                            Vertex = neighbor,
                            Level = currentNode.Level + 1
                        });
                        Visited.Add(neighbor);
                    }
                }
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
