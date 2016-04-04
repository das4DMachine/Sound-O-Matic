using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/BCGain3VSTMono")]
public class BCGain3VSTMono : VSTFilter {

	public readonly string pluginPath = "BC Gain 3 VST(Mono).dll";

	public override void resetToDefaults() {
		Bypass = 0.0f;
		Gain = 0.5f;
	}

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Bypass = 0.0f;
	private float lastBypass = -1f;
	public readonly int BypassIndex = 0;
	public readonly string BypassLow = "Off";
	public readonly string BypassHigh = "On";

	[Tooltip("-60.0dB  |  +60.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.5f;
	private float lastGain = -1f;
	public readonly int GainIndex = 1;
	public readonly string GainLow = "-60.0dB";
	public readonly string GainHigh = "+60.0dB";

	public override string getFilterName() {
		return "./vst/BC Gain 3 VST(Mono).dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Bypass != lastBypass) isUpdated = true;
		if(Gain != lastGain) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/BC Gain 3 VST(Mono).dll");
		if(Bypass != lastBypass) {
			client.sendPacket("parameter 0 "+Bypass);
			lastBypass = Bypass;
		}
		if(Gain != lastGain) {
			client.sendPacket("parameter 1 "+Gain);
			lastGain = Gain;
		}
	}

	public override void resetStateTrackers() {
		lastBypass = -1f;
		lastGain = -1f;
	}
}
