# 📚 Dictionaries em C# (`Dictionary<TKey, TValue>`) - O Motor de Performance

O `Dictionary` armazena dados no formato **Chave-Valor** (Key-Value). Por baixo dos panos, ele usa uma função de Hash para calcular onde o dado está na memória. Isso significa que, independentemente de você ter 10 itens ou 10 milhões de itens, encontrar uma chave demora praticamente o mesmo tempo: **O(1)**.

## 1. Declaração e Inicialização
```csharp
// Exemplo: Chave é int (ID), Valor é string (Nome)
Dictionary<int, string> usuarios = new Dictionary<int, string>();

// Inicialização com valores pré-definidos
Dictionary<string, int> idades = new Dictionary<string, int>
{
    { "Adilson", 23 },
    { "João", 30 }
};