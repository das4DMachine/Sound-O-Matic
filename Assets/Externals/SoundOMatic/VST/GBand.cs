using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GBand")]
public class GBand : VSTFilter {

	public readonly string pluginPath = "GBand.dll";

	public override void resetToDefaults() {
		Gain = 0.5f;
		LoCut = 0.0f;
		HiCut = 1.0f;
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
	public float LoCut = 0.0f;
	private float lastLoCut = -1f;
	public readonly int LoCutIndex = 1;
	public readonly string LoCutLow = "20Hz";
	public readonly string LoCutHigh = "20000Hz";

	[Tooltip("20Hz  |  20000Hz")]
	[Range(0.0f, 1.0f)]
	public float HiCut = 1.0f;
	private float lastHiCut = -1f;
	public readonly int HiCutIndex = 2;
	public readonly string HiCutLow = "20Hz";
	public readonly string HiCutHigh = "20000Hz";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Res = 0.0f;
	private float lastRes = -1f;
	public readonly int ResIndex = 3;
	public readonly string ResLow = "0%";
	public readonly string ResHigh = "100%";

	public override string getFilterName() {
		return "./vst/GBand.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;
		if(LoCut != lastLoCut) isUpdated = true;
		if(HiCut != lastHiCut) isUpdated = true;
		if(Res != lastRes) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GBand.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
		if(LoCut != lastLoCut) {
			client.sendPacket("parameter 1 "+LoCut);
			lastLoCut = LoCut;
		}
		if(HiCut != lastHiCut) {
			client.sendPacket("parameter 2 "+HiCut);
			lastHiCut = HiCut;
		}
		if(Res != lastRes) {
			client.sendPacket("parameter 3 "+Res);
			lastRes = Res;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
		lastLoCut = -1f;
		lastHiCut = -1f;
		lastRes = -1f;
	}
}
