using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MBandPass")]
public class MBandPass : VSTFilter {

	public readonly string pluginPath = "MBandPass.dll";

	public override void resetToDefaults() {
		HighpassfilterHigh = 0.0f;
		HighpassfilterFrequ = 0.0f;
		HighpassfilterQ = 0.28474972f;
		HighpassfilterSlope = 0.1f;
		LowpassfilterLowpa = 0.0f;
		LowpassfilterFreque = 1.0f;
		LowpassfilterQ = 0.28474972f;
		LowpassfilterSlope = 0.1f;
		Drywet = 1.0f;
		Gain = 0.5f;
	}

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float HighpassfilterHigh = 0.0f;
	private float lastHighpassfilterHigh = -1f;
	public readonly int HighpassfilterHighIndex = 0;
	public readonly string HighpassfilterHighLow = "Off";
	public readonly string HighpassfilterHighHigh = "On";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float HighpassfilterFrequ = 0.0f;
	private float lastHighpassfilterFrequ = -1f;
	public readonly int HighpassfilterFrequIndex = 1;
	public readonly string HighpassfilterFrequLow = "20.0 Hz";
	public readonly string HighpassfilterFrequHigh = "20.0 kHz";

	[Tooltip("0.050000  |  100.000000")]
	[Range(0.0f, 1.0f)]
	public float HighpassfilterQ = 0.28474972f;
	private float lastHighpassfilterQ = -1f;
	public readonly int HighpassfilterQIndex = 2;
	public readonly string HighpassfilterQLow = "0.050000";
	public readonly string HighpassfilterQHigh = "100.000000";

	[Tooltip("HP 6  |  HP 120")]
	[Range(0.0f, 1.0f)]
	public float HighpassfilterSlope = 0.1f;
	private float lastHighpassfilterSlope = -1f;
	public readonly int HighpassfilterSlopeIndex = 3;
	public readonly string HighpassfilterSlopeLow = "HP 6";
	public readonly string HighpassfilterSlopeHigh = "HP 120";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float LowpassfilterLowpa = 0.0f;
	private float lastLowpassfilterLowpa = -1f;
	public readonly int LowpassfilterLowpaIndex = 4;
	public readonly string LowpassfilterLowpaLow = "Off";
	public readonly string LowpassfilterLowpaHigh = "On";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float LowpassfilterFreque = 1.0f;
	private float lastLowpassfilterFreque = -1f;
	public readonly int LowpassfilterFrequeIndex = 5;
	public readonly string LowpassfilterFrequeLow = "20.0 Hz";
	public readonly string LowpassfilterFrequeHigh = "20.0 kHz";

	[Tooltip("0.050000  |  100.000000")]
	[Range(0.0f, 1.0f)]
	public float LowpassfilterQ = 0.28474972f;
	private float lastLowpassfilterQ = -1f;
	public readonly int LowpassfilterQIndex = 6;
	public readonly string LowpassfilterQLow = "0.050000";
	public readonly string LowpassfilterQHigh = "100.000000";

	[Tooltip("LP 6  |  LP 120")]
	[Range(0.0f, 1.0f)]
	public float LowpassfilterSlope = 0.1f;
	private float lastLowpassfilterSlope = -1f;
	public readonly int LowpassfilterSlopeIndex = 7;
	public readonly string LowpassfilterSlopeLow = "LP 6";
	public readonly string LowpassfilterSlopeHigh = "LP 120";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Drywet = 1.0f;
	private float lastDrywet = -1f;
	public readonly int DrywetIndex = 130;
	public readonly string DrywetLow = "0.00%";
	public readonly string DrywetHigh = "100.0%";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.5f;
	private float lastGain = -1f;
	public readonly int GainIndex = 131;
	public readonly string GainLow = "-24.00 dB";
	public readonly string GainHigh = "+24.00 dB";

	public override string getFilterName() {
		return "./vst/MBandPass.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(HighpassfilterHigh != lastHighpassfilterHigh) isUpdated = true;
		if(HighpassfilterFrequ != lastHighpassfilterFrequ) isUpdated = true;
		if(HighpassfilterQ != lastHighpassfilterQ) isUpdated = true;
		if(HighpassfilterSlope != lastHighpassfilterSlope) isUpdated = true;
		if(LowpassfilterLowpa != lastLowpassfilterLowpa) isUpdated = true;
		if(LowpassfilterFreque != lastLowpassfilterFreque) isUpdated = true;
		if(LowpassfilterQ != lastLowpassfilterQ) isUpdated = true;
		if(LowpassfilterSlope != lastLowpassfilterSlope) isUpdated = true;
		if(Drywet != lastDrywet) isUpdated = true;
		if(Gain != lastGain) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MBandPass.dll");
		if(HighpassfilterHigh != lastHighpassfilterHigh) {
			client.sendPacket("parameter 0 "+HighpassfilterHigh);
			lastHighpassfilterHigh = HighpassfilterHigh;
		}
		if(HighpassfilterFrequ != lastHighpassfilterFrequ) {
			client.sendPacket("parameter 1 "+HighpassfilterFrequ);
			lastHighpassfilterFrequ = HighpassfilterFrequ;
		}
		if(HighpassfilterQ != lastHighpassfilterQ) {
			client.sendPacket("parameter 2 "+HighpassfilterQ);
			lastHighpassfilterQ = HighpassfilterQ;
		}
		if(HighpassfilterSlope != lastHighpassfilterSlope) {
			client.sendPacket("parameter 3 "+HighpassfilterSlope);
			lastHighpassfilterSlope = HighpassfilterSlope;
		}
		if(LowpassfilterLowpa != lastLowpassfilterLowpa) {
			client.sendPacket("parameter 4 "+LowpassfilterLowpa);
			lastLowpassfilterLowpa = LowpassfilterLowpa;
		}
		if(LowpassfilterFreque != lastLowpassfilterFreque) {
			client.sendPacket("parameter 5 "+LowpassfilterFreque);
			lastLowpassfilterFreque = LowpassfilterFreque;
		}
		if(LowpassfilterQ != lastLowpassfilterQ) {
			client.sendPacket("parameter 6 "+LowpassfilterQ);
			lastLowpassfilterQ = LowpassfilterQ;
		}
		if(LowpassfilterSlope != lastLowpassfilterSlope) {
			client.sendPacket("parameter 7 "+LowpassfilterSlope);
			lastLowpassfilterSlope = LowpassfilterSlope;
		}
		if(Drywet != lastDrywet) {
			client.sendPacket("parameter 130 "+Drywet);
			lastDrywet = Drywet;
		}
		if(Gain != lastGain) {
			client.sendPacket("parameter 131 "+Gain);
			lastGain = Gain;
		}
	}

	public override void resetStateTrackers() {
		lastHighpassfilterHigh = -1f;
		lastHighpassfilterFrequ = -1f;
		lastHighpassfilterQ = -1f;
		lastHighpassfilterSlope = -1f;
		lastLowpassfilterLowpa = -1f;
		lastLowpassfilterFreque = -1f;
		lastLowpassfilterQ = -1f;
		lastLowpassfilterSlope = -1f;
		lastDrywet = -1f;
		lastGain = -1f;
	}
}
