using RemoteProxyDP;

Console.WriteLine("Creating remote calculator proxy...");
ICalculatorService calculator = new CalculatorProxy();

Console.WriteLine("\nPerforming operations using remote service:");
Console.WriteLine($"10 + 5 = {calculator.Add(10, 5)}");
Console.WriteLine($"6 * 4 = {calculator.Multiply(6, 4)}");