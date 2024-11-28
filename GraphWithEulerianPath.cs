namespace Graphs
{
    class GraphWithEulerianPath: _Graph
    {
        public GraphWithEulerianPath (int maxVertices) : base (maxVertices) {}

        public void FindPathThroughAllEdges()
        {
            List<string> path = new List<string>();
            bool[,] visitedEdges = new bool[vertexCount, vertexCount];

            // ���� ���� ������� � ������ �������
            for (int startVertex = 0; startVertex < vertexCount; startVertex++)
            {
                for (int endVertex = 0; endVertex < vertexCount; endVertex++)
                {
                    if (startVertex != endVertex && !AreAdjacent(startVertex, endVertex))
                    {
                        path.Clear(); // ������� ���� ����� ����� ��������
                        if (DFS(startVertex, endVertex, path, visitedEdges))
                        {
                            Console.WriteLine("������ ���� ����� ��� ����:");
                            Console.WriteLine(string.Join(" -> ", path));
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("���� �� ������.");
        }

        private bool AreAdjacent(int v, int w)
        {
            return adjacencyMatrix[v, w] != 0;
        }

        private bool DFS(int currentVertex, int endVertex, List<string> path, bool[,] visitedEdges)
        {
            path.Add(vertices[currentVertex]);

            // ���������, �������� �� �� �������� ������� � ������ �� ��� ����
            if (currentVertex == endVertex && AllEdgesVisited(visitedEdges))
                return true;

            for (int nextVertex = 0; nextVertex < vertexCount; nextVertex++)
            {
                if (adjacencyMatrix[currentVertex, nextVertex] != 0 && !visitedEdges[currentVertex, nextVertex])
                {
                    visitedEdges[currentVertex, nextVertex] = true; // �������� ���� ��� ����������

                    if (DFS(nextVertex, endVertex, path, visitedEdges))
                        return true;

                    visitedEdges[currentVertex, nextVertex] = false; // �����
                }
            }

            path.RemoveAt(path.Count - 1); // ������� ������� ������� �� ����
            return false;
        }

        private bool AllEdgesVisited(bool[,] visitedEdges)
        {
            for (int i = 0; i < vertexCount; i++)
                for (int j = 0; j < vertexCount; j++)
                    if (adjacencyMatrix[i, j] != 0 && !visitedEdges[i, j])
                        return false;

            return true;
        }
    }
}