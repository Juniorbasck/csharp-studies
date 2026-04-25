public class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>() { 10, 20, 30, 40 };
        
        //Add no final O(1)
        list.Add(50);
        
        //Inserir em um indece especifico - O(N)
        list.Insert(0, 5);
        
        //remover por valor
        list.Remove(30);
        
        //remover pro indice 
        list.Remove(4);
        
        bool hasTrinta = list.Contains(30);
        Console.WriteLine(hasTrinta);
        
        int total = list.Count;

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}