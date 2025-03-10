namespace DecoratorDP
{
	public class LoggingRepositoryDecorator : RepositoryDecorator
	{
		public LoggingRepositoryDecorator(IDataRepository repository) : base(repository) { }

		public override void FetchData()
		{
			Console.WriteLine("Logging: FetchData method called.");
			base.FetchData();
			Console.WriteLine("Logging: FetchData method execution completed.");
		}
	}
}
