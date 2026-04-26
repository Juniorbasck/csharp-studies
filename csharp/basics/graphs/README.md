# 📚 Grafos em C# 

Como o .NET não possui uma classe `Graph`, nós o construímos combinando as duas estruturas mais poderosas: `Dictionary` e `List`.

## 1. A Lista de Adjacência (O Padrão Ouro)
A ideia é mapear um Nó (a Chave) para uma Lista de seus Vizinhos (os Valores).

```csharp
// declaração 
Dictionary<int, List<int>> grafo = new Dictionary<int, List<int>>();