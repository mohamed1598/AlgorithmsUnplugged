using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Graph_Search
{
    
    public static class DFS<T> where T : notnull
    {
       private static readonly Dictionary<T, bool> NodeDiscovered = new();
       public static void PrintDFS(Graph<T> g)
        {
            foreach (Node<T> node in g.Nodes)
            {
                if(!NodeDiscovered.TryGetValue(node.Value!,out _))
                {
                    System.Console.Write(node.Value + " => ");
                    NodeDiscovered.Add(node.Value!, true);
                    if (node.Childs != null)
                    {
                        Graph<T> childGraph = new () { Nodes = node.Childs };
                        PrintDFS(childGraph);
                    }
                }
                
            }
        }
    }
}
