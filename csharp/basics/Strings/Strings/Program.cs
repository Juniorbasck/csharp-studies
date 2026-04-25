public class Program
{
    public static void Main(string[] args)
    {
        string texto = "teste";
        
        int tamanho = texto.Length;
        
        char primeiraLetra = texto[0];
        
        // string para array
        char[] letras = texto.ToCharArray();

        string frase = "frase grande";
        
        string[] palavras = frase.Split(' ');

        Console.WriteLine(palavras[0]);
        
        foreach (var palavra in palavras)
        {
            Console.WriteLine(palavra);
        }
        


    }
}