using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Freeverb3VST_Freeverb")]
public class Freeverb3VST_Freeverb : VSTFilter {

	public readonly string pluginPath = "Freeverb3VST_Freeverb.dll";

	public override void resetToDefaults() {
		SRCFacto = 0.25f;
		Wet = 0.2f;
		Dry = 0.4f;
		Damp = 0.2f;
		RoomSize = 0.7f;
		Width = 1.0f;
		Delay = 0.5f;
	}

	[Tooltip("1X  |  5X")]
	[Range(0.0f, 1.0f)]
	public float SRCFacto = 0.25f;
	private float lastSRCFacto = -1f;
	public readonly int SRCFactoIndex = 0;
	public readonly string SRCFactoLow = "1X";
	public readonly string SRCFactoHigh = "5X";

	[Tooltip("-oodB  |  9.542425dB")]
	[Range(0.0f, 1.0f)]
	public float Wet = 0.2f;
	private float lastWet = -1f;
	public readonly int WetIndex = 1;
	public readonly string WetLow = "-oodB";
	public readonly string WetHigh = "9.542425dB";

	[Tooltip("-oodB  |  6.020599dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 0.4f;
	private float lastDry = -1f;
	public readonly int DryIndex = 2;
	public readonly string DryLow = "-oodB";
	public readonly string DryHigh = "6.020599dB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float Damp = 0.2f;
	private float lastDamp = -1f;
	public readonly int DampIndex = 3;
	public readonly string DampLow = "0.000000%";
	public readonly string DampHigh = "100.0000%";

	[Tooltip("0.699999u  |  0.980000u")]
	[Range(0.0f, 1.0f)]
	public float RoomSize = 0.7f;
	private float lastRoomSize = -1f;
	public readonly int RoomSizeIndex = 4;
	public readonly string RoomSizeLow = "0.699999u";
	public readonly string RoomSizeHigh = "0.980000u";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float Width = 1.0f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 5;
	public readonly string WidthLow = "0.000000%";
	public readonly string WidthHigh = "100.0000%";

	[Tooltip("-500.000ms  |  500.0000ms")]
	[Range(0.0f, 1.0f)]
	public float Delay = 0.5f;
	private float lastDelay = -1f;
	public readonly int DelayIndex = 6;
	public readonly string DelayLow = "-500.000ms";
	public readonly string DelayHigh = "500.0000ms";

	public override string getFilterName() {
		return "./vst/Freeverb3VST_Freeverb.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(SRCFacto != lastSRCFacto) isUpdated = true;
		if(Wet != lastWet) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;
		if(Damp != lastDamp) isUpdated = true;
		if(RoomSize != lastRoomSize) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;
		if(Delay != lastDelay) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Freeverb3VST_Freeverb.dll");
		if(SRCFacto != lastSRCFacto) {
			client.sendPacket("parameter 0 "+SRCFacto);
			lastSRCFacto = SRCFacto;
		}
		if(Wet != lastWet) {
			client.sendPacket("parameter 1 "+Wet);
			lastWet = Wet;
		}
		if(Dry != lastDry) {
			client.sendPacket("parameter 2 "+Dry);
			lastDry = Dry;
		}
		if(Damp != lastDamp) {
			client.sendPacket("parameter 3 "+Damp);
			lastDamp = Damp;
		}
		if(RoomSize != lastRoomSize) {
			client.sendPacket("parameter 4 "+RoomSize);
			lastRoomSize = RoomSize;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 5 "+Width);
			lastWidth = Width;
		}
		if(Delay != lastDelay) {
			client.sendPacket("parameter 6 "+Delay);
			lastDelay = Delay;
		}
	}

	public override void resetStateTrackers() {
		lastSRCFacto = -1f;
		lastWet = -1f;
		lastDry = -1f;
		lastDamp = -1f;
		lastRoomSize = -1f;
		lastWidth = -1f;
		lastDelay = -1f;
	}
}
