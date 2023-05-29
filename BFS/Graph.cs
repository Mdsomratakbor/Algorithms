using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class Graph
    {

        private readonly int _Vertices;
        public LinkedList<int>[] adjucens;
        public Graph(int V)
        {
            adjucens =  new LinkedList<int>[V];
            for(int i =0; i< adjucens.Length; i++)
            {
                adjucens[i]= new LinkedList<int>();
            }
            _Vertices = V;
        }

        public void AddEdge(int v, int w)
        {
            adjucens[v].AddLast(w);
        }

        public void BFS (int s)
        {
            bool[] visited = new bool[_Vertices];
            for(int i=0; i<_Vertices; i++)
            {
                visited[i] = false;
            }
            LinkedList<int> queue = new LinkedList<int>();
            visited[s] = true;
            queue.AddLast(s);
            while (queue.Any())
            {
                s = queue.First();
                Console.Write(s + " ");
                queue.RemoveFirst();


                LinkedList<int> list = adjucens[s];

                foreach (var value in list)
                {
                    if (!visited[value])
                    {
                        visited[value] = true;
                        queue.AddLast(value);
                    }
                 
                }
            }

        }
    }
}
