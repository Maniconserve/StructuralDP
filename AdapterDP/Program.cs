namespace AdapterDP
{
	class Program
	{
		static void Main()
		{
			//Class Adapter Pattern 
			ILogSystem logger1 = new ClassAdapter();
			string[] logMessages = { "Error: Disk full", "Warning: CPU overload", "Info: System restarted" };
			logger1.LogMessages(logMessages);

			//Object Adapter Pattern
			ThirdPartyLogger thirdPartyLogger = new ThirdPartyLogger();
			ILogSystem logger2 = new ObjectAdapter(thirdPartyLogger);
			logger2.LogMessages(logMessages);
		}
	}
}