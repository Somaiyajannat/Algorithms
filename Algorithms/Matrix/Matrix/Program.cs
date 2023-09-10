using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main(string[] args)
    {
        // array declaration two types
        Console.WriteLine("Enter number of Node of Graph: ");
        int node = Convert.ToInt32(Console.ReadLine());

        // adjancy list
        List<List<int>> adjList = new List<List<int>>();
        List<int>[] adjList2 = new List<int>[node];

        for (int i = 0; i < node; ++i)
        {
            adjList.Add(new List<int>());
            adjList2[i] = new List<int>();
        }

        // adjancency matrix
        int[,] graph = new int[node, node];

        for (int i = 0; i < node; ++i)
        {
            for (int j = 0; j < node; ++j)
            {
                graph[i, j] = 0;
            }
        }

        Console.WriteLine("Enter number of Edges of Graph: ");
        int edges = Convert.ToInt32(Console.ReadLine());



        // taking input from user for graph 

        for (int i = 0; i < edges; ++i)
        {
            String[] edge = Console.ReadLine().Split(' ');
            int u = Convert.ToInt32(edge[0]);
            int v = Convert.ToInt32(edge[1]);

            graph[u, v] = 1;
            graph[v, u] = 1;

            adjList[u].Add(v);
            adjList[v].Add(u);

            adjList2[u].Add(v);
            adjList2[v].Add(u);
        }

        //int min_distance = Diajkstra(graph, src, dest);

        // printing adjancy matrix

        for (int i = 0; i < node; i++)
        {
            for(int j = 0; j< node; j++)
            {
                Console.Write(graph[i, j] + " ");
            }
            Console.WriteLine("\n");
        }

        // printing adjancy List

        for (int i = 0; i < adjList.Count; i++)
        {
            for (int j = 0; j < adjList[i].Count; j++)
            {
                Console.Write(adjList[i][j] + " ");
            }
            Console.WriteLine("\n");
        }

        // printing adjancy List2

        for (int i = 0; i < node; i++)
        {
            for (int j = 0; j < adjList2[i].Count; j++)
            {
                Console.Write(adjList2[i][j] + " ");
            }
            Console.WriteLine("\n");
        }
    }

    public int Diajkstra(int[,] graph, int src, int dest)
    {
        return 0;
    }
}