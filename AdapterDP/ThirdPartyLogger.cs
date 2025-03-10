namespace AdapterDP
{
	// Adaptee (Third-party logging system that requires Queue<string>)
	public class ThirdPartyLogger
	{
		public void LogQueue(Queue<string> logQueue)
		{
			Console.WriteLine("Logging messages via Third-party Logger:");
			while (logQueue.Count > 0)
			{
				Console.WriteLine($"- {logQueue.Dequeue()}");
			}
		}
	}
}
