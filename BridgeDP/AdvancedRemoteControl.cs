namespace BridgeDP
{
	public class AdvancedRemoteControl : RemoteControl
	{
		public AdvancedRemoteControl(IDevice device) : base(device) { }

		public void Mute()
		{
			Console.WriteLine("Muting the device.");
			device.SetVolume(0);
		}
	}
}
