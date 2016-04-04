using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/PoorPlate")]
public class PoorPlate : VSTFilter {

	public readonly string pluginPath = "Poor Plate.dll";

	public override void resetToDefaults() {
		Dry = 0.5f;
		Wet = 0.1f;
		PreDelay = 0.0f;
		Decay = 0.5555556f;
		DecDiff = 0.9f;
		InDiff = 1.0f;
		Bandwidt = 0.7497497f;
		HFDamp = 0.4994995f;
	}

	[Tooltip("-oodB  |  0.000000dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 0.5f;
	private float lastDry = -1f;
	public readonly int DryIndex = 0;
	public readonly string DryLow = "-oodB";
	public readonly string DryHigh = "0.000000dB";

	[Tooltip("-oodB  |  0.000000dB")]
	[Range(0.0f, 1.0f)]
	public float Wet = 0.1f;
	private float lastWet = -1f;
	public readonly int WetIndex = 1;
	public readonly string WetLow = "-oodB";
	public readonly string WetHigh = "0.000000dB";

	[Tooltip("0.000000ms  |  120.0000ms")]
	[Range(0.0f, 1.0f)]
	public float PreDelay = 0.0f;
	private float lastPreDelay = -1f;
	public readonly int PreDelayIndex = 2;
	public readonly string PreDelayLow = "0.000000ms";
	public readonly string PreDelayHigh = "120.0000ms";

	[Tooltip("0.000000  |  0.899999")]
	[Range(0.0f, 1.0f)]
	public float Decay = 0.5555556f;
	private float lastDecay = -1f;
	public readonly int DecayIndex = 3;
	public readonly string DecayLow = "0.000000";
	public readonly string DecayHigh = "0.899999";

	[Tooltip("0.250000  |  0.750000")]
	[Range(0.0f, 1.0f)]
	public float DecDiff = 0.9f;
	private float lastDecDiff = -1f;
	public readonly int DecDiffIndex = 4;
	public readonly string DecDiffLow = "0.250000";
	public readonly string DecDiffHigh = "0.750000";

	[Tooltip("0.250000  |  0.750000")]
	[Range(0.0f, 1.0f)]
	public float InDiff = 1.0f;
	private float lastInDiff = -1f;
	public readonly int InDiffIndex = 5;
	public readonly string InDiffLow = "0.250000";
	public readonly string InDiffHigh = "0.750000";

	[Tooltip("20.00000Hz  |  20000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float Bandwidt = 0.7497497f;
	private float lastBandwidt = -1f;
	public readonly int BandwidtIndex = 6;
	public readonly string BandwidtLow = "20.00000Hz";
	public readonly string BandwidtHigh = "20000.00Hz";

	[Tooltip("20.00000Hz  |  20000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float HFDamp = 0.4994995f;
	private float lastHFDamp = -1f;
	public readonly int HFDampIndex = 7;
	public readonly string HFDampLow = "20.00000Hz";
	public readonly string HFDampHigh = "20000.00Hz";

	public override string getFilterName() {
		return "./vst/Poor Plate.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Dry != lastDry) isUpdated = true;
		if(Wet != lastWet) isUpdated = true;
		if(PreDelay != lastPreDelay) isUpdated = true;
		if(Decay != lastDecay) isUpdated = true;
		if(DecDiff != lastDecDiff) isUpdated = true;
		if(InDiff != lastInDiff) isUpdated = true;
		if(Bandwidt != lastBandwidt) isUpdated = true;
		if(HFDamp != lastHFDamp) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Poor Plate.dll");
		if(Dry != lastDry) {
			client.sendPacket("parameter 0 "+Dry);
			lastDry = Dry;
		}
		if(Wet != lastWet) {
			client.sendPacket("parameter 1 "+Wet);
			lastWet = Wet;
		}
		if(PreDelay != lastPreDelay) {
			client.sendPacket("parameter 2 "+PreDelay);
			lastPreDelay = PreDelay;
		}
		if(Decay != lastDecay) {
			client.sendPacket("parameter 3 "+Decay);
			lastDecay = Decay;
		}
		if(DecDiff != lastDecDiff) {
			client.sendPacket("parameter 4 "+DecDiff);
			lastDecDiff = DecDiff;
		}
		if(InDiff != lastInDiff) {
			client.sendPacket("parameter 5 "+InDiff);
			lastInDiff = InDiff;
		}
		if(Bandwidt != lastBandwidt) {
			client.sendPacket("parameter 6 "+Bandwidt);
			lastBandwidt = Bandwidt;
		}
		if(HFDamp != lastHFDamp) {
			client.sendPacket("parameter 7 "+HFDamp);
			lastHFDamp = HFDamp;
		}
	}

	public override void resetStateTrackers() {
		lastDry = -1f;
		lastWet = -1f;
		lastPreDelay = -1f;
		lastDecay = -1f;
		lastDecDiff = -1f;
		lastInDiff = -1f;
		lastBandwidt = -1f;
		lastHFDamp = -1f;
	}
}
