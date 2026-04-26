public class Program
{
    public static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        
        stack.Push(1);
        stack.Push(2);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        
        Console.WriteLine(stack.Peek());
        
        int remove =  stack.Pop();
        
        Console.WriteLine(removde);


        while (stack.Count > 0)
        {
            int value = stack.Pop();
            Console.WriteLine(value);
        }
        
    }
}