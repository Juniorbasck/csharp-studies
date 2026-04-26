# 📚 Stacks em C# (`Stack<T>`) - A Essência do DFS

A Pilha (Stack) é a estrutura de dados LIFO (Último a Entrar, Primeiro a Sair). Em entrevistas, ela brilha em dois cenários absolutos:
1. **Iterative DFS:** Fazer Busca em Profundidade em Grafos e Árvores sem usar recursão (o que salva a memória da `Call Stack` e evita `StackOverflowException`).
2. **Parsing / Validação:** Problemas clássicos de checar se parênteses estão abertos/fechados corretamente.

## 1. Declaração e Inicialização
```csharp
Stack<int> pilha = new Stack<int>();