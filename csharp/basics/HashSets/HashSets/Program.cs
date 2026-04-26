public class Program
{
    public static void Main(string[] args)
    {
        // Muito comum para rastrear nós visitados em Grafos/Árvores
        HashSet<int> visitados = new HashSet<int>();

        HashSet<string> cpfsBloqueados = new HashSet<string> { "1234", "12345"};

        bool isVisited = visitados.Add(10);
        
        bool isVisited2 = visitados.Add(10);
        
        // Retorna true se removeu, false se não existia
        visitados.Remove(10);
        
        // Esvazia tudo
        visitados.Clear();
        
        //remover todas as duplicatas de um array
        int[] numDuplicates = { 1, 2, 2, 3, 3, 3 };

        HashSet<int> unicos = new HashSet<int>(numDuplicates);

        foreach (var num in unicos)
        {
            Console.WriteLine(num);
        }

    }
}