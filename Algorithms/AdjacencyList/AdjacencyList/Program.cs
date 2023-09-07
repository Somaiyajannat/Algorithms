class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Adjacency List");
        // Adjacency list declaration

        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        graph[0] = new List<int> {1, 2};
        graph[1] = new List<int> {0, 2};
        graph[2] = new List<int> {0, 1};

        Dictionary<char, List<char>> graph2 = new Dictionary<char, List<char>>();

        graph2['A'] = new List<char> { 'B','C'};
        graph2['B'] = new List<char> { 'A', 'C'};
        graph2['C'] = new List<char> { 'B', 'D' };
        graph2['D'] = new List<char> { 'A', 'C' };

            
    }
}