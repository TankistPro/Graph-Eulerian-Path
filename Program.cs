using System;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _Graph graph = new _Graph(5);

            graph.AddVertex();
            graph.AddEdge(0, 1, 10);
            graph.AddEdge(1, 2, 10);
            graph.AddEdge(2, 3, 20);

            graph.Print();

            List<int> eulerPath;

            if (graph.FindEulerianPath(0, out eulerPath))
            {
                Console.WriteLine("Эйлеров путь найден:");
                Console.WriteLine(string.Join(" -> ", eulerPath));
            }
            else
            {
                Console.WriteLine("Эйлеров путь не существует.");
            }
        }
    }
}