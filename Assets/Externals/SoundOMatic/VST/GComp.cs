using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GComp")]
public class GComp : VSTFilter {

	public readonly string pluginPath = "GComp.dll";

	public override void resetToDefaults() {
		Gain = 0.5f;
		RMSPeak = 0.5f;
		Attack = 0.2f;
		Release = 0.4949495f;
		Thresh = 0.30555555f;
		Ratio = 0.21428572f;
		Limit = 1.0f;
		Softness = 0.75f;
		LRLink = 1.0f;
		Output = 0.625f;
	}

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.5f;
	private float lastGain = -1f;
	public readonly int GainIndex = 0;
	public readonly string GainLow = "-12.0dB";
	public readonly string GainHigh = "12.0dB";

	[Tooltip("100 / 0  |  0 / 100")]
	[Range(0.0f, 1.0f)]
	public float RMSPeak = 0.5f;
	private float lastRMSPeak = -1f;
	public readonly int RMSPeakIndex = 1;
	public readonly string RMSPeakLow = "100 / 0";
	public readonly string RMSPeakHigh = "0 / 100";

	[Tooltip("0.0ms  |  10.0ms")]
	[Range(0.0f, 1.0f)]
	public float Attack = 0.2f;
	private float lastAttack = -1f;
	public readonly int AttackIndex = 2;
	public readonly string AttackLow = "0.0ms";
	public readonly string AttackHigh = "10.0ms";

	[Tooltip("0.01s  |  1.00s")]
	[Range(0.0f, 1.0f)]
	public float Release = 0.4949495f;
	private float lastRelease = -1f;
	public readonly int ReleaseIndex = 3;
	public readonly string ReleaseLow = "0.01s";
	public readonly string ReleaseHigh = "1.00s";

	[Tooltip("-36.0dB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Thresh = 0.30555555f;
	private float lastThresh = -1f;
	public readonly int ThreshIndex = 4;
	public readonly string ThreshLow = "-36.0dB";
	public readonly string ThreshHigh = "0.0dB";

	[Tooltip("1.0: 1  |  15.0: 1")]
	[Range(0.0f, 1.0f)]
	public float Ratio = 0.21428572f;
	private float lastRatio = -1f;
	public readonly int RatioIndex = 5;
	public readonly string RatioLow = "1.0: 1";
	public readonly string RatioHigh = "15.0: 1";

	[Tooltip("-36.0dB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Limit = 1.0f;
	private float lastLimit = -1f;
	public readonly int LimitIndex = 6;
	public readonly string LimitLow = "-36.0dB";
	public readonly string LimitHigh = "0.0dB";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Softness = 0.75f;
	private float lastSoftness = -1f;
	public readonly int SoftnessIndex = 7;
	public readonly string SoftnessLow = "0%";
	public readonly string SoftnessHigh = "100%";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float LRLink = 1.0f;
	private float lastLRLink = -1f;
	public readonly int LRLinkIndex = 8;
	public readonly string LRLinkLow = "Off";
	public readonly string LRLinkHigh = "On";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float Output = 0.625f;
	private float lastOutput = -1f;
	public readonly int OutputIndex = 9;
	public readonly string OutputLow = "-12.0dB";
	public readonly string OutputHigh = "12.0dB";

	public override string getFilterName() {
		return "./vst/GComp.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;
		if(RMSPeak != lastRMSPeak) isUpdated = true;
		if(Attack != lastAttack) isUpdated = true;
		if(Release != lastRelease) isUpdated = true;
		if(Thresh != lastThresh) isUpdated = true;
		if(Ratio != lastRatio) isUpdated = true;
		if(Limit != lastLimit) isUpdated = true;
		if(Softness != lastSoftness) isUpdated = true;
		if(LRLink != lastLRLink) isUpdated = true;
		if(Output != lastOutput) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GComp.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
		if(RMSPeak != lastRMSPeak) {
			client.sendPacket("parameter 1 "+RMSPeak);
			lastRMSPeak = RMSPeak;
		}
		if(Attack != lastAttack) {
			client.sendPacket("parameter 2 "+Attack);
			lastAttack = Attack;
		}
		if(Release != lastRelease) {
			client.sendPacket("parameter 3 "+Release);
			lastRelease = Release;
		}
		if(Thresh != lastThresh) {
			client.sendPacket("parameter 4 "+Thresh);
			lastThresh = Thresh;
		}
		if(Ratio != lastRatio) {
			client.sendPacket("parameter 5 "+Ratio);
			lastRatio = Ratio;
		}
		if(Limit != lastLimit) {
			client.sendPacket("parameter 6 "+Limit);
			lastLimit = Limit;
		}
		if(Softness != lastSoftness) {
			client.sendPacket("parameter 7 "+Softness);
			lastSoftness = Softness;
		}
		if(LRLink != lastLRLink) {
			client.sendPacket("parameter 8 "+LRLink);
			lastLRLink = LRLink;
		}
		if(Output != lastOutput) {
			client.sendPacket("parameter 9 "+Output);
			lastOutput = Output;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
		lastRMSPeak = -1f;
		lastAttack = -1f;
		lastRelease = -1f;
		lastThresh = -1f;
		lastRatio = -1f;
		lastLimit = -1f;
		lastSoftness = -1f;
		lastLRLink = -1f;
		lastOutput = -1f;
	}
}
