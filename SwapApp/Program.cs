namespace SwapApp
{
	internal class Program
	{
		/// <summary>
		/// Swap two integers using pass by value, pass by reference, and tuple return value. 
		/// The first method does not swap the values of a and b in the caller method, while the second method modifies the original variables. 
		/// The third method returns a tuple with the swapped values.
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			int a = 1;
			int b = 2;
			Swap(a, b);
			Console.WriteLine($"a: {a}, b: {b}");
		}

		/// <summary>
		/// Pass by value - does not swap the values of a and b in the caller method.
		/// </summary>
		/// <param name="a">the first input num</param>
		/// <param name="b">the second input num</param>
		public static void Swap(int a, int b)
		{
			int tmp = a;
			a = b;
			b = tmp;
		}

		/// <summary>
		///  The original variables are modified.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static void SwapRef(ref int a, ref int b)
		{
			int tmp = a;
			a = b;
			b = tmp;
		}

		public static (int, int) SwapWithTuple(int a, int b)
		{
			return (b, a);
		}
	}
}