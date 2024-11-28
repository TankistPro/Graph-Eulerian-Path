namespace Graphs
{
    class GraphWithEulerianPath: _Graph
    {
        public GraphWithEulerianPath (int maxVertices) : base (maxVertices) {}

        public void GetEulerWay()
        {
            List<string> path = new List<string>();
            bool[,] visitedEdges = new bool[vertexCount, vertexCount];

            // ���� ���� ������� � ������ �������
            for (int startVertex = 0; startVertex < vertexCount; startVertex++)
            {
                for (int endVertex = 0; endVertex < vertexCount; endVertex++)
                {
                    if (startVertex != endVertex && !AreAdjacent(VERTEX(startVertex), VERTEX(endVertex)))
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

            Console.WriteLine("����, ���������� ����� ��� ����, �� ������.");
        }

        private bool DFS(int currentVertex, int endVertex, List<string> path, bool[,] visitedEdges)
        {
            path.Add(VERTEX(currentVertex));

            // ���������, �������� �� �� �������� ������� � ������ �� ��� ����
            if (currentVertex == endVertex && AllEdgesVisited(visitedEdges))
                return true;

            for (int nextVertex = 0; nextVertex < vertexCount; nextVertex++)
            {
                if (AreAdjacent(VERTEX(currentVertex), VERTEX(nextVertex)) && !visitedEdges[currentVertex, nextVertex])
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