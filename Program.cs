namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphWithEulerianPath graph = new GraphWithEulerianPath(6);

            graph.ADD_V("a");
            graph.ADD_V("b");
            graph.ADD_V("c");
            graph.ADD_V("d");
            graph.ADD_V("e");
            graph.ADD_V("f");

            graph.ADD_E("a", "b");
            graph.ADD_E("b", "c");
            graph.ADD_E("c", "a");
            graph.ADD_E("a", "d");
            graph.ADD_E("d", "e");
            graph.ADD_E("e", "c");
            graph.ADD_E("c", "f");

            graph.PrintAdjacencyMatrix();

            graph.GetEulerWay();
        }
    }
}