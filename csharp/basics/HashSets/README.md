# 📚 HashSets em C# (`HashSet<T>`) - O Guardião da Unicidade

O `HashSet` é o "primo" do `Dictionary`. A diferença é que ele armazena apenas a **Chave** (não tem o Valor). Ele usa funções de Hash para garantir duas coisas vitais:
1. **Não permite elementos duplicados.**
2. **Consultar se um elemento existe é instantâneo: O(1).**

## 1. Declaração e Inicialização
```csharp
// Muito comum para rastrear nós visitados em Grafos/Árvores
HashSet<int> visitados = new HashSet<int>();

// Inicialização rápida (Collection Initializer)
HashSet<string> cpfsBloqueados = new HashSet<string> { "111", "222" };      