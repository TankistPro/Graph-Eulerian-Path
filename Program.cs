﻿using System;

namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphWithEulerianPath graph = new GraphWithEulerianPath(5);

            graph.ADD_V("a");
            graph.ADD_V("b");
            graph.ADD_V("c");
            graph.ADD_V("d");
            graph.ADD_V("e");

            graph.ADD_E("a", "b");
            graph.ADD_E("b", "c");
            graph.ADD_E("c", "d");
            graph.ADD_E("d", "e");

            graph.PrintAdjacencyMatrix();

            graph.FindPathThroughAllEdges();
        }
    }
}