namespace FacadeDP
{
	// Facade Class
	public class OrderFacade
	{
		private InventorySystem _inventory;
		private PaymentSystem _payment;
		private ShippingSystem _shipping;

		public OrderFacade()
		{
			_inventory = new InventorySystem();
			_payment = new PaymentSystem();
			_shipping = new ShippingSystem();
		}

		public void PlaceOrder(string product, string cardNumber, double amount)
		{
			Console.WriteLine("\n---- Order Processing Started ----");

			if (!_inventory.CheckStock(product))
			{
				Console.WriteLine("Product is out of stock.");
				return;
			}

			if (!_payment.ProcessPayment(cardNumber, amount))
			{
				Console.WriteLine("Payment failed.");
				return;
			}

			_shipping.ShipProduct(product);
			Console.WriteLine("Order placed successfully!\n");
		}
	}
}
