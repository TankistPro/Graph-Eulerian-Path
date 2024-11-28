
//namespace Graphs
//{
//public class Vertix
//{
//    public string Name;
//    public bool Visited;
//    public string Mark;

//    public Vertix(string name, string mark)
//    {
//        Name = name;
//        Mark = mark;
//    }
//}

//class Edge
//{
//    public int Weight;
//    public Vertix Vertix;

//    public Edge(int weight, Vertix vertix)
//    {
//        Weight = weight;
//        Vertix = vertix;
//    }
//}

//    class _Graph
//    {
//        private int[,] _adjacencyMatrix; // Матрица смежности
//        private string[] _labels; // Метки вершин
//        private int _vertices; // Количество вершин

//        private Vertix[] _verticesList;
//        //private Edge[] _edgesList;


//        public _Graph(int vertices)
//        {
//            _vertices = 0;
//            _adjacencyMatrix = new int[vertices, vertices];
//            _labels = new string[vertices];

//            _verticesList = new Vertix[vertices];
//            //_edgesList = new Edge[vertices];
//        }

//        public void AddVertex(string name, string mark)
//        {
//            if (_vertices < _verticesList.Length)
//            {
//                _labels[_vertices] = mark;

//                _verticesList[_vertices].Name = name;
//                _verticesList[_vertices].Mark = mark;

//                _vertices++;
//            }
//            else
//            {
//                Console.WriteLine("Превышено максимальное количество вершин.");
//            }
//        }

//        public void AddEdge(int from, int to, int weight)
//        {
//            if (from < _vertices && to < _vertices)
//            {
//                var formVertix = _verticesList.FirstOrDefault(x => x.Name === )
//                _adjacencyMatrix[from, to] = 1; // Добавляем направленное ребро с весом
//            }
//        }

//        public void DeleteVertex(int vertex)
//        {
//            if (vertex < _vertices)
//            {
//                for (int i = 0; i < _vertices; i++)
//                {
//                    _adjacencyMatrix[vertex, i] = 0; // Удаляем все рёбра из удаляемой вершины
//                    _adjacencyMatrix[i, vertex] = 0; // Удаляем все рёбра к удаляемой вершине
//                }
//                _labels[vertex] = null; // Удаляем метку
//                _verticesList
//            }
//        }

//        public void EditVertex(int vertex, string newMark)
//        {
//            if (vertex < _vertices)
//            {
//                _labels[vertex] = newMark; // Изменяем метку вершины
//            }
//        }

//        public void EditEdge(int from, int to, int newWeight)
//        {
//            if (from < _vertices && to < _vertices)
//            {
//                _adjacencyMatrix[from, to] = newWeight; // Изменяем вес ребра
//            }
//        }

//        public void DeleteEdge(int from, int to)
//        {
//            if (from < _vertices && to < _vertices)
//            {
//                _adjacencyMatrix[from, to] = 0; // Удаляем направленное ребро
//            }
//        }

//        public int First(int v)
//        {
//            for (int i = 0; i < _vertices; i++)
//            {
//                if (_adjacencyMatrix[v, i] > 0) // Если есть смежная вершина
//                    return i;
//            }
//            return -1; // Нулевая вершина если нет смежных вершин
//        }

//        public int Next(int v, int i)
//        {
//            for (int j = i + 1; j < _vertices; j++)
//            {
//                if (_adjacencyMatrix[v, j] > 0) // Если есть смежная вершина после i
//                    return j;
//            }
//            return -1; // Нулевая вершина если нет следующей смежной вершины
//        }

//        public int Vertex(int v, int i)
//        {
//            int count = 0;
//            for (int j = 0; j < _vertices; j++)
//            {
//                if (_adjacencyMatrix[v, j] > 0) // Если есть смежная вершина
//                {
//                    if (count == i) return j; // Возвращаем вершину с индексом i
//                    count++;
//                }
//            }
//            return -1; // Нулевая вершина если индекс выходит за пределы
//        }

//        public bool FindEulerianPath(int startVertex, out List<int> path)
//        {
//            path = new List<int>();
//            bool[] visitedEdges = new bool[_vertices * _vertices]; // Массив для отслеживания посещённых рёбер
//            Stack<int> stack = new Stack<int>();
//            stack.Push(startVertex);

//            while (stack.Count > 0)
//            {
//                int currentVertex = stack.Peek();
//                bool foundEdge = false;

//                for (int i = 0; i < _vertices; i++)
//                {
//                    if (_adjacencyMatrix[currentVertex, i] > 0 && !visitedEdges[currentVertex * _vertices + i])
//                    {
//                        visitedEdges[currentVertex * _vertices + i] = true; // Отмечаем ребро как посещённое
//                        stack.Push(i);
//                        foundEdge = true;
//                        break; // Переходим к следующему узлу
//                    }
//                }

//                if (!foundEdge)
//                {
//                    path.Add(stack.Pop()); // Если рёбер больше нет, добавляем вершину в путь
//                }
//            }

