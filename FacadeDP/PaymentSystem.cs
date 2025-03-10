namespace FacadeDP
{
	// Subsystem 2: Payment System
	public class PaymentSystem
	{
		public bool ProcessPayment(string cardNumber, double amount)
		{
			Console.WriteLine($"Processing payment of ${amount} using card {cardNumber}...");
			return true; // Assume payment is successful
		}
	}
}
