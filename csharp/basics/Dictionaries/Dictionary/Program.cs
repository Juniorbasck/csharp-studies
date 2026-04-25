public class Pogram
{
    public static void Main(string[] args)
    {
        //inicalização com valores pré-definidos
        Dictionary<string, int> idades = new Dictionary<string, int>();
        {
            idades["João"] = 20;
            idades["maria"] = 20;
        }
        
        // chave int (ID), valor é uma string
        Dictionary<int, string?> usuarios = new Dictionary<int, string?>();
        
        usuarios.Add(1, "joão");
        usuarios.Add(2, "Maria");
        
        Console.WriteLine(usuarios[1]);

        if (usuarios.TryGetValue(2, out string result))
        {
            Console.WriteLine(result);
        }

        foreach (KeyValuePair<int, string> par in usuarios)
        {
            Console.WriteLine($"{par.Key} - {par.Value}");
        }
        
        Console.WriteLine("--------------------" );

        foreach (var id in usuarios.Keys)
        {
            Console.WriteLine(id);
        }
    }
}