//            return path.Count > 1 && !AreVerticesAdjacent(path[0], path[path.Count - 1]);
//        }

//        private bool AreVerticesAdjacent(int v1, int v2)
//        {
//            return _adjacencyMatrix[v1, v2] == 1 || _adjacencyMatrix[v2, v1] == 1;
//        }
//    }
//}







//namespace Graphs
//{
//    class _Graph
//    {
//        private int[,] _adjacencyMatrix; // Матрица смежности
//        private string[] _labels; // Метки вершин
//        private int _vertices; // Количество вершин

//        public _Graph(int vertices)
//        {
//            _vertices = vertices;
//            _adjacencyMatrix = new int[vertices, vertices];
//            _labels = new string[vertices];
//        }

//        public void AddVertex()
//        {
//            _labels.Append(String.Empty);
//            _vertices++;

//            // Расширяем матрицу смежности
//            int[,] newAdjacencyMatrix = new int[_vertices, _vertices];
//            for (int i = 0; i < _adjacencyMatrix.GetLength(0); i++)
//            {
//                for (int x = 0; x < _adjacencyMatrix.GetLength(1); x++)
//                {
//                    newAdjacencyMatrix[i, x] = _adjacencyMatrix[i, x];
//                }
//            }

//            _adjacencyMatrix = newAdjacencyMatrix;
//        }

//        public void AddEdge(int from, int to, int weight)
//        {
//            if (from < _vertices && to < _vertices)
//            {
//                _adjacencyMatrix[from, to] = 1; // Добавляем направленное ребро с весом
//            }
//        }

//        public void DeleteVertex(int vertex)
//        {
//            if (vertex < _vertices)
//            {
//                for (int i = 0; i < _vertices; i++)
//                {
//                    _adjacencyMatrix[vertex, i] = 0; // Удаляем все рёбра из удаляемой вершины
//                    _adjacencyMatrix[i, vertex] = 0; // Удаляем все рёбра к удаляемой вершине
//                }
//                _labels[vertex] = null; // Удаляем метку
//            }
//        }

//        public void EditVertex(int vertex, string newMark)
//        {
//            if (vertex < _vertices)
//            {
//                _labels[vertex] = newMark; // Изменяем метку вершины
//            }
//        }

//        public void DeleteEdge(int from, int to)
//        {
//            if (from < _vertices && to < _vertices)
//            {
//                _adjacencyMatrix[from, to] = 0; // Удаляем направленное ребро
//            }
//        }

//        public int First(int v)
//        {
//            for (int i = 0; i < _vertices; i++)
//            {
//                if (_adjacencyMatrix[v, i] > 0) // Если есть смежная вершина
//                    return i;
//            }
//            return -1; // Нулевая вершина если нет смежных вершин
//        }

//        public int Next(int v, int i)
//        {
//            for (int j = i + 1; j < _vertices; j++)
//            {
//                if (_adjacencyMatrix[v, j] > 0) // Если есть смежная вершина после i
//                    return j;
//            }
//            return -1; // Нулевая вершина если нет следующей смежной вершины
//        }

//        public int Vertex(int v, int i)
//        {
//            int count = 0;
//            for (int j = 0; j < _vertices; j++)
//            {
//                if (_adjacencyMatrix[v, j] > 0) // Если есть смежная вершина
//                {
//                    if (count == i) return j; // Возвращаем вершину с индексом i
//                    count++;
//                }
//            }
//            return -1; // Нулевая вершина если индекс выходит за пределы
//        }

//        public bool FindEulerianPath(int startVertex, out List<int> path)
//        {
//            path = new List<int>();
//            bool[] visitedEdges = new bool[_vertices * _vertices]; // Массив для отслеживания посещённых рёбер
//            Stack<int> stack = new Stack<int>();
//            stack.Push(startVertex);

//            while (stack.Count > 0)
//            {
//                int currentVertex = stack.Peek();
//                bool foundEdge = false;

//                for (int i = 0; i < _vertices; i++)
//                {
//                    if (_adjacencyMatrix[currentVertex, i] > 0 && !visitedEdges[currentVertex * _vertices + i])
//                    {
//                        visitedEdges[currentVertex * _vertices + i] = true; // Отмечаем ребро как посещённое
//                        stack.Push(i);
//                        foundEdge = true;
//                        break; // Переходим к следующему узлу
//                    }
//                }

//                if (!foundEdge)
//                {
//                    path.Add(stack.Pop()); // Если рёбер больше нет, добавляем вершину в путь
//                }
//            }

//            return path.Count > 1 && !AreVerticesAdjacent(path[0], path[path.Count - 1]);
//        }

//        private bool AreVerticesAdjacent(int v1, int v2)
//        {
//            return _adjacencyMatrix[v1, v2] == 1 || _adjacencyMatrix[v2, v1] == 1;
//        }

//        public void Print()
//        {
//            for (int i = 0; i < _vertices; i++)
//            {
//                for (int x = 0; x < _vertices; x++)
//                {
//                    Console.Write(_adjacencyMatrix[i, x] + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
