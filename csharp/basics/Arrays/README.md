# 📚 Arrays em C# 

Na memória, um Array é um bloco contínuo. Isso significa que o acesso a qualquer elemento pelo índice é extremamente rápido **O(1)**, mas o seu tamanho é **imutável** após a criação. 

## 1. Declaração e Inicialização

```csharp
// 1. Tamanho fixo, valores padrão (0 para int)
int[] arr = new int[5]; 

// 2. Inicialização rápida com valores (Muito útil para criar mock de dados no teste de mesa)
int[] nums = new int[] { 1, 2, 3, 4, 5 };
// Ou ainda mais curto:
int[] quickNums = { 1, 2, 3, 4, 5 };