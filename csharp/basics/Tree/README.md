# 📚 Árvores em C# (Trees & BSTs) - Hierarquia e Recursão

Assim como nos Grafos, o C# não possui uma classe nativa `Tree`. 100% das vezes com **Árvores Binárias** (Binary Trees), onde cada nó tem no máximo dois filhos: Esquerda (`left`) e Direita (`right`).

## 1. A Estrutura Base (A Classe `TreeNode`)
Se o ambiente for um quadro branco, você terá que escrever essa classe rapidamente. Decore a estrutura dela:

```csharp
public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    // Construtor
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) 
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}