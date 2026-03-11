namespace FormatExceptionApp
{
	/// <summary>
	/// Example of FormatException when parsing a string to an integer. The user is prompted to enter an integer, and if the input is not a valid integer, 
	/// a FormatException is caught and its message is displayed. 
	/// The loop continues until the user enters 0 to quit the program.
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			int num = 0;

			while (true)
			{
				try
				{
					Console.WriteLine("Please insert an integer (0 for Quit)");
					num = int.Parse(Console.ReadLine()!);
					Console.WriteLine($"Insert integer: {num}");
					if (num == 0) break;
				}
				catch (FormatException e)
				{
					Console.WriteLine(e.Message);
				}
			}
		}
	}
}