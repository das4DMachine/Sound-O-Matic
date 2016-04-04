using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Freeverb3VST_NVerb")]
public class Freeverb3VST_NVerb : VSTFilter {

	public readonly string pluginPath = "Freeverb3VST_NVerb.dll";

	public override void resetToDefaults() {
		SRCFact = 0.71999997f;
		Wet = 0.6666667f;
		Dry = 0.8333334f;
		FeedBack = 0.6f;
		Damping = 0.71f;
		OutLPF = 0.85f;
		InHPF = 0.1f;
		RT60 = 0.315625f;
		Width = 1.0f;
		PreDelay = 0.51500005f;
	}

	[Tooltip("1-AX  |  5-BX")]
	[Range(0.0f, 1.0f)]
	public float SRCFact = 0.71999997f;
	private float lastSRCFact = -1f;
	public readonly int SRCFactIndex = 0;
	public readonly string SRCFactLow = "1-AX";
	public readonly string SRCFactHigh = "5-BX";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Wet = 0.6666667f;
	private float lastWet = -1f;
	public readonly int WetIndex = 1;
	public readonly string WetLow = "-100.000dB";
	public readonly string WetHigh = "20.00000dB";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 0.8333334f;
	private float lastDry = -1f;
	public readonly int DryIndex = 2;
	public readonly string DryLow = "-100.000dB";
	public readonly string DryHigh = "20.00000dB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float FeedBack = 0.6f;
	private float lastFeedBack = -1f;
	public readonly int FeedBackIndex = 3;
	public readonly string FeedBackLow = "0.000000%";
	public readonly string FeedBackHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float Damping = 0.71f;
	private float lastDamping = -1f;
	public readonly int DampingIndex = 4;
	public readonly string DampingLow = "0.000000%";
	public readonly string DampingHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float OutLPF = 0.85f;
	private float lastOutLPF = -1f;
	public readonly int OutLPFIndex = 5;
	public readonly string OutLPFLow = "0.000000%";
	public readonly string OutLPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float InHPF = 0.1f;
	private float lastInHPF = -1f;
	public readonly int InHPFIndex = 6;
	public readonly string InHPFLow = "0.000000%";
	public readonly string InHPFHigh = "100.0000%";

	[Tooltip("0.000000s  |  16.00000s")]
	[Range(0.0f, 1.0f)]
	public float RT60 = 0.315625f;
	private float lastRT60 = -1f;
	public readonly int RT60Index = 7;
	public readonly string RT60Low = "0.000000s";
	public readonly string RT60High = "16.00000s";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float Width = 1.0f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 8;
	public readonly string WidthLow = "0.000000%";
	public readonly string WidthHigh = "100.0000%";

	[Tooltip("-500.000ms  |  500.0000ms")]
	[Range(0.0f, 1.0f)]
	public float PreDelay = 0.51500005f;
	private float lastPreDelay = -1f;
	public readonly int PreDelayIndex = 9;
	public readonly string PreDelayLow = "-500.000ms";
	public readonly string PreDelayHigh = "500.0000ms";

	public override string getFilterName() {
		return "./vst/Freeverb3VST_NVerb.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(SRCFact != lastSRCFact) isUpdated = true;
		if(Wet != lastWet) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;
		if(FeedBack != lastFeedBack) isUpdated = true;
		if(Damping != lastDamping) isUpdated = true;
		if(OutLPF != lastOutLPF) isUpdated = true;
		if(InHPF != lastInHPF) isUpdated = true;
		if(RT60 != lastRT60) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;
		if(PreDelay != lastPreDelay) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Freeverb3VST_NVerb.dll");
		if(SRCFact != lastSRCFact) {
			client.sendPacket("parameter 0 "+SRCFact);
			lastSRCFact = SRCFact;
		}
		if(Wet != lastWet) {
			client.sendPacket("parameter 1 "+Wet);
			lastWet = Wet;
		}
		if(Dry != lastDry) {
			client.sendPacket("parameter 2 "+Dry);
			lastDry = Dry;
		}
		if(FeedBack != lastFeedBack) {
			client.sendPacket("parameter 3 "+FeedBack);
			lastFeedBack = FeedBack;
		}
		if(Damping != lastDamping) {
			client.sendPacket("parameter 4 "+Damping);
			lastDamping = Damping;
		}
		if(OutLPF != lastOutLPF) {
			client.sendPacket("parameter 5 "+OutLPF);
			lastOutLPF = OutLPF;
		}
		if(InHPF != lastInHPF) {
			client.sendPacket("parameter 6 "+InHPF);
			lastInHPF = InHPF;
		}
		if(RT60 != lastRT60) {
			client.sendPacket("parameter 7 "+RT60);
			lastRT60 = RT60;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 8 "+Width);
			lastWidth = Width;
		}
		if(PreDelay != lastPreDelay) {
			client.sendPacket("parameter 9 "+PreDelay);
			lastPreDelay = PreDelay;
		}
	}

	public override void resetStateTrackers() {
		lastSRCFact = -1f;
		lastWet = -1f;
		lastDry = -1f;
		lastFeedBack = -1f;
		lastDamping = -1f;
		lastOutLPF = -1f;
		lastInHPF = -1f;
		lastRT60 = -1f;
		lastWidth = -1f;
		lastPreDelay = -1f;
	}
}
