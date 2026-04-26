public class Program
{
	public static void Main(string[] args)
	{
		TreeNode root = new TreeNode(5, 
			new TreeNode(3, 
				new TreeNode(2, 
					new TreeNode(4))
				)
			);
		
		Console.WriteLine("Travessia In-Order (Deve imprimir em ordem crescente):");
		InOrder(root);
		Console.WriteLine();
		PreOrder(root);
		Console.WriteLine();
		PostOrder(root);
		Console.WriteLine();
		LeverOrder(root);
	}

	public static void InOrder(TreeNode root)
	{
		if (root == null) return;
		
		InOrder(root.left); // 1. Vai tudo para a esquerda
		Console.Write(root.val + " "); // 2. Processa o nó atual
		InOrder(root.right); // 3. Vai tudo para a direita
			
	}

	public static void PreOrder(TreeNode root)
	{
		if (root == null) return;
		
		Console.Write(root.val + " "); // Processa primeiro!
		PreOrder(root.left);
		PreOrder(root.right);
	}
	
	//Útil para deletar uma árvore (você apaga as folhas antes de apagar a raiz) ou calcular alturas (bottom-up).
	public static void PostOrder(TreeNode root) 
	{
		if (root == null) return;
    
		PostOrder(root.left);
		PostOrder(root.right);
		Console.WriteLine(root.val); // Processa por último!
	}

	public static void LeverOrder(TreeNode root)
	{
		if (root == null) return;
		
		Queue<TreeNode> queue = new Queue<TreeNode>();
		
		queue.Enqueue(root);

		while (queue.Count > 0)
		{
			TreeNode atual = queue.Dequeue();
			Console.WriteLine(atual.val);
			
			if (atual.left != null) queue.Enqueue(atual.left);
			if (atual.right != null) queue.Enqueue(atual.right);
			
		}
	}
	
	

	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;

		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}
}