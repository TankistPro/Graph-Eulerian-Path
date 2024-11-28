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
            foreach (var startVertex in vertices)
            {
                foreach (var endVertex in vertices)
                {
                    if (startVertex.Key != endVertex.Key && !AreAdjacent(VERTEX(startVertex.Key), VERTEX(endVertex.Key)))
                    {
                        path.Clear(); // ������� ���� ����� ����� ��������
                        if (DFS(startVertex.Value, endVertex.Value, path, visitedEdges))
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

        private bool DFS(string currentVertex, string endVertex, List<string> path, bool[,] visitedEdges)
        {
            path.Add(VERTEX(indexOfName(currentVertex)));

            // ���������, �������� �� �� �������� ������� � ������ �� ��� ����
            if (indexOfName(currentVertex) == indexOfName(endVertex) && AllEdgesVisited(visitedEdges))
                return true;

            for (int nextVertex = FIRST(currentVertex); nextVertex > -1; nextVertex = NEXT(currentVertex, nextVertex + 1))
            {
                if (AreAdjacent(VERTEX(indexOfName(currentVertex)), VERTEX(nextVertex)) && !visitedEdges[indexOfName(currentVertex), nextVertex])
                {
                    visitedEdges[indexOfName(currentVertex), nextVertex] = true; // �������� ���� ��� ����������

                    if (DFS(VERTEX(nextVertex), endVertex, path, visitedEdges))
                        return true;

                    visitedEdges[indexOfName(currentVertex), nextVertex] = false; // �����
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