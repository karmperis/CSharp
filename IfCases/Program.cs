namespace IfCases
{
	/// <summary>
	/// This program demonstrates the use of if statements and the ternary operator.
	/// <summary>		
	internal class Program
	{
		static void Main(string[] args)
		{
			int age = 20;
			string name = "Alice";
			string nickname = "Ally";

			if (age > 18)
			{
				Console.WriteLine($"{name} is an adult.");
			}
			else
			{
				Console.WriteLine($"{name} is a minor.");
			}

			var status = age > 18 ? "adult" : "minor";
			Console.WriteLine(status);

			var displayName = name ?? "Unknown";
			Console.WriteLine(displayName);

			var length = name?.Length ?? 0;
			Console.WriteLine(length);
		}
	}
}