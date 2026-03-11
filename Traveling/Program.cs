namespace Traveling
{
	/// <summary>
	/// Reads fuel consumption (liters/100 km) and distance (km) from the user, 
	/// calculates the total fuel needed for the trip and the total cost, and 
	/// prints the result formatted to 2 decimal places.
	/// </summary>
	internal class Program
	{

		static void Main(string[] args)
		{
			const double FUEL_PRICE = 1.85D;
			double consumption = 0.0;
			double distance = 0.0;
			double litersNeeded = 0.0;
			double totalCost = 0.0;

			Console.WriteLine("Please insert consumption (liters/100km)");
			if (!double.TryParse(Console.ReadLine(), out consumption) || consumption <= 0)
			{
				Console.WriteLine("Invalid input for consumption. Please enter a positive number.");
				return;
			}
				Console.WriteLine("Please insert distance (km)");
				if (!double.TryParse(Console.ReadLine(), out distance) || distance <= 0)
				{
					Console.WriteLine("Invalid input for distance. Please enter a positive number.");
					return;
				}

				litersNeeded = Math.Round(consumption * distance / 100, 2);
				totalCost = Math.Round(litersNeeded * FUEL_PRICE, 2);

				Console.WriteLine($"{"Consumption:",-25} {consumption:N2}");
				Console.WriteLine($"{"Distance:",-25} {distance:N2}");
				Console.WriteLine($"{"Fuel price:",-25} {FUEL_PRICE:N2}");
				Console.WriteLine($"{"Liters needed:",-25} {litersNeeded:N2}");
				Console.WriteLine($"{"Total cost:",-25} {totalCost:N2}");
			}
		}
	}