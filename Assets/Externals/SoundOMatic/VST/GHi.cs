using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GHi")]
public class GHi : VSTFilter {

	public readonly string pluginPath = "GHi.dll";

	public override void resetToDefaults() {
		Gain = 0.5f;
		CutOff = 0.0f;
		Res = 0.0f;
	}

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.5f;
	private float lastGain = -1f;
	public readonly int GainIndex = 0;
	public readonly string GainLow = "-12.0dB";
	public readonly string GainHigh = "12.0dB";

	[Tooltip("20Hz  |  20000Hz")]
	[Range(0.0f, 1.0f)]
	public float CutOff = 0.0f;
	private float lastCutOff = -1f;
	public readonly int CutOffIndex = 1;
	public readonly string CutOffLow = "20Hz";
	public readonly string CutOffHigh = "20000Hz";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Res = 0.0f;
	private float lastRes = -1f;
	public readonly int ResIndex = 2;
	public readonly string ResLow = "0%";
	public readonly string ResHigh = "100%";

	public override string getFilterName() {
		return "./vst/GHi.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;
		if(CutOff != lastCutOff) isUpdated = true;
		if(Res != lastRes) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GHi.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
		if(CutOff != lastCutOff) {
			client.sendPacket("parameter 1 "+CutOff);
			lastCutOff = CutOff;
		}
		if(Res != lastRes) {
			client.sendPacket("parameter 2 "+Res);
			lastRes = Res;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
		lastCutOff = -1f;
		lastRes = -1f;
	}
}
