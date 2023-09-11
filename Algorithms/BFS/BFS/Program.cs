using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    // bfs implemetation
    public static void BFS(int[, ] graph, int src, int node)
    {
        // declare queue
        Queue<int> qt = new Queue<int>();
        int[] visited = new int[node];

        // initially visited arrays 
        Array.Fill(visited, 0);

        //for (int i = 0; i < node; i++)
        //{
        //    visited[i] = 0;
        //}

        qt.Enqueue(src);
        visited[src] = 1;
        Console.WriteLine("Parent: " + "-1" + " Child: " + src);

        while (qt.Count > 0)
        {
            int u = qt.Peek();
            qt.Dequeue();

            for (int v = 0; v < node; ++v)
            {
                if (visited[v] == 0 && graph[u, v] == 1)
                {
                    Console.WriteLine("Parent: " + u + " Child: " + v);
                    qt.Enqueue(v);
                    visited[v] = 1;
                }
            }
        }
    }
    // done

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Node");
        int node = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of Edge");
        int edge = Convert.ToInt32(Console.ReadLine());

        // graph declaration through dimentional array

        int[,] graph = new int[node, edge];

        // graph input
        Console.WriteLine("Enter the Edges");
        for(int i = 0; i < node; i++)
        {
            string[] edges = Console.ReadLine().Split(' ');
            int u = Convert.ToInt32(edges[0]);
            int v = Convert.ToInt32(edges[1]);
            graph[u, v] = 1;
            graph[v, u] = 1;
        }
        // print graph

        for(int i = 0; i < node; i++)
        {
            for(int j = 0;j < edge; j++)
            {
                Console.Write(graph[i, j] + " ");
                    
            }
            Console.WriteLine("\n");
        }
        int src = 0;
        BFS(graph, src, node);
        
    }
}