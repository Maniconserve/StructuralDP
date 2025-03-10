namespace AdapterDP
{
	// Object Adapter (Using Composition)
	public class ObjectAdapter : ILogSystem
	{
		private readonly ThirdPartyLogger _thirdPartyLogger;

		public ObjectAdapter(ThirdPartyLogger thirdPartyLogger)
		{
			_thirdPartyLogger = thirdPartyLogger;
		}

		public void LogMessages(string[] logs)
		{
			Queue<string> logQueue = new Queue<string>(logs); // Convert array to queue
			_thirdPartyLogger.LogQueue(logQueue);
		}
	}
}
