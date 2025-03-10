using VirtualProxy;

Console.WriteLine("Creating API proxy...");
IApiService api = new ApiServiceProxy();

Console.WriteLine("\nFirst API call:");
Console.WriteLine(api.GetData("https://api.example.com/data"));

Console.WriteLine("\nSecond API call (same endpoint):");
Console.WriteLine(api.GetData("https://api.example.com/data"));

Console.WriteLine("\nThird API call (different endpoint):");
Console.WriteLine(api.GetData("https://api.example.com/users"));