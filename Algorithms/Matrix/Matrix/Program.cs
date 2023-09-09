using System.ComponentModel.DataAnnotations;

class Program
{
    public static void Main(string[] args)
    {
        int[,] graph = new int[2, 3];
        int[,] graph1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

        // taking input from user for graph 

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j< 3; j++)
            {
                var value = Convert.ToInt32(Console.ReadLine());
                graph[i, j] = value;
            }
            
        }
        // print graph

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(graph[i, j] + " ");
            }
            Console.WriteLine("\n");
        }


    }
}