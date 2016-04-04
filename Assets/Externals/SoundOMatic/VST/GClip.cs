using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GClip")]
public class GClip : VSTFilter {

	public readonly string pluginPath = "GClip.dll";

	public override void resetToDefaults() {
		Gain = 0.0f;
		Clip = 1.0f;
		Softness = 0.0f;
		Oversmp = 0.0f;
	}

	[Tooltip("0.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.0f;
	private float lastGain = -1f;
	public readonly int GainIndex = 0;
	public readonly string GainLow = "0.0dB";
	public readonly string GainHigh = "12.0dB";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Clip = 1.0f;
	private float lastClip = -1f;
	public readonly int ClipIndex = 1;
	public readonly string ClipLow = "0%";
	public readonly string ClipHigh = "100%";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Softness = 0.0f;
	private float lastSoftness = -1f;
	public readonly int SoftnessIndex = 2;
	public readonly string SoftnessLow = "0%";
	public readonly string SoftnessHigh = "100%";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Oversmp = 0.0f;
	private float lastOversmp = -1f;
	public readonly int OversmpIndex = 3;
	public readonly string OversmpLow = "Off";
	public readonly string OversmpHigh = "On";

	public override string getFilterName() {
		return "./vst/GClip.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;
		if(Clip != lastClip) isUpdated = true;
		if(Softness != lastSoftness) isUpdated = true;
		if(Oversmp != lastOversmp) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GClip.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
		if(Clip != lastClip) {
			client.sendPacket("parameter 1 "+Clip);
			lastClip = Clip;
		}
		if(Softness != lastSoftness) {
			client.sendPacket("parameter 2 "+Softness);
			lastSoftness = Softness;
		}
		if(Oversmp != lastOversmp) {
			client.sendPacket("parameter 3 "+Oversmp);
			lastOversmp = Oversmp;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
		lastClip = -1f;
		lastSoftness = -1f;
		lastOversmp = -1f;
	}
}
