using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Assignment_1
{
    class Driver
    {

        static void Main(string[] args)
        {
            //Create graph and add all nodes and adjacency lists
            BFS_DFS graph = new BFS_DFS(6);

            graph.LinkNodes('A', 'B');
            graph.LinkNodes('A', 'C');

            graph.LinkNodes('B', 'A');
            graph.LinkNodes('B', 'C');
            graph.LinkNodes('B', 'D');

            graph.LinkNodes('C', 'A');
            graph.LinkNodes('C', 'B');
            graph.LinkNodes('C', 'D');
            graph.LinkNodes('C', 'E');

            graph.LinkNodes('D', 'B');
            graph.LinkNodes('D', 'C');
            graph.LinkNodes('D', 'E');
            graph.LinkNodes('D', 'F');

            graph.LinkNodes('E', 'C');
            graph.LinkNodes('E', 'D');
            graph.LinkNodes('E', 'F');

            graph.LinkNodes('F', 'D');
            graph.LinkNodes('F', 'E');

            Console.WriteLine("BFS Search of graph");
            graph.BFS();

            Console.WriteLine();

            Console.WriteLine("DFS Search of graph");
            graph.DFS(graph, 'A', new bool[graph._nodes]);

            Console.ReadLine();

        }
    }
}
