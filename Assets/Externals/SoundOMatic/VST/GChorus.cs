using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GChorus")]
public class GChorus : VSTFilter {

	public readonly string pluginPath = "GChorus.dll";

	public override void resetToDefaults() {
		Depth = 0.09090909f;
		Freq = 0.451545f;
		RPhase = 0.0f;
		Mix = 0.3f;
	}

	[Tooltip("1cents  |  100cents")]
	[Range(0.0f, 1.0f)]
	public float Depth = 0.09090909f;
	private float lastDepth = -1f;
	public readonly int DepthIndex = 0;
	public readonly string DepthLow = "1cents";
	public readonly string DepthHigh = "100cents";

	[Tooltip("0.10Hz  |  10.00Hz")]
	[Range(0.0f, 1.0f)]
	public float Freq = 0.451545f;
	private float lastFreq = -1f;
	public readonly int FreqIndex = 1;
	public readonly string FreqLow = "0.10Hz";
	public readonly string FreqHigh = "10.00Hz";

	[Tooltip("0deg  |  180deg")]
	[Range(0.0f, 1.0f)]
	public float RPhase = 0.0f;
	private float lastRPhase = -1f;
	public readonly int RPhaseIndex = 2;
	public readonly string RPhaseLow = "0deg";
	public readonly string RPhaseHigh = "180deg";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Mix = 0.3f;
	private float lastMix = -1f;
	public readonly int MixIndex = 3;
	public readonly string MixLow = "0%";
	public readonly string MixHigh = "100%";

	public override string getFilterName() {
		return "./vst/GChorus.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Depth != lastDepth) isUpdated = true;
		if(Freq != lastFreq) isUpdated = true;
		if(RPhase != lastRPhase) isUpdated = true;
		if(Mix != lastMix) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GChorus.dll");
		if(Depth != lastDepth) {
			client.sendPacket("parameter 0 "+Depth);
			lastDepth = Depth;
		}
		if(Freq != lastFreq) {
			client.sendPacket("parameter 1 "+Freq);
			lastFreq = Freq;
		}
		if(RPhase != lastRPhase) {
			client.sendPacket("parameter 2 "+RPhase);
			lastRPhase = RPhase;
		}
		if(Mix != lastMix) {
			client.sendPacket("parameter 3 "+Mix);
			lastMix = Mix;
		}
	}

	public override void resetStateTrackers() {
		lastDepth = -1f;
		lastFreq = -1f;
		lastRPhase = -1f;
		lastMix = -1f;
	}
}
