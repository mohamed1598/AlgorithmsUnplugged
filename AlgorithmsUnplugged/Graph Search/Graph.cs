using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Graph_Search
{
    public class Node<T>
    {
        public T? Value { get; set; }
        public LinkedList<Node<T>>? Childs { get; set; }
    }
    public class Graph<T>
    {
        public LinkedList<Node<T>> Nodes = new();
        public Graph()
        {
        }

        public void AddEdge(Node<T> parent, T value, bool biDirEdge = true)
        {
            Node<T> valueNode = new();
            valueNode.Value = value;
            if (biDirEdge)
            {
                valueNode.Childs = new LinkedList<Node<T>>();
                valueNode.Childs!.AddFirst(parent);
            }
            if (parent.Childs == null)
            {
                parent.Childs = new LinkedList<Node<T>>();
                parent.Childs!.AddFirst(valueNode);
            }
            else
            {
                parent.Childs!.AddLast(valueNode);
            }
        }
    }
}
