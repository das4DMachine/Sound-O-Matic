using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GLFO")]
public class GLFO : VSTFilter {

	public readonly string pluginPath = "GLFO.dll";

	public override void resetToDefaults() {
		LFO1Wave = 0.0f;
		LFO1Freq = 0.0f;
		LFO1Phse = 0.2506964f;
		AmpDepth = 0.7f;
		LFO2Wave = 0.0f;
		LFO2Freq = 0.0f;
		LFO2Phse = 0.0f;
		PanDepth = 0.7f;
		LFO3Wave = 0.0f;
		LFO3Freq = 0.0f;
		LFO3Phse = 0.2506964f;
		FltDepth = 0.3f;
	}

	[Tooltip("Sine  |  Random")]
	[Range(0.0f, 1.0f)]
	public float LFO1Wave = 0.0f;
	private float lastLFO1Wave = -1f;
	public readonly int LFO1WaveIndex = 0;
	public readonly string LFO1WaveLow = "Sine";
	public readonly string LFO1WaveHigh = "Random";

	[Tooltip("1per bar  |  32per bar")]
	[Range(0.0f, 1.0f)]
	public float LFO1Freq = 0.0f;
	private float lastLFO1Freq = -1f;
	public readonly int LFO1FreqIndex = 1;
	public readonly string LFO1FreqLow = "1per bar";
	public readonly string LFO1FreqHigh = "32per bar";

	[Tooltip("0deg  |  359deg")]
	[Range(0.0f, 1.0f)]
	public float LFO1Phse = 0.2506964f;
	private float lastLFO1Phse = -1f;
	public readonly int LFO1PhseIndex = 2;
	public readonly string LFO1PhseLow = "0deg";
	public readonly string LFO1PhseHigh = "359deg";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float AmpDepth = 0.7f;
	private float lastAmpDepth = -1f;
	public readonly int AmpDepthIndex = 3;
	public readonly string AmpDepthLow = "0%";
	public readonly string AmpDepthHigh = "100%";

	[Tooltip("Sine  |  Random")]
	[Range(0.0f, 1.0f)]
	public float LFO2Wave = 0.0f;
	private float lastLFO2Wave = -1f;
	public readonly int LFO2WaveIndex = 4;
	public readonly string LFO2WaveLow = "Sine";
	public readonly string LFO2WaveHigh = "Random";

	[Tooltip("1per bar  |  32per bar")]
	[Range(0.0f, 1.0f)]
	public float LFO2Freq = 0.0f;
	private float lastLFO2Freq = -1f;
	public readonly int LFO2FreqIndex = 5;
	public readonly string LFO2FreqLow = "1per bar";
	public readonly string LFO2FreqHigh = "32per bar";

	[Tooltip("0deg  |  359deg")]
	[Range(0.0f, 1.0f)]
	public float LFO2Phse = 0.0f;
	private float lastLFO2Phse = -1f;
	public readonly int LFO2PhseIndex = 6;
	public readonly string LFO2PhseLow = "0deg";
	public readonly string LFO2PhseHigh = "359deg";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float PanDepth = 0.7f;
	private float lastPanDepth = -1f;
	public readonly int PanDepthIndex = 7;
	public readonly string PanDepthLow = "0%";
	public readonly string PanDepthHigh = "100%";

	[Tooltip("Sine  |  Random")]
	[Range(0.0f, 1.0f)]
	public float LFO3Wave = 0.0f;
	private float lastLFO3Wave = -1f;
	public readonly int LFO3WaveIndex = 8;
	public readonly string LFO3WaveLow = "Sine";
	public readonly string LFO3WaveHigh = "Random";

	[Tooltip("1per bar  |  32per bar")]
	[Range(0.0f, 1.0f)]
	public float LFO3Freq = 0.0f;
	private float lastLFO3Freq = -1f;
	public readonly int LFO3FreqIndex = 9;
	public readonly string LFO3FreqLow = "1per bar";
	public readonly string LFO3FreqHigh = "32per bar";

