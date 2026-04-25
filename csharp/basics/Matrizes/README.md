# 📚 Matrizes em C# - O Campo de Batalha (Grids e Grafos)

Em C#, temos duas formas de representar matrizes 2D. É vital saber a diferença.

## 1. O Array Multidimensional (Retangular)
É um bloco único na memória. Todas as linhas têm obrigatoriamente o mesmo número de colunas.
```csharp
// Declaração (linhas, colunas)
int[,] grid = new int[3, 4]; 

// Atribuição e Acesso
grid[0, 0] = 1;
int valor = grid[0, 0];

// Pegando o tamanho
int linhas = grid.GetLength(0);
int colunas = grid.GetLength(1);