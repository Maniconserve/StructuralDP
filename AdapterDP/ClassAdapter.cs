namespace AdapterDP
{
	// Class Adapter (Converts string[] to Queue<string>)
	public class ClassAdapter : ThirdPartyLogger, ILogSystem
	{
		public void LogMessages(string[] logs)
		{
			Queue<string> logQueue = new Queue<string>(logs); // Convert array to queue
			LogQueue(logQueue);
		}
	}
}
