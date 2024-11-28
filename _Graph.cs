
using System.Xml.Linq;

namespace Graphs
{
    class _Graph
    {
        private Dictionary<int, string> vertices; // Список вершин
        private int[,] adjacencyMatrix; // Матрица смежности
        private int vertexCount; // Количество вершин

        public _Graph(int maxVertices)
        {
            vertices = new Dictionary<int, string>(maxVertices);
            adjacencyMatrix = new int[maxVertices, maxVertices];
            vertexCount = 0;
        }

        public int FIRST(string name)
        {
            for (int i = 0; i < vertexCount; i++)
            {
                if (adjacencyMatrix[indexOfName(name), i] != 0) // Если есть связь
                    return i;
            }
            return -1; // Нулевая вершина
        }

        public int NEXT(string name, int i)
        {
            for (int j = i + 1; j < vertexCount; j++)
            {
                if (adjacencyMatrix[indexOfName(name), j] != 0) // Если есть связь
                    return j;
            }
            return -1; // Нету следующей вершины
        }

        public string VERTEX(int i)
        {
            if (i < vertexCount)
                return vertices[i];
            throw new IndexOutOfRangeException("Индекс выходит за пределы списка вершин.");
        }

        public void ADD_V(string name)
        {
            vertices.Add(vertexCount, name);
            vertexCount++;
        }

        public void ADD_E(string v, string w)
        {
            var vertex1 = indexOfName(v);
            var vertex2 = indexOfName(w);

            if(vertex1 == -1 || vertex2 == -1)
            {
                throw new ArgumentException("[ADD_E] Вершины не существует.");
            }

            adjacencyMatrix[indexOfName(v), indexOfName(w)] = 1;
        }

        public void DEL_V(string name)
        {
            int key = indexOfName(name); 
            if (key == -1) throw new ArgumentException("[DEL_V] Вершина не найдена.");

            vertices.Remove(key);

            for (int i = 0; i < vertexCount; i++)
            {
                adjacencyMatrix[key, i] = 0; // Удаляем все рёбра из удаляемой вершины
                adjacencyMatrix[i, key] = 0; // Удаляем все рёбра к удаляемой вершине
            }

            vertexCount--;
        }

        public void DEL_E(string v, string w)
        {
            adjacencyMatrix[indexOfName(v), indexOfName(v)] = 0; // Удаляем дугу
        }

        public void EDIT_V(string oldName, string newName)
        {
            int key = indexOfName(oldName);
            if (key == -1) throw new ArgumentException("[EDIT_V] Вершина не найдена.");

            vertices[key] = newName;
        }

        //public void EDIT_E(int v, int w, int newWeight)
        //{
        //    if (adjacencyMatrix[v, w] == 0) throw new ArgumentException("Дуга не существует.");

        //    adjacencyMatrix[v, w] = newWeight; // Изменяем вес дуги
        //}

        public void PrintAdjacencyMatrix()
        {
            Console.WriteLine("Матрица смежности: ");
            for (int i = 0; i < adjacencyMatrix.GetLength(0); i++)
            {
                for (int x = 0; x < adjacencyMatrix.GetLength(1); x++)
                {
                    Console.Write(adjacencyMatrix[i, x] + " ");
                }
                Console.WriteLine();
            }
        }

        private int indexOfName(string name)
        {
            var vertex = vertices.Where(x => x.Value == name);

            if(vertex.Any())
            {
                return vertex.FirstOrDefault().Key;
            }

            return -1;
        }
    }
}
