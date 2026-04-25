# 📚 Strings em C# - Manipulação e Alta Performance

Em C#, uma `string` é essencialmente um array de caracteres (`char[]`) somente leitura. Qualquer operação que pareça modificar uma string (como `.Replace()` ou concatenação com `+`) na verdade aloca um novo espaço na memória.

## 1. Operações Básicas e Conversões
transformar a string em um array de caracteres para poder manipular os índices livremente com a técnica de *Two Pointers*.

```csharp
string texto = "Engenharia";

// Tamanho (note que não tem parênteses, é uma propriedade como no Array)
int tamanho = texto.Length; 

// Acesso por índice (Somente leitura!)
char primeiraLetra = texto[0];

// String para Array de Caracteres (Essencial para algoritmos In-Place)
char[] letras = texto.ToCharArray();

// Array de Caracteres de volta para String
string novoTexto = new string(letras);