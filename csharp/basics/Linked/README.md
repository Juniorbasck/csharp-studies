# 🔗 Linked Lists em C# 

Enquanto os Arrays são como caixas de ovos (elementos guardados lado a lado, em blocos contínuos de memória), as **Linked Lists** (Listas Ligadas) são como uma caça ao tesouro. Os dados ficam espalhados pela memória, e cada elemento só sabe onde está o **próximo**.


A grande vantagem dessa estrutura é a flexibilidade: inserir ou remover um nó no meio da lista não exige "empurrar" todos os outros elementos para a frente, basta redirecionar as setas (ponteiros). A desvantagem é que perdemos o acesso direto por índice (`lista[5]` não funciona, precisamos caminhar do início até o 5º elemento).

## 1. A Estrutura Base (A Classe `ListNode`)

No C# (e nas plataformas de entrevista como LeetCode e HackerRank), raramente usamos a classe nativa `LinkedList<T>`. Precisamos manipular a estrutura "crua". Decore a classe abaixo:

```csharp
public class ListNode 
{
    public int val;
    public ListNode next; // O ponteiro (seta) para o próximo nó

    // Construtor
    public ListNode(int val = 0, ListNode next = null) 
    {
        this.val = val;
        this.next = next;
    }
}