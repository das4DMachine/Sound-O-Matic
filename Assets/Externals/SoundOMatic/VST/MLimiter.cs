using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MLimiter")]
public class MLimiter : VSTFilter {

	public readonly string pluginPath = "MLimiter.dll";

	public override void resetToDefaults() {
		Gain = 0.5f;
		Outputgain = 0.5f;
		Drywet = 1.0f;
		Threshold = 0.8f;
		Evenharmonics = 0.1f;
		Mode = 0.0f;
		HarmonicsHarmonics = 0.0f;
		HarmonicsGain = 0.5f;
		Harmonics2nd = 0.5f;
		Harmonics3rd = 0.5f;
		Harmonics4th = 0.5f;
		Harmonics5th = 0.5f;
	}

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.5f;
	private float lastGain = -1f;
	public readonly int GainIndex = 0;
	public readonly string GainLow = "-24.00 dB";
	public readonly string GainHigh = "+24.00 dB";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Outputgain = 0.5f;
	private float lastOutputgain = -1f;
	public readonly int OutputgainIndex = 1;
	public readonly string OutputgainLow = "-24.00 dB";
	public readonly string OutputgainHigh = "+24.00 dB";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Drywet = 1.0f;
	private float lastDrywet = -1f;
	public readonly int DrywetIndex = 2;
	public readonly string DrywetLow = "0.00%";
	public readonly string DrywetHigh = "100.0%";

	[Tooltip("silence  |  0.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Threshold = 0.8f;
	private float lastThreshold = -1f;
	public readonly int ThresholdIndex = 3;
	public readonly string ThresholdLow = "silence";
	public readonly string ThresholdHigh = "0.00 dB";

	[Tooltip("0.00%  |  500.0%")]
	[Range(0.0f, 1.0f)]
	public float Evenharmonics = 0.1f;
	private float lastEvenharmonics = -1f;
	public readonly int EvenharmonicsIndex = 4;
	public readonly string EvenharmonicsLow = "0.00%";
	public readonly string EvenharmonicsHigh = "500.0%";

	[Tooltip("Soft 1  |  Disabled")]
	[Range(0.0f, 1.0f)]
	public float Mode = 0.0f;
	private float lastMode = -1f;
	public readonly int ModeIndex = 5;
	public readonly string ModeLow = "Soft 1";
	public readonly string ModeHigh = "Disabled";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float HarmonicsHarmonics = 0.0f;
	private float lastHarmonicsHarmonics = -1f;
	public readonly int HarmonicsHarmonicsIndex = 6;
	public readonly string HarmonicsHarmonicsLow = "Off";
	public readonly string HarmonicsHarmonicsHigh = "On";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float HarmonicsGain = 0.5f;
	private float lastHarmonicsGain = -1f;
	public readonly int HarmonicsGainIndex = 7;
	public readonly string HarmonicsGainLow = "-24.00 dB";
	public readonly string HarmonicsGainHigh = "+24.00 dB";

	[Tooltip("-100.0%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Harmonics2nd = 0.5f;
	private float lastHarmonics2nd = -1f;
	public readonly int Harmonics2ndIndex = 8;
	public readonly string Harmonics2ndLow = "-100.0%";
	public readonly string Harmonics2ndHigh = "100.0%";

	[Tooltip("-100.0%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Harmonics3rd = 0.5f;
	private float lastHarmonics3rd = -1f;
	public readonly int Harmonics3rdIndex = 9;
	public readonly string Harmonics3rdLow = "-100.0%";
	public readonly string Harmonics3rdHigh = "100.0%";

	[Tooltip("-100.0%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Harmonics4th = 0.5f;
	private float lastHarmonics4th = -1f;
	public readonly int Harmonics4thIndex = 10;
	public readonly string Harmonics4thLow = "-100.0%";
	public readonly string Harmonics4thHigh = "100.0%";

	[Tooltip("-100.0%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Harmonics5th = 0.5f;
	private float lastHarmonics5th = -1f;
	public readonly int Harmonics5thIndex = 11;
	public readonly string Harmonics5thLow = "-100.0%";
	public readonly string Harmonics5thHigh = "100.0%";

	public override string getFilterName() {
		return "./vst/MLimiter.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;
		if(Outputgain != lastOutputgain) isUpdated = true;
		if(Drywet != lastDrywet) isUpdated = true;
		if(Threshold != lastThreshold) isUpdated = true;
		if(Evenharmonics != lastEvenharmonics) isUpdated = true;
		if(Mode != lastMode) isUpdated = true;
		if(HarmonicsHarmonics != lastHarmonicsHarmonics) isUpdated = true;
		if(HarmonicsGain != lastHarmonicsGain) isUpdated = true;
		if(Harmonics2nd != lastHarmonics2nd) isUpdated = true;
		if(Harmonics3rd != lastHarmonics3rd) isUpdated = true;
		if(Harmonics4th != lastHarmonics4th) isUpdated = true;
		if(Harmonics5th != lastHarmonics5th) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MLimiter.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
		if(Outputgain != lastOutputgain) {
			client.sendPacket("parameter 1 "+Outputgain);
			lastOutputgain = Outputgain;
		}
		if(Drywet != lastDrywet) {
			client.sendPacket("parameter 2 "+Drywet);
			lastDrywet = Drywet;
		}
		if(Threshold != lastThreshold) {
			client.sendPacket("parameter 3 "+Threshold);
			lastThreshold = Threshold;
		}
		if(Evenharmonics != lastEvenharmonics) {
			client.sendPacket("parameter 4 "+Evenharmonics);
			lastEvenharmonics = Evenharmonics;
		}
		if(Mode != lastMode) {
			client.sendPacket("parameter 5 "+Mode);
			lastMode = Mode;
		}
		if(HarmonicsHarmonics != lastHarmonicsHarmonics) {
			client.sendPacket("parameter 6 "+HarmonicsHarmonics);
			lastHarmonicsHarmonics = HarmonicsHarmonics;
		}
		if(HarmonicsGain != lastHarmonicsGain) {
			client.sendPacket("parameter 7 "+HarmonicsGain);
			lastHarmonicsGain = HarmonicsGain;
		}
		if(Harmonics2nd != lastHarmonics2nd) {
			client.sendPacket("parameter 8 "+Harmonics2nd);
			lastHarmonics2nd = Harmonics2nd;
		}
		if(Harmonics3rd != lastHarmonics3rd) {
			client.sendPacket("parameter 9 "+Harmonics3rd);
			lastHarmonics3rd = Harmonics3rd;
		}
		if(Harmonics4th != lastHarmonics4th) {
			client.sendPacket("parameter 10 "+Harmonics4th);
			lastHarmonics4th = Harmonics4th;
		}
		if(Harmonics5th != lastHarmonics5th) {
			client.sendPacket("parameter 11 "+Harmonics5th);
			lastHarmonics5th = Harmonics5th;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
		lastOutputgain = -1f;
		lastDrywet = -1f;
		lastThreshold = -1f;
		lastEvenharmonics = -1f;
		lastMode = -1f;
		lastHarmonicsHarmonics = -1f;
		lastHarmonicsGain = -1f;
		lastHarmonics2nd = -1f;
		lastHarmonics3rd = -1f;
		lastHarmonics4th = -1f;
		lastHarmonics5th = -1f;
	}
}
