using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Graph_Search
{
    public static class BFS<T> where T : notnull
    {
        private static readonly Dictionary<T, bool> NodeDiscovered = new();
        private static readonly Queue<Node<T>> Queue = new ();
        public static void PrintBFS(Graph<T> g)
        {
            foreach (Node<T> node in g.Nodes)
            {
                    Queue.Enqueue(node);
                
            }
            while (Queue.Count > 0)
            {
                var FirstNode = Queue.Dequeue();
                if (!NodeDiscovered.TryGetValue(FirstNode.Value!, out _))
                {
                    System.Console.Write(FirstNode.Value + " => ");
                    NodeDiscovered.Add(FirstNode.Value!, true);
                    if (FirstNode.Childs != null)
                    {
                        foreach (var node in FirstNode.Childs)
                        {
                            Queue.Enqueue(node);
                        }
                    }
                }
            }
        }
    }
}
