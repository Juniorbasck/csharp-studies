using System.Runtime.InteropServices.JavaScript;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        
        int[][] arestas = new int[][]
        {
            new int[] { 0, 1 },
            new int[] { 1, 2 }
        };
        
        Console.WriteLine("UndirectedGraph");
        
        UndirectedGraph(graph, arestas);
        
        Console.WriteLine("---------------");
        
        Console.WriteLine("DirectedGraph");
        DirectedGraph(graph, arestas);
        
    }

    public static void UndirectedGraph(Dictionary<int, List<int>> graph, int[][] arestas)
    {
        foreach (int[] aresa in arestas)
        {
            int origem = aresa[0];
            int destino = aresa[1];
            
            Console.WriteLine(origem + " + " + destino);
            
            // Se o nó de origem não existe no dicionário, crie a lista
            if (!graph.ContainsKey(origem))
            {
                graph[origem] = new List<int>();
            }
            
            //adicionar vizinho 
            graph[origem].Add(destino);

            if (!graph.ContainsKey(destino))
            {
                graph[destino] = new List<int>();
            }

            graph[destino].Add(origem);
        }
        
        Console.WriteLine("-------------------------------");

        foreach (KeyValuePair<int, List<int>> par in graph)
        {
            int no = par.Key;
            List<int> vizinhos =  par.Value;
            
            Console.WriteLine($"Nó {no} está conectado a: [ {string.Join(", ", vizinhos)} ]");
        }
        
        graph.Clear();
    }
    
    public static void DirectedGraph(Dictionary<int, List<int>> graph, int[][] arestas)
    {

        foreach (int[] aresta in arestas)
        {
            int origem = aresta[0];
            int destino = aresta[1];

            if (!graph.ContainsKey(origem))
            {
                graph[origem] = new List<int>();
            }
            
            graph[origem].Add(destino);

            if (!graph.ContainsKey(destino))
            {
                graph[destino] = new List<int>();
            }
        }
        
        foreach (KeyValuePair<int, List<int>> par in graph)
        {
            int no = par.Key;
            List<int> vizinhos = par.Value;
                
            Console.WriteLine($"Nó {no} está conectado a: [ {string.Join(", ", vizinhos)} ]");
        }
    }
}