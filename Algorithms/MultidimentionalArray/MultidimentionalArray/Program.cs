using System.Runtime.Serialization.Formatters;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Node");
        int node = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of Edges");
        int edge = Convert.ToInt32(Console.ReadLine());

        int[,] graph = new int[node, edge];

        // initially all nodes are 0
        for(int i = 0; i< node; i++)
        {
            for(int j = 0; j < edge; j++)
            {
                graph[i,j] = 0;
            }
        }
        // taking input from user for graph
        Console.WriteLine("Enter the nodes which are connected");
        for(int i = 0; i < node; i++)
        {
            
            string[] edges = Console.ReadLine().Split(' ');
            int u = Convert.ToInt32(edges[0]);
            int v = Convert.ToInt32(edges[1]);

            graph[u, v] = 1;
            graph[v, u] = 1;
            
        }
        /// print graph 
        /// 
        for(int i = 0; i < node; i++)
        {
            for(int j = 0;j < edge; j++)
            {
                Console.Write(graph[i, j] + " ");
            }
            Console.WriteLine("\n");
        }

    }
}