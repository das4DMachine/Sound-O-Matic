using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Freeverb3VST_X1_Limiter")]
public class Freeverb3VST_X1_Limiter : VSTFilter {

	public readonly string pluginPath = "Freeverb3VST_X1_Limiter.dll";

	public override void resetToDefaults() {
		Ceiling = 1.0f;
		Threshol = 0.8f;
		PreGain = 0.33333334f;
		Release = 0.56234133f;
		Attack = 0.0f;
		Lookahea = 0.59460354f;
		LookRati = 0.33333334f;
		RMS = 0.0f;
		Factor = 0.2f;
		StLink = 1.0f;
		Type = 0.0f;
	}

	[Tooltip("-30.0000dB  |  0.000000dB")]
	[Range(0.0f, 1.0f)]
	public float Ceiling = 1.0f;
	private float lastCeiling = -1f;
	public readonly int CeilingIndex = 0;
	public readonly string CeilingLow = "-30.0000dB";
	public readonly string CeilingHigh = "0.000000dB";

	[Tooltip("-10.0000dB  |  0.000000dB")]
	[Range(0.0f, 1.0f)]
	public float Threshol = 0.8f;
	private float lastThreshol = -1f;
	public readonly int ThresholIndex = 1;
	public readonly string ThresholLow = "-10.0000dB";
	public readonly string ThresholHigh = "0.000000dB";

	[Tooltip("0.000000dB  |  30.00000dB")]
	[Range(0.0f, 1.0f)]
	public float PreGain = 0.33333334f;
	private float lastPreGain = -1f;
	public readonly int PreGainIndex = 2;
	public readonly string PreGainLow = "0.000000dB";
	public readonly string PreGainHigh = "30.00000dB";

	[Tooltip("0.000000ms  |  1000.000ms")]
	[Range(0.0f, 1.0f)]
	public float Release = 0.56234133f;
	private float lastRelease = -1f;
	public readonly int ReleaseIndex = 3;
	public readonly string ReleaseLow = "0.000000ms";
	public readonly string ReleaseHigh = "1000.000ms";

	[Tooltip("0.000000ms  |  1000.000ms")]
	[Range(0.0f, 1.0f)]
	public float Attack = 0.0f;
	private float lastAttack = -1f;
	public readonly int AttackIndex = 4;
	public readonly string AttackLow = "0.000000ms";
	public readonly string AttackHigh = "1000.000ms";

	[Tooltip("0.000000ms  |  8.000000ms")]
	[Range(0.0f, 1.0f)]
	public float Lookahea = 0.59460354f;
	private float lastLookahea = -1f;
	public readonly int LookaheaIndex = 5;
	public readonly string LookaheaLow = "0.000000ms";
	public readonly string LookaheaHigh = "8.000000ms";

	[Tooltip("0.500000X  |  2.000000X")]
	[Range(0.0f, 1.0f)]
	public float LookRati = 0.33333334f;
	private float lastLookRati = -1f;
	public readonly int LookRatiIndex = 6;
	public readonly string LookRatiLow = "0.500000X";
	public readonly string LookRatiHigh = "2.000000X";

	[Tooltip("0.000000ms  |  100.0000ms")]
	[Range(0.0f, 1.0f)]
	public float RMS = 0.0f;
	private float lastRMS = -1f;
	public readonly int RMSIndex = 7;
	public readonly string RMSLow = "0.000000ms";
	public readonly string RMSHigh = "100.0000ms";

	[Tooltip("100.0000X  |  100.0000X")]
	[Range(0.0f, 1.0f)]
	public float Factor = 0.2f;
	private float lastFactor = -1f;
	public readonly int FactorIndex = 8;
	public readonly string FactorLow = "100.0000X";
	public readonly string FactorHigh = "100.0000X";

	[Tooltip("Off-  |  On-")]
	[Range(0.0f, 1.0f)]
	public float StLink = 1.0f;
	private float lastStLink = -1f;
	public readonly int StLinkIndex = 9;
	public readonly string StLinkLow = "Off-";
	public readonly string StLinkHigh = "On-";

	[Tooltip("-  |  -")]
	[Range(0.0f, 1.0f)]
	public float Type = 0.0f;
	private float lastType = -1f;
	public readonly int TypeIndex = 10;
	public readonly string TypeLow = "-";
	public readonly string TypeHigh = "-";

	public override string getFilterName() {
		return "./vst/Freeverb3VST_X1_Limiter.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Ceiling != lastCeiling) isUpdated = true;
		if(Threshol != lastThreshol) isUpdated = true;
		if(PreGain != lastPreGain) isUpdated = true;
		if(Release != lastRelease) isUpdated = true;
		if(Attack != lastAttack) isUpdated = true;
		if(Lookahea != lastLookahea) isUpdated = true;
		if(LookRati != lastLookRati) isUpdated = true;
		if(RMS != lastRMS) isUpdated = true;
		if(Factor != lastFactor) isUpdated = true;
		if(StLink != lastStLink) isUpdated = true;
		if(Type != lastType) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Freeverb3VST_X1_Limiter.dll");
		if(Ceiling != lastCeiling) {
			client.sendPacket("parameter 0 "+Ceiling);
			lastCeiling = Ceiling;
		}
		if(Threshol != lastThreshol) {
			client.sendPacket("parameter 1 "+Threshol);
			lastThreshol = Threshol;
		}
		if(PreGain != lastPreGain) {
			client.sendPacket("parameter 2 "+PreGain);
			lastPreGain = PreGain;
		}
		if(Release != lastRelease) {
			client.sendPacket("parameter 3 "+Release);
			lastRelease = Release;
		}
		if(Attack != lastAttack) {
			client.sendPacket("parameter 4 "+Attack);
			lastAttack = Attack;
		}
		if(Lookahea != lastLookahea) {
			client.sendPacket("parameter 5 "+Lookahea);
			lastLookahea = Lookahea;
		}
		if(LookRati != lastLookRati) {
			client.sendPacket("parameter 6 "+LookRati);
			lastLookRati = LookRati;
		}
		if(RMS != lastRMS) {
			client.sendPacket("parameter 7 "+RMS);
			lastRMS = RMS;
		}
		if(Factor != lastFactor) {
			client.sendPacket("parameter 8 "+Factor);
			lastFactor = Factor;
		}
		if(StLink != lastStLink) {
			client.sendPacket("parameter 9 "+StLink);
			lastStLink = StLink;
		}
		if(Type != lastType) {
			client.sendPacket("parameter 10 "+Type);
			lastType = Type;
		}
	}

	public override void resetStateTrackers() {
		lastCeiling = -1f;
		lastThreshol = -1f;
		lastPreGain = -1f;
		lastRelease = -1f;
		lastAttack = -1f;
		lastLookahea = -1f;
		lastLookRati = -1f;
		lastRMS = -1f;
		lastFactor = -1f;
		lastStLink = -1f;
		lastType = -1f;
	}
}
