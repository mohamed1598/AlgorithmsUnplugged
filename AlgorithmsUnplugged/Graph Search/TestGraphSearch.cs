using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Graph_Search
{
    public static class TestGraphSearch
    {
        public static Graph<int> CreateGraph()
        {
            Graph<int> g = new();
            var node1 = new Node<int>() { Value = 1111 };
            var node2 = new Node<int>() { Value = 1112 };
            var node3 = new Node<int>() { Value = 1113 };
            var node4 = new Node<int>() { Value = 2221 };
            var node5 = new Node<int>() { Value = 2222 };
            var node6 = new Node<int>() { Value = 2223 };
            var node7 = new Node<int>() { Value = 3331 };
            var node8 = new Node<int>() { Value = 3332 };
            var node9 = new Node<int>() { Value = 3333 };
            var node13Childs = new LinkedList<Node<int>>();
            node13Childs.AddFirst(node1);
            node13Childs.AddLast(node2);
            node13Childs.AddLast(node3);
            var node13 = new Node<int>() { Value = 111, Childs = node13Childs };
            var node14Childs = new LinkedList<Node<int>>();
            node14Childs.AddFirst(node4);
            node14Childs.AddLast(node5);
            node14Childs.AddLast(node6);
            var node14 = new Node<int>() { Value = 222, Childs = node14Childs };
            var node15Childs = new LinkedList<Node<int>>();
            node15Childs.AddFirst(node7);
            node15Childs.AddLast(node8);
            node15Childs.AddLast(node9);
            var node15 = new Node<int>() { Value = 333, Childs = node15Childs };
            var node16Childs = new LinkedList<Node<int>>();
            node16Childs.AddFirst(node13);
            node16Childs.AddLast(node14);
            var node16 = new Node<int>() { Value = 11, Childs = node16Childs };
            LinkedList<Node<int>> nodes = new ();
            nodes.AddFirst(node16);
            nodes.AddLast(node15);
            g.Nodes = nodes;
            return g;
        }
        public static void Print()
        {
            Graph<int> g = CreateGraph();
            Console.WriteLine("Depth First Search");
            DFS<int>.PrintDFS(g);
            Console.WriteLine("\n Breadth First Search");
            BFS<int>.PrintBFS(g);
        }
    }
}
