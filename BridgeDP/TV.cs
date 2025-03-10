namespace BridgeDP
{
	public class TV : IDevice
	{
		private bool isOn = false;
		private int volume = 50;
		private int channel = 1;

		public bool IsEnabled() => isOn;

		public void Enable()
		{
			isOn = true;
			Console.WriteLine("TV is turned ON.");
		}

		public void Disable()
		{
			isOn = false;
			Console.WriteLine("TV is turned OFF.");
		}

		public int GetVolume() => volume;

		public void SetVolume(int percent)
		{
			volume = Math.Clamp(percent, 0, 100);
			Console.WriteLine($"TV volume set to {volume}%.");
		}

		public int GetChannel() => channel;

		public void SetChannel(int channel)
		{
			this.channel = channel;
			Console.WriteLine($"TV channel set to {channel}.");
		}
	}


}
