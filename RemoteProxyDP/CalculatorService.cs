namespace RemoteProxyDP
{
	public class CalculatorService : ICalculatorService
	{
		public int Add(int a, int b)
		{
			Console.WriteLine($"Performing Addition: {a} + {b}");
			return a + b;
		}

		public int Multiply(int a, int b)
		{
			Console.WriteLine($"Performing Multiplication: {a} * {b}");
			return a * b;
		}
	}
}
