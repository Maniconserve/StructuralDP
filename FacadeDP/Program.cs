namespace FacadeDP
{
	class Program
	{
		static void Main()
		{
			OrderFacade orderFacade = new OrderFacade();

			// Client only interacts with the Facade
			orderFacade.PlaceOrder("Laptop", "1234-5678-9876", 1200.00);
		}
	}
}