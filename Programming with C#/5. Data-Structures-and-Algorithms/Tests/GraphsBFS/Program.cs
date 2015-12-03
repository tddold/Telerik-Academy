namespace GraphsBFS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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

            List<int>[] vertices = new List<int>[n];
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
            var queue = new Queue<int>();
            queue.Enqueue(v);
            var visited = new HashSet<int>();
            visited.Add(v);

            //bool[] visited = new bool[vertices.Length];
            //visited[v] = true;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                Console.Write("{0}, ", current + 1);

                // if graph id oriented, check if any neighbor
                //if (vertices[current] == null)
                //{
                //    continue;
                //}

                foreach (var neighbor in vertices[current])
                {
                    if (visited.Contains(neighbor))
                    {
                        continue;
                    }

                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                }


            }

            Console.WriteLine();
        }
    }
}
