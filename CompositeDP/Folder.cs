namespace CompositeDP
{
	// Composite Class (Folder)
	public class Folder : IComponent
	{
		private string name;
		private List<IComponent> components = new List<IComponent>();

		public Folder(string name)
		{
			this.name = name;
		}

		public void Add(IComponent component)
		{
			components.Add(component);
		}

		public void Remove(IComponent component)
		{
			components.Remove(component);
		}

		public void Display(int depth)
		{
			Console.WriteLine(new string('-', depth) + " Folder: " + name);
			foreach (var component in components)
			{
				component.Display(depth + 2);
			}
		}
	}
}
