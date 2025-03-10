using DecoratorDP;

Console.WriteLine("Without Logging:");
IDataRepository repository = new DataRepository();
repository.FetchData();

Console.WriteLine("\nWith Logging:");
IDataRepository loggingRepository = new LoggingRepositoryDecorator(repository);
loggingRepository.FetchData();