public class Program
{
    public class ListNode 
    {
        public int val;
        public ListNode next; 

        public ListNode(int val = 0, ListNode next = null) 
        {
            this.val = val;
            this.next = next;
        }
    }
    public static void Main(string[] args)
    {
        // 1. Criando a lista: 10 -> 20 -> 30 -> null
        ListNode head = new ListNode(10);
        head.next = new ListNode(20);
        head.next.next = new ListNode(30);
        
        // 2. Percorrendo a lista (Padrão Ouro de Travessia)
        ListNode current = head; // Começamos da "Cabeça" (Head)
        while (current != null)
        {
            Console.WriteLine(current.val);
            current = current.next;
        }
    }
}