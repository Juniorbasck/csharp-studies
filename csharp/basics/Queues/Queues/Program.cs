public class Program
{
    public static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
    
        // 1. ENQUEUE: Adiciona ao final da fila
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        
        int result = queue.Dequeue();
        
        // 2. PEEK: Olha quem está na frente (sem remover)
        Console.WriteLine(result);
        
        // 3. DEQUEUE: Remove e retorna quem está na frente
        int remove = queue.Dequeue();
    }
}