public class Program
{
    public static void Main(string[] args)
    {
        
        ///É um bloco único na memória. Todas as linhas têm obrigatoriamente o mesmo número de colunas.
        int[,] grid = new int[3, 4];
        
        // Inicialização rápida
        int[][] matriz = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {1, 2, 3},
            new int[] {1, 2, 3}
        };
        
        
        int numLinhas = matriz.Length;
        int numColunas = matriz[0].Length;
            
        //atribuição 
        matriz[0][0] = 99;

        for (int r = 0; r < numLinhas; r++)
        {
            for (int c = 0; c < numColunas; c++)
            {
                Console.WriteLine($"Posição [{r},{c}] = {matriz[r][c]}");
            }   
        }
        
        // Array de direções: { delta_linha, delta_coluna }
        // Cima (-1, 0), Direita (0, 1), Baixo (1, 0), Esquerda (0, -1)
        int[][] directions = new int[][] {
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 1, 0 },
            new int[] { 0, -1 }
        };
    }
}