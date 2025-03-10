namespace FlyweightDP
{
	// Concrete Flyweight (Shared Object)
	public class Character : ICharacter
	{
		private char symbol; // Intrinsic state (shared)

		public Character(char symbol)
		{
			this.symbol = symbol;
		}

		public void Display(int fontSize, string color)
		{
			Console.WriteLine($"Character: {symbol}, Font Size: {fontSize}, Color: {color}");
		}
	}
}
