namespace FacadeDP
{
	// Subsystem 1: Inventory System
	public class InventorySystem
	{
		public bool CheckStock(string product)
		{
			Console.WriteLine($"Checking stock for {product}...");
			return true; // Assume product is always in stock
		}
	}
}
