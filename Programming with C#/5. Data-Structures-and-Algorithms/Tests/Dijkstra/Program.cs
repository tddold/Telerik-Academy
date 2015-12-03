namespace Dijkstra
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static string inputWeightedGraph = @"0 3 7
0 4 3
0 5 5 
1 2 10
1 3 2 
1 4 1
2 4 100
2 5 17
3 4 1
4 5 3";

        static void Main()
        {
            Dijkstra();
        }

        public class WeightedNode : IComparable<WeightedNode>
        {
            public WeightedNode(int vertix, int weight)
            {
                this.Vertix = vertix;
                this.Weight = weight;
            }

            public int Vertix { get; set; }

            public int Weight { get; set; }

            public int CompareTo(WeightedNode other)
            {
                if (this.Weight.CompareTo(other.Weight) == 0)
                {
                    return this.Vertix.CompareTo(other.Vertix);
                }

                return this.Weight.CompareTo(other.Weight);
            }
        }

        private static void Dijkstra()
        {
            int v = 0;
            var vertices = ReadInput(inputWeightedGraph);

            var visited = new HashSet<int>();
            var queue = new SortedSet<WeightedNode>();

            // int[] d = new int[vertices.Length];
            int[] d = Enumerable.Repeat(int.MaxValue, vertices.Length)
                 .ToArray();

            d[v] = 0;
            queue.Add(new WeightedNode(v, 0));
            int[] path = new int[vertices.Length];
            path[v] = -1;


            while (queue.Count > 0)
            {
                var current = queue.Min;
                queue.Remove(current);
                visited.Add(current.Vertix);

                // calculate distance
                foreach (var neighbor in vertices[current.Vertix])
                {
                    var currentDistance = d[neighbor.Vertix];
                    var newDistabce = d[current.Vertix] + neighbor.Weight;

                    if (currentDistance > newDistabce)
                    {
                        d[neighbor.Vertix] = newDistabce;
                        queue.Add(new WeightedNode(neighbor.Vertix, newDistabce));
                        path[neighbor.Vertix] = current.Vertix;
                    }
                }

                // remove top visited from queue
                while (queue.Count > 0 && visited.Contains(queue.Min.Vertix))
                {
                    queue.Remove(queue.Min);
                }
            }

            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("{0} <- {2, 2} | {1, 2}", i, d[i], path[i]);
            }


        }

        private static List<WeightedNode>[] ReadInput(string input)
        {
            int n = 6;
            var vertices = new List<WeightedNode>[n];
            var edges = input.Split('\n');

            foreach (var edge in edges)
            {
                var parts = edge.Split(' ');
                var v1 = int.Parse(parts[0]);
                var v2 = int.Parse(parts[1]);
                var w = int.Parse(parts[2]);

                if (vertices[v1] == null)
                {
                    vertices[v1] = new List<WeightedNode>();
                }

                if (vertices[v2] == null)
                {
                    vertices[v2] = new List<WeightedNode>();
                }


                vertices[v1].Add(new WeightedNode(v2, w));
                vertices[v2].Add(new WeightedNode(v1, w));
            }

            return vertices;
        }
    }
}
