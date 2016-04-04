using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Freeverb3VST_StereoEnhancer")]
public class Freeverb3VST_StereoEnhancer : VSTFilter {

	public readonly string pluginPath = "Freeverb3VST_StereoEnhancer.dll";

	public override void resetToDefaults() {
		ChValL = 1.0f;
		ChValR = 1.0f;
		BPF_LPF = 0.5f;
		BPF_HPF = 0.5f;
		BRF_LPF = 0.5f;
		BRF_HPF = 0.5f;
		Width = 0.175f;
		Dry = 0.25f;
		Diffus = 0.3f;
		Thres = 0.78f;
		RMS = 0.0f;
		Attack = 0.0f;
		Release = 0.0f;
		SoftKnee = 0.5f;
		Ratio = 0.05f;
		BPFDepth = 0.05f;
		BRFDepth = 0.0875f;
		AllDepth = 0.0875f;
	}

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float ChValL = 1.0f;
	private float lastChValL = -1f;
	public readonly int ChValLIndex = 0;
	public readonly string ChValLLow = "0.000000%";
	public readonly string ChValLHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float ChValR = 1.0f;
	private float lastChValR = -1f;
	public readonly int ChValRIndex = 1;
	public readonly string ChValRLow = "0.000000%";
	public readonly string ChValRHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float BPF_LPF = 0.5f;
	private float lastBPF_LPF = -1f;
	public readonly int BPF_LPFIndex = 2;
	public readonly string BPF_LPFLow = "0.000000%";
	public readonly string BPF_LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float BPF_HPF = 0.5f;
	private float lastBPF_HPF = -1f;
	public readonly int BPF_HPFIndex = 3;
	public readonly string BPF_HPFLow = "0.000000%";
	public readonly string BPF_HPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float BRF_LPF = 0.5f;
	private float lastBRF_LPF = -1f;
	public readonly int BRF_LPFIndex = 4;
	public readonly string BRF_LPFLow = "0.000000%";
	public readonly string BRF_LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float BRF_HPF = 0.5f;
	private float lastBRF_HPF = -1f;
	public readonly int BRF_HPFIndex = 5;
	public readonly string BRF_HPFLow = "0.000000%";
	public readonly string BRF_HPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  400.0000%")]
	[Range(0.0f, 1.0f)]
	public float Width = 0.175f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 6;
	public readonly string WidthLow = "0.000000%";
	public readonly string WidthHigh = "400.0000%";

	[Tooltip("0.000000  |  4.000000")]
	[Range(0.0f, 1.0f)]
	public float Dry = 0.25f;
	private float lastDry = -1f;
	public readonly int DryIndex = 7;
	public readonly string DryLow = "0.000000";
	public readonly string DryHigh = "4.000000";

	[Tooltip("0.000000  |  3.000000")]
	[Range(0.0f, 1.0f)]
	public float Diffus = 0.3f;
	private float lastDiffus = -1f;
	public readonly int DiffusIndex = 8;
	public readonly string DiffusLow = "0.000000";
	public readonly string DiffusHigh = "3.000000";

