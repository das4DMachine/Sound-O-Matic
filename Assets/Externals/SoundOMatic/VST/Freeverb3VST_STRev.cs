using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Freeverb3VST_STRev")]
public class Freeverb3VST_STRev : VSTFilter {

	public readonly string pluginPath = "Freeverb3VST_STRev.dll";

	public override void resetToDefaults() {
		SRCFact = 0.0f;
		Dry = 0.76363635f;
		Wet = 0.7181818f;
		Width = 1.0f;
		PreDelay = 0.51000005f;
		RT60 = 0.125f;
		InLPF = 0.5833333f;
		Damping = 0.15833333f;
		OutLPF = 0.375f;
		ModFq = 0.080000006f;
		ModStr = 0.4f;
	}

	[Tooltip("1X  |  6X")]
	[Range(0.0f, 1.0f)]
	public float SRCFact = 0.0f;
	private float lastSRCFact = -1f;
	public readonly int SRCFactIndex = 0;
	public readonly string SRCFactLow = "1X";
	public readonly string SRCFactHigh = "6X";

	[Tooltip("-90.0000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 0.76363635f;
	private float lastDry = -1f;
	public readonly int DryIndex = 1;
	public readonly string DryLow = "-90.0000dB";
	public readonly string DryHigh = "20.00000dB";

	[Tooltip("-90.0000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Wet = 0.7181818f;
	private float lastWet = -1f;
	public readonly int WetIndex = 2;
	public readonly string WetLow = "-90.0000dB";
	public readonly string WetHigh = "20.00000dB";

	[Tooltip("0.000000_  |  1.000000_")]
	[Range(0.0f, 1.0f)]
	public float Width = 1.0f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 3;
	public readonly string WidthLow = "0.000000_";
	public readonly string WidthHigh = "1.000000_";

	[Tooltip("-500.000ms  |  500.0000ms")]
	[Range(0.0f, 1.0f)]
	public float PreDelay = 0.51000005f;
	private float lastPreDelay = -1f;
	public readonly int PreDelayIndex = 4;
	public readonly string PreDelayLow = "-500.000ms";
	public readonly string PreDelayHigh = "500.0000ms";

	[Tooltip("0.000000s  |  16.00000s")]
	[Range(0.0f, 1.0f)]
	public float RT60 = 0.125f;
	private float lastRT60 = -1f;
	public readonly int RT60Index = 5;
	public readonly string RT60Low = "0.000000s";
	public readonly string RT60High = "16.00000s";

	[Tooltip("0.000000Hz  |  24000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float InLPF = 0.5833333f;
	private float lastInLPF = -1f;
	public readonly int InLPFIndex = 6;
	public readonly string InLPFLow = "0.000000Hz";
	public readonly string InLPFHigh = "24000.00Hz";

	[Tooltip("0.000000Hz  |  24000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float Damping = 0.15833333f;
	private float lastDamping = -1f;
	public readonly int DampingIndex = 7;
	public readonly string DampingLow = "0.000000Hz";
	public readonly string DampingHigh = "24000.00Hz";

	[Tooltip("0.000000Hz  |  24000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float OutLPF = 0.375f;
	private float lastOutLPF = -1f;
	public readonly int OutLPFIndex = 8;
	public readonly string OutLPFLow = "0.000000Hz";
	public readonly string OutLPFHigh = "24000.00Hz";

	[Tooltip("0.000000Hz  |  10.00000Hz")]
	[Range(0.0f, 1.0f)]
	public float ModFq = 0.080000006f;
	private float lastModFq = -1f;
	public readonly int ModFqIndex = 9;
	public readonly string ModFqLow = "0.000000Hz";
	public readonly string ModFqHigh = "10.00000Hz";

	[Tooltip("0.000000_  |  1.000000_")]
	[Range(0.0f, 1.0f)]
	public float ModStr = 0.4f;
	private float lastModStr = -1f;
	public readonly int ModStrIndex = 10;
	public readonly string ModStrLow = "0.000000_";
	public readonly string ModStrHigh = "1.000000_";

	public override string getFilterName() {
		return "./vst/Freeverb3VST_STRev.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(SRCFact != lastSRCFact) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;
		if(Wet != lastWet) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;
		if(PreDelay != lastPreDelay) isUpdated = true;
		if(RT60 != lastRT60) isUpdated = true;
		if(InLPF != lastInLPF) isUpdated = true;
		if(Damping != lastDamping) isUpdated = true;
		if(OutLPF != lastOutLPF) isUpdated = true;
		if(ModFq != lastModFq) isUpdated = true;
		if(ModStr != lastModStr) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Freeverb3VST_STRev.dll");
		if(SRCFact != lastSRCFact) {
			client.sendPacket("parameter 0 "+SRCFact);
			lastSRCFact = SRCFact;
		}
		if(Dry != lastDry) {
			client.sendPacket("parameter 1 "+Dry);
			lastDry = Dry;
		}
		if(Wet != lastWet) {
			client.sendPacket("parameter 2 "+Wet);
			lastWet = Wet;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 3 "+Width);
			lastWidth = Width;
		}
		if(PreDelay != lastPreDelay) {
			client.sendPacket("parameter 4 "+PreDelay);
			lastPreDelay = PreDelay;
		}
		if(RT60 != lastRT60) {
			client.sendPacket("parameter 5 "+RT60);
			lastRT60 = RT60;
		}
		if(InLPF != lastInLPF) {
			client.sendPacket("parameter 6 "+InLPF);
			lastInLPF = InLPF;
		}
		if(Damping != lastDamping) {
			client.sendPacket("parameter 7 "+Damping);
			lastDamping = Damping;
		}
		if(OutLPF != lastOutLPF) {
			client.sendPacket("parameter 8 "+OutLPF);
			lastOutLPF = OutLPF;
		}
		if(ModFq != lastModFq) {
			client.sendPacket("parameter 9 "+ModFq);
			lastModFq = ModFq;
		}
		if(ModStr != lastModStr) {
			client.sendPacket("parameter 10 "+ModStr);
			lastModStr = ModStr;
		}
	}

	public override void resetStateTrackers() {
		lastSRCFact = -1f;
		lastDry = -1f;
		lastWet = -1f;
		lastWidth = -1f;
		lastPreDelay = -1f;
		lastRT60 = -1f;
		lastInLPF = -1f;
		lastDamping = -1f;
		lastOutLPF = -1f;
		lastModFq = -1f;
		lastModStr = -1f;
	}
}
