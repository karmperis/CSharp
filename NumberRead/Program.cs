namespace NumberRead
{
	/// <summary>
	/// Safe reading of float and double numbers from the console using TryParse method to handle invalid input gracefully.
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			float floatNum = 0F;
			double doubleNum = 0D;

			Console.WriteLine("Enter a float number:");

			if(!float.TryParse(Console.ReadLine(), out floatNum))
			{
				Console.WriteLine("Invalid input for float number.");
				return;
			}

			if(!double.TryParse(Console.ReadLine(), out doubleNum))
			{
				Console.WriteLine("Invalid input for double number.");
				return;
			}

			Console.WriteLine($"You entered float: {floatNum,6:N2}");
			Console.WriteLine($"You entered double: {doubleNum,6:N2}");

		}
	}
}