namespace DecoratorDP
{
	public abstract class RepositoryDecorator : IDataRepository
	{
		protected IDataRepository _repository;

		public RepositoryDecorator(IDataRepository repository)
		{
			_repository = repository;
		}

		public virtual void FetchData()
		{
			_repository.FetchData();
		}
	}

}
