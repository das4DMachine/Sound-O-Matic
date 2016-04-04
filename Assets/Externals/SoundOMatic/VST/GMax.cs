using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GMax")]
public class GMax : VSTFilter {

	public readonly string pluginPath = "GMax.dll";

	public override void resetToDefaults() {
		Gain = 0.16666667f;
		Ceiling = 0.95f;
		Release = 0.23076923f;
	}

	[Tooltip("0.0dB  |  24.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.16666667f;
	private float lastGain = -1f;
	public readonly int GainIndex = 0;
	public readonly string GainLow = "0.0dB";
	public readonly string GainHigh = "24.0dB";

	[Tooltip("-6.0dB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Ceiling = 0.95f;
	private float lastCeiling = -1f;
	public readonly int CeilingIndex = 1;
	public readonly string CeilingLow = "-6.0dB";
	public readonly string CeilingHigh = "0.0dB";

	[Tooltip("0.05s  |  2.00s")]
	[Range(0.0f, 1.0f)]
	public float Release = 0.23076923f;
	private float lastRelease = -1f;
	public readonly int ReleaseIndex = 2;
	public readonly string ReleaseLow = "0.05s";
	public readonly string ReleaseHigh = "2.00s";

	public override string getFilterName() {
		return "./vst/GMax.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;
		if(Ceiling != lastCeiling) isUpdated = true;
		if(Release != lastRelease) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GMax.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
		if(Ceiling != lastCeiling) {
			client.sendPacket("parameter 1 "+Ceiling);
			lastCeiling = Ceiling;
		}
		if(Release != lastRelease) {
			client.sendPacket("parameter 2 "+Release);
			lastRelease = Release;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
		lastCeiling = -1f;
		lastRelease = -1f;
	}
}
