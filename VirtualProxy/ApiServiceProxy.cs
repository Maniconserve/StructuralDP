namespace VirtualProxy
{
	public class ApiServiceProxy : IApiService
	{
		private RealApiService _realApiService;
		private Dictionary<string, string> _cache = new Dictionary<string, string>();

		public string GetData(string endpoint)
		{
			if (_cache.ContainsKey(endpoint))
			{
				Console.WriteLine($"Returning cached data for: {endpoint}");
				return _cache[endpoint];
			}

			if (_realApiService == null)
			{
				_realApiService = new RealApiService();
			}

			string response = _realApiService.GetData(endpoint);
			_cache[endpoint] = response; // Store response in cache
			return response;
		}
	}
}
