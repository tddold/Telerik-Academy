namespace GraphsBfsWithNode
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
        static string input = @"1 3
5 4
3 4
5 3
1 2
5 2
3 6";
        static void Main()
        {
            int n = 6;
            int m = 7;

            var vertices = new List<int>[n];

            var edges = input.Split('\n');

            foreach (var edge in edges)
            {
                var parts = edge.Split(' ');
                var v1 = int.Parse(parts[0]) - 1;
                var v2 = int.Parse(parts[1]) - 1;

                if (vertices[v1] == null)
                {
                    vertices[v1] = new List<int>();
                }

                if (vertices[v2] == null)
                {
                    vertices[v2] = new List<int>();
                }

                vertices[v1].Add(v2);
                vertices[v2].Add(v1);
            }

            Bfs(vertices, 0);
        }

        private static void Bfs(List<int>[] vertices, int v)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(new Node
            {
                Vertex = v,
                Level = 0
            });

            var visited = new HashSet<int>();
            var path = new int[vertices.Length];

            visited.Add(v);
            path[v] = -1;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.WriteLine("{0} -> {1} | {2}{0}", current.Vertex + 1, current.Level, new string('-', current.Level));


                foreach (var neighbor in vertices[current.Vertex])
                {
                    if (visited.Contains(neighbor))
                    {
                        continue;
                    }

                    queue.Enqueue(new Node
                    {
                        Vertex = neighbor,
                        Level = current.Level + 1
                    });
                    visited.Add(neighbor);
                    path[neighbor] = current.Vertex;
                }
            }

            Console.WriteLine(new string('-', 40));
            for (int i = 0; i < path.Length; i++)
            {
                Console.WriteLine("{0} <- {1}", i + 1, path[i] + 1);
            }
        }
    }
}
