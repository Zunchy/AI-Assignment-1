using System;
using System.Collections.Generic;
using System.Linq;

namespace AI_Assignment_1
{
    public class BFS_DFS
    {

        public int _nodes;

        //List that holds relationship between nodes  
        public LinkedList<char>[] _nodeLink;

        // Creates new Graph
        public BFS_DFS(int nodes)
        {
            _nodes = nodes;
            _nodeLink = new LinkedList<char>[nodes];
            for (int i = 0; i < _nodeLink.Length; ++i)
                _nodeLink[i] = new LinkedList<char>();
        }

        // Function to add an edge into the graph  
        public void LinkNodes(char node1, char node2)
        {
            _nodeLink[(int)(node1 - 65)].AddLast(node2);
        }

        public void BFS()
        {

            // Keep track of what nodes have been visited
            bool[] visitedNodes = new bool[_nodes];

            Queue<char> queue = new Queue<char>();

            // Start search at queue A then proceed with the search untill queue is empty
            visitedNodes[(int)('A' - 65)] = true;
            queue.Enqueue('A');

            char output;
            while (queue.Any())
            {
                // Print top queue value and remove it
                output = queue.First();
                Console.Write(output + " ");
                queue.Dequeue();

                // Search adjacency list for next unvisited node  
                foreach (var node in _nodeLink[(int)(output - 65)])
                {
                    // If node has not been visited, visit it and add it to the queue
                    if (!visitedNodes[(int)(node - 65)])
                    {
                        visitedNodes[(int)(node - 65)] = true;
                        queue.Enqueue(node);
                    }
                }
            }
        }

        // For recursive DFS, we need the graph, the starting node, and the list of visited nodes
        public void DFS(BFS_DFS graph, char currentNode, bool[] visitedNodes)
        {

            // Visit current node and print
            visitedNodes[(int)(currentNode - 65)] = true;

            Console.Write(currentNode + " ");

            // Search adjacency list for next unvisited node
            foreach (var node in graph._nodeLink[(int)(currentNode - 65)])
            {
                // If node has not been visited, run DFS starting from that node
                if (!visitedNodes[(int)(node - 65)])
                    DFS(graph, node, visitedNodes);
            }
        }
    }
}
