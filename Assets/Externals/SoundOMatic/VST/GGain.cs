using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GGain")]
public class GGain : VSTFilter {

	public readonly string pluginPath = "GGain.dll";

	public override void resetToDefaults() {
		Gain = 0.5f;
	}

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.5f;
	private float lastGain = -1f;
	public readonly int GainIndex = 0;
	public readonly string GainLow = "-12.0dB";
	public readonly string GainHigh = "12.0dB";

	public override string getFilterName() {
		return "./vst/GGain.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GGain.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
	}
}
