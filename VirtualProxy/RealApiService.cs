namespace VirtualProxy
{
	public class RealApiService : IApiService
	{
		public string GetData(string endpoint)
		{
			Console.WriteLine($"Fetching data from API: {endpoint}");
			return $"Response from {endpoint}";
		}
	}
}
