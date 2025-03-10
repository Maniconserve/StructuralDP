// Using Basic Remote for TV
using BridgeDP;

Console.WriteLine("Using Basic Remote for TV:");
IDevice tv = new TV();
RemoteControl tvRemote = new RemoteControl(tv);
tvRemote.TogglePower();
tvRemote.VolumeUp();
tvRemote.ChannelUp();
tvRemote.TogglePower();

Console.WriteLine("\nUsing Advanced Remote for Radio:");
IDevice radio = new Radio();
AdvancedRemoteControl radioRemote = new AdvancedRemoteControl(radio);
radioRemote.TogglePower();
radioRemote.VolumeUp();
radioRemote.Mute();
radioRemote.TogglePower();