	[Tooltip("0deg  |  359deg")]
	[Range(0.0f, 1.0f)]
	public float LFO3Phse = 0.2506964f;
	private float lastLFO3Phse = -1f;
	public readonly int LFO3PhseIndex = 10;
	public readonly string LFO3PhseLow = "0deg";
	public readonly string LFO3PhseHigh = "359deg";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float FltDepth = 0.3f;
	private float lastFltDepth = -1f;
	public readonly int FltDepthIndex = 11;
	public readonly string FltDepthLow = "0%";
	public readonly string FltDepthHigh = "100%";

	public override string getFilterName() {
		return "./vst/GLFO.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(LFO1Wave != lastLFO1Wave) isUpdated = true;
		if(LFO1Freq != lastLFO1Freq) isUpdated = true;
		if(LFO1Phse != lastLFO1Phse) isUpdated = true;
		if(AmpDepth != lastAmpDepth) isUpdated = true;
		if(LFO2Wave != lastLFO2Wave) isUpdated = true;
		if(LFO2Freq != lastLFO2Freq) isUpdated = true;
		if(LFO2Phse != lastLFO2Phse) isUpdated = true;
		if(PanDepth != lastPanDepth) isUpdated = true;
		if(LFO3Wave != lastLFO3Wave) isUpdated = true;
		if(LFO3Freq != lastLFO3Freq) isUpdated = true;
		if(LFO3Phse != lastLFO3Phse) isUpdated = true;
		if(FltDepth != lastFltDepth) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GLFO.dll");
		if(LFO1Wave != lastLFO1Wave) {
			client.sendPacket("parameter 0 "+LFO1Wave);
			lastLFO1Wave = LFO1Wave;
		}
		if(LFO1Freq != lastLFO1Freq) {
			client.sendPacket("parameter 1 "+LFO1Freq);
			lastLFO1Freq = LFO1Freq;
		}
		if(LFO1Phse != lastLFO1Phse) {
			client.sendPacket("parameter 2 "+LFO1Phse);
			lastLFO1Phse = LFO1Phse;
		}
		if(AmpDepth != lastAmpDepth) {
			client.sendPacket("parameter 3 "+AmpDepth);
			lastAmpDepth = AmpDepth;
		}
		if(LFO2Wave != lastLFO2Wave) {
			client.sendPacket("parameter 4 "+LFO2Wave);
			lastLFO2Wave = LFO2Wave;
		}
		if(LFO2Freq != lastLFO2Freq) {
			client.sendPacket("parameter 5 "+LFO2Freq);
			lastLFO2Freq = LFO2Freq;
		}
		if(LFO2Phse != lastLFO2Phse) {
			client.sendPacket("parameter 6 "+LFO2Phse);
			lastLFO2Phse = LFO2Phse;
		}
		if(PanDepth != lastPanDepth) {
			client.sendPacket("parameter 7 "+PanDepth);
			lastPanDepth = PanDepth;
		}
		if(LFO3Wave != lastLFO3Wave) {
			client.sendPacket("parameter 8 "+LFO3Wave);
			lastLFO3Wave = LFO3Wave;
		}
		if(LFO3Freq != lastLFO3Freq) {
			client.sendPacket("parameter 9 "+LFO3Freq);
			lastLFO3Freq = LFO3Freq;
		}
		if(LFO3Phse != lastLFO3Phse) {
			client.sendPacket("parameter 10 "+LFO3Phse);
			lastLFO3Phse = LFO3Phse;
		}
		if(FltDepth != lastFltDepth) {
			client.sendPacket("parameter 11 "+FltDepth);
			lastFltDepth = FltDepth;
		}
	}

	public override void resetStateTrackers() {
		lastLFO1Wave = -1f;
		lastLFO1Freq = -1f;
		lastLFO1Phse = -1f;
		lastAmpDepth = -1f;
		lastLFO2Wave = -1f;
		lastLFO2Freq = -1f;
		lastLFO2Phse = -1f;
		lastPanDepth = -1f;
		lastLFO3Wave = -1f;
		lastLFO3Freq = -1f;
		lastLFO3Phse = -1f;
		lastFltDepth = -1f;
	}
}
