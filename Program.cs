using System;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _Graph graph = new _Graph(5);

            graph.ADD_V("a");
            graph.ADD_V("b");
            graph.ADD_V("c");
            graph.ADD_V("d");
            graph.ADD_V("e");

            graph.ADD_E("a", "b");
            graph.ADD_E("a", "c");
            graph.ADD_E("b", "e");
            graph.ADD_E("b", "d");

            Console.WriteLine(graph.VERTEX(0));

            graph.PrintAdjacencyMatrix();
        }
    }
}