using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MCompressor")]
public class MCompressor : VSTFilter {

	public readonly string pluginPath = "MCompressor.dll";

	public override void resetToDefaults() {
		Gain = 0.5f;
		Outputgain = 0.5f;
		Attack = 0.31622776f;
		Release = 0.4728708f;
		RMSlength = 0.1f;
		Threshold = 0.4949495f;
		Ratio = 0.20519567f;
		Kneemode = 0.0f;
		Kneesize = 0.25f;
		Linkchannels = 1.0f;
		Maximizeto0dB = 0.0f;
		Customshape = 0.0f;
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

	[Tooltip("0 ms  |  1000 ms")]
	[Range(0.0f, 1.0f)]
	public float Attack = 0.31622776f;
	private float lastAttack = -1f;
	public readonly int AttackIndex = 2;
	public readonly string AttackLow = "0 ms";
	public readonly string AttackHigh = "1000 ms";

	[Tooltip("0 ms  |  1000 ms")]
	[Range(0.0f, 1.0f)]
	public float Release = 0.4728708f;
	private float lastRelease = -1f;
	public readonly int ReleaseIndex = 3;
	public readonly string ReleaseLow = "0 ms";
	public readonly string ReleaseHigh = "1000 ms";

	[Tooltip("Peak  |  100 ms")]
	[Range(0.0f, 1.0f)]
	public float RMSlength = 0.1f;
	private float lastRMSlength = -1f;
	public readonly int RMSlengthIndex = 4;
	public readonly string RMSlengthLow = "Peak";
	public readonly string RMSlengthHigh = "100 ms";

	[Tooltip("-80.0 dB  |  0.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Threshold = 0.4949495f;
	private float lastThreshold = -1f;
	public readonly int ThresholdIndex = 5;
	public readonly string ThresholdLow = "-80.0 dB";
	public readonly string ThresholdHigh = "0.00 dB";

	[Tooltip("1.00 : 1  |  20.00 : 1")]
	[Range(0.0f, 1.0f)]
	public float Ratio = 0.20519567f;
	private float lastRatio = -1f;
	public readonly int RatioIndex = 6;
	public readonly string RatioLow = "1.00 : 1";
	public readonly string RatioHigh = "20.00 : 1";

	[Tooltip("Hard  |  Soft")]
	[Range(0.0f, 1.0f)]
	public float Kneemode = 0.0f;
	private float lastKneemode = -1f;
	public readonly int KneemodeIndex = 7;
	public readonly string KneemodeLow = "Hard";
	public readonly string KneemodeHigh = "Soft";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Kneesize = 0.25f;
	private float lastKneesize = -1f;
	public readonly int KneesizeIndex = 8;
	public readonly string KneesizeLow = "0.00%";
	public readonly string KneesizeHigh = "100.0%";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Linkchannels = 1.0f;
	private float lastLinkchannels = -1f;
	public readonly int LinkchannelsIndex = 9;
	public readonly string LinkchannelsLow = "Off";
	public readonly string LinkchannelsHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Maximizeto0dB = 0.0f;
	private float lastMaximizeto0dB = -1f;
	public readonly int Maximizeto0dBIndex = 10;
	public readonly string Maximizeto0dBLow = "Off";
	public readonly string Maximizeto0dBHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Customshape = 0.0f;
	private float lastCustomshape = -1f;
	public readonly int CustomshapeIndex = 11;
	public readonly string CustomshapeLow = "Off";
	public readonly string CustomshapeHigh = "On";

	public override string getFilterName() {
		return "./vst/MCompressor.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;
		if(Outputgain != lastOutputgain) isUpdated = true;
		if(Attack != lastAttack) isUpdated = true;
		if(Release != lastRelease) isUpdated = true;
		if(RMSlength != lastRMSlength) isUpdated = true;
		if(Threshold != lastThreshold) isUpdated = true;
		if(Ratio != lastRatio) isUpdated = true;
		if(Kneemode != lastKneemode) isUpdated = true;
		if(Kneesize != lastKneesize) isUpdated = true;
		if(Linkchannels != lastLinkchannels) isUpdated = true;
		if(Maximizeto0dB != lastMaximizeto0dB) isUpdated = true;
		if(Customshape != lastCustomshape) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MCompressor.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
		if(Outputgain != lastOutputgain) {
			client.sendPacket("parameter 1 "+Outputgain);
			lastOutputgain = Outputgain;
		}
		if(Attack != lastAttack) {
			client.sendPacket("parameter 2 "+Attack);
			lastAttack = Attack;
		}
		if(Release != lastRelease) {
			client.sendPacket("parameter 3 "+Release);
			lastRelease = Release;
		}
		if(RMSlength != lastRMSlength) {
			client.sendPacket("parameter 4 "+RMSlength);
			lastRMSlength = RMSlength;
		}
		if(Threshold != lastThreshold) {
			client.sendPacket("parameter 5 "+Threshold);
			lastThreshold = Threshold;
		}
		if(Ratio != lastRatio) {
			client.sendPacket("parameter 6 "+Ratio);
			lastRatio = Ratio;
		}
		if(Kneemode != lastKneemode) {
			client.sendPacket("parameter 7 "+Kneemode);
			lastKneemode = Kneemode;
		}
		if(Kneesize != lastKneesize) {
			client.sendPacket("parameter 8 "+Kneesize);
			lastKneesize = Kneesize;
		}
		if(Linkchannels != lastLinkchannels) {
			client.sendPacket("parameter 9 "+Linkchannels);
			lastLinkchannels = Linkchannels;
		}
		if(Maximizeto0dB != lastMaximizeto0dB) {
			client.sendPacket("parameter 10 "+Maximizeto0dB);
			lastMaximizeto0dB = Maximizeto0dB;
		}
		if(Customshape != lastCustomshape) {
			client.sendPacket("parameter 11 "+Customshape);
			lastCustomshape = Customshape;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
		lastOutputgain = -1f;
		lastAttack = -1f;
		lastRelease = -1f;
		lastRMSlength = -1f;
		lastThreshold = -1f;
		lastRatio = -1f;
		lastKneemode = -1f;
		lastKneesize = -1f;
		lastLinkchannels = -1f;
		lastMaximizeto0dB = -1f;
		lastCustomshape = -1f;
	}
}
