namespace BridgeDP
{
	public class Radio : IDevice
	{
		private bool isOn = false;
		private int volume = 30;
		private int channel = 1;

		public bool IsEnabled() => isOn;

		public void Enable()
		{
			isOn = true;
			Console.WriteLine("Radio is turned ON.");
		}

		public void Disable()
		{
			isOn = false;
			Console.WriteLine("Radio is turned OFF.");
		}

		public int GetVolume() => volume;

		public void SetVolume(int percent)
		{
			volume = Math.Clamp(percent, 0, 100);
			Console.WriteLine($"Radio volume set to {volume}%.");
		}

		public int GetChannel() => channel;

		public void SetChannel(int channel)
		{
			this.channel = channel;
			Console.WriteLine($"Radio channel set to {channel}.");
		}
	}
}
