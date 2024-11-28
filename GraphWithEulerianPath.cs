namespace Graphs
{
    class GraphWithEulerianPath: _Graph
    {
        public GraphWithEulerianPath (int maxVertices) : base (maxVertices) {}

        public void GetEulerWay()
        {
            List<string> path = new List<string>();
            bool[,] visitedEdges = new bool[vertexCount, vertexCount];

            // Ищем путь начиная с каждой вершины
            for (int startVertex = 0; startVertex < vertexCount; startVertex++)
            {
                for (int endVertex = 0; endVertex < vertexCount; endVertex++)
                {
                    if (startVertex != endVertex && !AreAdjacent(VERTEX(startVertex), VERTEX(endVertex)))
                    {
                        path.Clear(); // Очищаем путь перед новой попыткой
                        if (DFS(startVertex, endVertex, path, visitedEdges))
                        {
                            Console.WriteLine("Найден путь через все дуги:");
                            Console.WriteLine(string.Join(" -> ", path));
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("Путь, проходящий через все дуги, не найден.");
        }

        private bool DFS(int currentVertex, int endVertex, List<string> path, bool[,] visitedEdges)
        {
            path.Add(VERTEX(currentVertex));

            // Проверяем, достигли ли мы конечной вершины и прошли ли все дуги
            if (currentVertex == endVertex && AllEdgesVisited(visitedEdges))
                return true;

            for (int nextVertex = 0; nextVertex < vertexCount; nextVertex++)
            {
                if (AreAdjacent(VERTEX(currentVertex), VERTEX(nextVertex)) && !visitedEdges[currentVertex, nextVertex])
                {
                    visitedEdges[currentVertex, nextVertex] = true; // Помечаем дугу как посещенную

                    if (DFS(nextVertex, endVertex, path, visitedEdges))
                        return true;

                    visitedEdges[currentVertex, nextVertex] = false; // Откат
                }
            }

            path.RemoveAt(path.Count - 1); // Удаляем текущую вершину из пути
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