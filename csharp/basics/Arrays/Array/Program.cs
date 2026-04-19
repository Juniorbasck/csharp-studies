public class Program{
	public static void Main(string[] args){
		
		int[] nums = new [] {1 ,2,3,4,5};
		
		int size = nums.Length;
		int first = nums[0];
		int last = nums[nums.Length - 1]; // - 1 para evitar IndexOutOfRangeException!

		for (int i = 0; i < nums.Length; i++)
		{
			Console.Write(nums[i]);
		}
		
		for(int i = nums.Length - 1; i >= 0; i--)
		{
			Console.Write(nums[i]);
		}
		
		//Quando o indice não importa, apenas o valor
		foreach (var num in nums)
		{
			Console.Write(num);
		}
		
		//Orderna o array IN-Place (modificando o array original) complexidade: 0(N log N)
		Array.Sort(nums);
		
		//Inverter as ordem dos elementos IN-PLACE,  complexiade 0(N)
		Array.Reverse(nums);
		
		//Preenchetodo o array com um valor específico (Útil para zerar arrays de visitados). Complexidade: O(N)
		Array.Fill(nums, -1);
	}
	
	public static void Fill(int[] nums)
	{
		Array.Fill(nums, -1);
	}
}