	[Tooltip("-40.0000dB  |  10.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Thres = 0.78f;
	private float lastThres = -1f;
	public readonly int ThresIndex = 9;
	public readonly string ThresLow = "-40.0000dB";
	public readonly string ThresHigh = "10.00000dB";

	[Tooltip("0.000000ms  |  100.0000ms")]
	[Range(0.0f, 1.0f)]
	public float RMS = 0.0f;
	private float lastRMS = -1f;
	public readonly int RMSIndex = 10;
	public readonly string RMSLow = "0.000000ms";
	public readonly string RMSHigh = "100.0000ms";

	[Tooltip("0.000000ms  |  1000.000ms")]
	[Range(0.0f, 1.0f)]
	public float Attack = 0.0f;
	private float lastAttack = -1f;
	public readonly int AttackIndex = 11;
	public readonly string AttackLow = "0.000000ms";
	public readonly string AttackHigh = "1000.000ms";

	[Tooltip("0.000000ms  |  1000.000ms")]
	[Range(0.0f, 1.0f)]
	public float Release = 0.0f;
	private float lastRelease = -1f;
	public readonly int ReleaseIndex = 12;
	public readonly string ReleaseLow = "0.000000ms";
	public readonly string ReleaseHigh = "1000.000ms";

	[Tooltip("0.000000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float SoftKnee = 0.5f;
	private float lastSoftKnee = -1f;
	public readonly int SoftKneeIndex = 13;
	public readonly string SoftKneeLow = "0.000000dB";
	public readonly string SoftKneeHigh = "20.00000dB";

	[Tooltip("2.000000  |  22.00000")]
	[Range(0.0f, 1.0f)]
	public float Ratio = 0.05f;
	private float lastRatio = -1f;
	public readonly int RatioIndex = 14;
	public readonly string RatioLow = "2.000000";
	public readonly string RatioHigh = "22.00000";

	[Tooltip("0.000000ms  |  80.00000ms")]
	[Range(0.0f, 1.0f)]
	public float BPFDepth = 0.05f;
	private float lastBPFDepth = -1f;
	public readonly int BPFDepthIndex = 15;
	public readonly string BPFDepthLow = "0.000000ms";
	public readonly string BPFDepthHigh = "80.00000ms";

	[Tooltip("0.000000ms  |  80.00000ms")]
	[Range(0.0f, 1.0f)]
	public float BRFDepth = 0.0875f;
	private float lastBRFDepth = -1f;
	public readonly int BRFDepthIndex = 16;
	public readonly string BRFDepthLow = "0.000000ms";
	public readonly string BRFDepthHigh = "80.00000ms";

	[Tooltip("0.000000ms  |  80.00000ms")]
	[Range(0.0f, 1.0f)]
	public float AllDepth = 0.0875f;
	private float lastAllDepth = -1f;
	public readonly int AllDepthIndex = 17;
	public readonly string AllDepthLow = "0.000000ms";
	public readonly string AllDepthHigh = "80.00000ms";

	public override string getFilterName() {
		return "./vst/Freeverb3VST_StereoEnhancer.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(ChValL != lastChValL) isUpdated = true;
		if(ChValR != lastChValR) isUpdated = true;
		if(BPF_LPF != lastBPF_LPF) isUpdated = true;
		if(BPF_HPF != lastBPF_HPF) isUpdated = true;
		if(BRF_LPF != lastBRF_LPF) isUpdated = true;
		if(BRF_HPF != lastBRF_HPF) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;
		if(Diffus != lastDiffus) isUpdated = true;
		if(Thres != lastThres) isUpdated = true;
		if(RMS != lastRMS) isUpdated = true;
		if(Attack != lastAttack) isUpdated = true;
		if(Release != lastRelease) isUpdated = true;
		if(SoftKnee != lastSoftKnee) isUpdated = true;
		if(Ratio != lastRatio) isUpdated = true;
		if(BPFDepth != lastBPFDepth) isUpdated = true;
		if(BRFDepth != lastBRFDepth) isUpdated = true;
		if(AllDepth != lastAllDepth) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Freeverb3VST_StereoEnhancer.dll");
		if(ChValL != lastChValL) {
			client.sendPacket("parameter 0 "+ChValL);
			lastChValL = ChValL;
		}
		if(ChValR != lastChValR) {
			client.sendPacket("parameter 1 "+ChValR);
			lastChValR = ChValR;
		}
		if(BPF_LPF != lastBPF_LPF) {
			client.sendPacket("parameter 2 "+BPF_LPF);
			lastBPF_LPF = BPF_LPF;
		}
		if(BPF_HPF != lastBPF_HPF) {
			client.sendPacket("parameter 3 "+BPF_HPF);
			lastBPF_HPF = BPF_HPF;
		}
		if(BRF_LPF != lastBRF_LPF) {
			client.sendPacket("parameter 4 "+BRF_LPF);
			lastBRF_LPF = BRF_LPF;
		}
		if(BRF_HPF != lastBRF_HPF) {
			client.sendPacket("parameter 5 "+BRF_HPF);
			lastBRF_HPF = BRF_HPF;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 6 "+Width);
			lastWidth = Width;
		}
		if(Dry != lastDry) {
			client.sendPacket("parameter 7 "+Dry);
			lastDry = Dry;
		}
		if(Diffus != lastDiffus) {
			client.sendPacket("parameter 8 "+Diffus);
			lastDiffus = Diffus;
		}
		if(Thres != lastThres) {
			client.sendPacket("parameter 9 "+Thres);
			lastThres = Thres;
		}
		if(RMS != lastRMS) {
			client.sendPacket("parameter 10 "+RMS);
			lastRMS = RMS;
		}
		if(Attack != lastAttack) {
			client.sendPacket("parameter 11 "+Attack);
			lastAttack = Attack;
		}
		if(Release != lastRelease) {
			client.sendPacket("parameter 12 "+Release);
			lastRelease = Release;
		}
		if(SoftKnee != lastSoftKnee) {
			client.sendPacket("parameter 13 "+SoftKnee);
			lastSoftKnee = SoftKnee;
		}
		if(Ratio != lastRatio) {
			client.sendPacket("parameter 14 "+Ratio);
			lastRatio = Ratio;
		}
		if(BPFDepth != lastBPFDepth) {
			client.sendPacket("parameter 15 "+BPFDepth);
			lastBPFDepth = BPFDepth;
		}
		if(BRFDepth != lastBRFDepth) {
			client.sendPacket("parameter 16 "+BRFDepth);
			lastBRFDepth = BRFDepth;
		}
		if(AllDepth != lastAllDepth) {
			client.sendPacket("parameter 17 "+AllDepth);
			lastAllDepth = AllDepth;
		}
	}

	public override void resetStateTrackers() {
		lastChValL = -1f;
		lastChValR = -1f;
		lastBPF_LPF = -1f;
		lastBPF_HPF = -1f;
		lastBRF_LPF = -1f;
		lastBRF_HPF = -1f;
		lastWidth = -1f;
		lastDry = -1f;
		lastDiffus = -1f;
		lastThres = -1f;
		lastRMS = -1f;
		lastAttack = -1f;
		lastRelease = -1f;
		lastSoftKnee = -1f;
		lastRatio = -1f;
		lastBPFDepth = -1f;
		lastBRFDepth = -1f;
		lastAllDepth = -1f;
	}
}
