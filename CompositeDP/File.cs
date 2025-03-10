namespace CompositeDP
{
	// Leaf Class (File)
	public class File : IComponent
	{
		private string name;

		public File(string name)
		{
			this.name = name;
		}

		public void Display(int depth)
		{
			Console.WriteLine(new string('-', depth) + " File: " + name);
		}
	}

}
