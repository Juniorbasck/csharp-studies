# 📚 Lists em C# (`List<T>`) - Dinamismo e Poder

Diferente dos Arrays, as Lists são **dinâmicas**. Elas crescem conforme a necessidade. No C#, a `List<T>` é na verdade um "wrapper" em volta de um Array. Quando a lista enche, o C# cria um novo array com o dobro do tamanho e copia os elementos.

## 1. Array vs. List: Qual escolher?

| Característica | Array (`T[]`) | List (`List<T>`) |
| :--- | :--- | :--- |
| **Tamanho** | Fixo (Imutável) | Dinâmico (Cresce sozinho) |
| **Performance** | Melhor (Menos overhead) | Ligeiramente menor (Devido ao redimensionamento) |
| **Inserção** | Difícil (Exige criar novo array) | Fácil (`.Add()`, `.Insert()`) |
| **Uso Ideal** | Quando você sabe o tamanho exato | Quando os dados chegam de forma imprevisível |

## 2. Declaração e Inicialização
```csharp
// Lista vazia
List<string> nomes = new List<string>();

// Lista com valores iniciais (Collection Initializer)
List<int> metasDeTreino = new List<int> { 10, 20, 30 };