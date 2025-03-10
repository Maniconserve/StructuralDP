using System.Text.Json;

namespace RemoteProxyDP
{
	public class CalculatorProxy : ICalculatorService
	{
		private readonly HttpClient _httpClient;
		private readonly string _remoteServiceUrl = "http://remote-server.com/api/calculator"; // Remote API URL

		public CalculatorProxy()
		{
			_httpClient = new HttpClient();
		}

		public int Add(int a, int b)
		{
			return CallRemoteService("add", a, b).Result;
		}

		public int Multiply(int a, int b)
		{
			return CallRemoteService("multiply", a, b).Result;
		}

		private async Task<int> CallRemoteService(string operation, int a, int b)
		{
			string requestUrl = $"{_remoteServiceUrl}/{operation}?a={a}&b={b}";
			var response = await _httpClient.GetStringAsync(requestUrl);
			return JsonSerializer.Deserialize<int>(response);
		}
	}
}
