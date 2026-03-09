namespace ProductsVat
{
	internal class Program
	{
		/// <summary>
		/// Reads a product price from the console, calculates the VAT (24%) and the
		/// total price including VAT, and prints the results formatted to 2 decimal places.
		/// </summary>
		static void Main(string[] args)
		{
			const double VAT_RATE = 0.24D;

			double price = 0D;
			double vat = 0D;
			double total = 0D;

			Console.WriteLine("Please insert the product price");
			if (!double.TryParse(Console.ReadLine(), out price) || price < 0)
			{
				Console.WriteLine("Invalid input for product price. Please enter a non-negative number.");
				return;
			}

			vat = price * VAT_RATE;
			total = price + vat;

			Console.OutputEncoding = System.Text.Encoding.UTF8; // Ensure correct display of the Euro symbol
			Console.WriteLine($"{"Price without VAT:",-20} {price:N2} \u20AC");
			Console.WriteLine($"{"VAT(24%):",-20} {vat:N2} \u20AC");
			Console.WriteLine($"{"Price with VAT:",-20} {total:N2} \u20AC");
		}
	}
}