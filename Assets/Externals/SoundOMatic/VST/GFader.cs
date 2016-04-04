using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GFader")]
public class GFader : VSTFilter {

	public readonly string pluginPath = "GFader.dll";

	public override void resetToDefaults() {
		Gain = 1.0f;
	}

	[Tooltip("-InfdB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 1.0f;
	private float lastGain = -1f;
	public readonly int GainIndex = 0;
	public readonly string GainLow = "-InfdB";
	public readonly string GainHigh = "0.0dB";

	public override string getFilterName() {
		return "./vst/GFader.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GFader.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
	}
}
