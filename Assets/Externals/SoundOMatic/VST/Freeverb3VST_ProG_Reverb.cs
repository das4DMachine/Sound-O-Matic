using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Freeverb3VST_ProG_Reverb")]
public class Freeverb3VST_ProG_Reverb : VSTFilter {

	public readonly string pluginPath = "Freeverb3VST_ProG_Reverb.dll";

	public override void resetToDefaults() {
		SRCFact = 0.025f;
		Dry = 0.75f;
		ERefWet = 0.7625f;
		ERefWid = 0.85f;
		ERefFac = 0.55f;
		ERefSend = 0.4f;
		Wet = 0.875f;
		Width = 1.0f;
		PreDelay = 0.52000004f;
		RT60 = 0.5714881f;
		InLPF = 0.94382024f;
		Damping = 0.38202247f;
		BassLPF = 0.45000002f;
		BassFact = 0.3f;
		OutLPF = 0.5505618f;
		OutLPBW = 0.1f;
		Spin = 0.07f;
		Wander = 0.591608f;
	}

	[Tooltip("1-Ax  |  4-Bx")]
	[Range(0.0f, 1.0f)]
	public float SRCFact = 0.025f;
	private float lastSRCFact = -1f;
	public readonly int SRCFactIndex = 0;
	public readonly string SRCFactLow = "1-Ax";
	public readonly string SRCFactHigh = "4-Bx";

	[Tooltip("-70.0000dB  |  10.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 0.75f;
	private float lastDry = -1f;
	public readonly int DryIndex = 1;
	public readonly string DryLow = "-70.0000dB";
	public readonly string DryHigh = "10.00000dB";

	[Tooltip("-70.0000dB  |  10.00000dB")]
	[Range(0.0f, 1.0f)]
	public float ERefWet = 0.7625f;
	private float lastERefWet = -1f;
	public readonly int ERefWetIndex = 2;
	public readonly string ERefWetLow = "-70.0000dB";
	public readonly string ERefWetHigh = "10.00000dB";

	[Tooltip("-1.00000-  |  1.000000-")]
	[Range(0.0f, 1.0f)]
	public float ERefWid = 0.85f;
	private float lastERefWid = -1f;
	public readonly int ERefWidIndex = 3;
	public readonly string ERefWidLow = "-1.00000-";
	public readonly string ERefWidHigh = "1.000000-";

	[Tooltip("0.500000x  |  2.500000x")]
	[Range(0.0f, 1.0f)]
	public float ERefFac = 0.55f;
	private float lastERefFac = -1f;
	public readonly int ERefFacIndex = 4;
	public readonly string ERefFacLow = "0.500000x";
	public readonly string ERefFacHigh = "2.500000x";

	[Tooltip("0.000000-  |  1.000000-")]
	[Range(0.0f, 1.0f)]
	public float ERefSend = 0.4f;
	private float lastERefSend = -1f;
	public readonly int ERefSendIndex = 5;
	public readonly string ERefSendLow = "0.000000-";
	public readonly string ERefSendHigh = "1.000000-";

	[Tooltip("-70.0000dB  |  10.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Wet = 0.875f;
	private float lastWet = -1f;
	public readonly int WetIndex = 6;
	public readonly string WetLow = "-70.0000dB";
	public readonly string WetHigh = "10.00000dB";

	[Tooltip("0.000000-  |  1.000000-")]
	[Range(0.0f, 1.0f)]
	public float Width = 1.0f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 7;
	public readonly string WidthLow = "0.000000-";
	public readonly string WidthHigh = "1.000000-";

	[Tooltip("-500.000ms  |  500.0000ms")]
	[Range(0.0f, 1.0f)]
	public float PreDelay = 0.52000004f;
	private float lastPreDelay = -1f;
	public readonly int PreDelayIndex = 8;
	public readonly string PreDelayLow = "-500.000ms";
	public readonly string PreDelayHigh = "500.0000ms";

	[Tooltip("0.000000s  |  30.00000s")]
	[Range(0.0f, 1.0f)]
	public float RT60 = 0.5714881f;
	private float lastRT60 = -1f;
	public readonly int RT60Index = 9;
	public readonly string RT60Low = "0.000000s";
	public readonly string RT60High = "30.00000s";

	[Tooltip("200.0000Hz  |  18000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float InLPF = 0.94382024f;
	private float lastInLPF = -1f;
	public readonly int InLPFIndex = 10;
	public readonly string InLPFLow = "200.0000Hz";
	public readonly string InLPFHigh = "18000.00Hz";

	[Tooltip("200.0000Hz  |  18000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float Damping = 0.38202247f;
	private float lastDamping = -1f;
	public readonly int DampingIndex = 11;
	public readonly string DampingLow = "200.0000Hz";
	public readonly string DampingHigh = "18000.00Hz";

	[Tooltip("50.00000Hz  |  1050.000Hz")]
	[Range(0.0f, 1.0f)]
	public float BassLPF = 0.45000002f;
	private float lastBassLPF = -1f;
	public readonly int BassLPFIndex = 12;
	public readonly string BassLPFLow = "50.00000Hz";
	public readonly string BassLPFHigh = "1050.000Hz";

	[Tooltip("0.000000-  |  0.500000-")]
	[Range(0.0f, 1.0f)]
	public float BassFact = 0.3f;
	private float lastBassFact = -1f;
	public readonly int BassFactIndex = 13;
	public readonly string BassFactLow = "0.000000-";
	public readonly string BassFactHigh = "0.500000-";

	[Tooltip("200.0000Hz  |  18000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float OutLPF = 0.5505618f;
	private float lastOutLPF = -1f;
	public readonly int OutLPFIndex = 14;
	public readonly string OutLPFLow = "200.0000Hz";
	public readonly string OutLPFHigh = "18000.00Hz";

	[Tooltip("0.500000-  |  5.500000-")]
	[Range(0.0f, 1.0f)]
	public float OutLPBW = 0.1f;
	private float lastOutLPBW = -1f;
	public readonly int OutLPBWIndex = 15;
	public readonly string OutLPBWLow = "0.500000-";
	public readonly string OutLPBWHigh = "5.500000-";

	[Tooltip("0.000000Hz  |  10.00000Hz")]
	[Range(0.0f, 1.0f)]
	public float Spin = 0.07f;
	private float lastSpin = -1f;
	public readonly int SpinIndex = 16;
	public readonly string SpinLow = "0.000000Hz";
	public readonly string SpinHigh = "10.00000Hz";

	[Tooltip("0.000000-  |  1.000000-")]
	[Range(0.0f, 1.0f)]
	public float Wander = 0.591608f;
	private float lastWander = -1f;
	public readonly int WanderIndex = 17;
	public readonly string WanderLow = "0.000000-";
	public readonly string WanderHigh = "1.000000-";

	public override string getFilterName() {
		return "./vst/Freeverb3VST_ProG_Reverb.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(SRCFact != lastSRCFact) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;
		if(ERefWet != lastERefWet) isUpdated = true;
		if(ERefWid != lastERefWid) isUpdated = true;
		if(ERefFac != lastERefFac) isUpdated = true;
		if(ERefSend != lastERefSend) isUpdated = true;
		if(Wet != lastWet) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;
		if(PreDelay != lastPreDelay) isUpdated = true;
		if(RT60 != lastRT60) isUpdated = true;
		if(InLPF != lastInLPF) isUpdated = true;
		if(Damping != lastDamping) isUpdated = true;
		if(BassLPF != lastBassLPF) isUpdated = true;
		if(BassFact != lastBassFact) isUpdated = true;
		if(OutLPF != lastOutLPF) isUpdated = true;
		if(OutLPBW != lastOutLPBW) isUpdated = true;
		if(Spin != lastSpin) isUpdated = true;
		if(Wander != lastWander) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Freeverb3VST_ProG_Reverb.dll");
		if(SRCFact != lastSRCFact) {
			client.sendPacket("parameter 0 "+SRCFact);
			lastSRCFact = SRCFact;
		}
		if(Dry != lastDry) {
			client.sendPacket("parameter 1 "+Dry);
			lastDry = Dry;
		}
		if(ERefWet != lastERefWet) {
			client.sendPacket("parameter 2 "+ERefWet);
			lastERefWet = ERefWet;
		}
		if(ERefWid != lastERefWid) {
			client.sendPacket("parameter 3 "+ERefWid);
			lastERefWid = ERefWid;
		}
		if(ERefFac != lastERefFac) {
			client.sendPacket("parameter 4 "+ERefFac);
			lastERefFac = ERefFac;
		}
		if(ERefSend != lastERefSend) {
			client.sendPacket("parameter 5 "+ERefSend);
			lastERefSend = ERefSend;
		}
		if(Wet != lastWet) {
			client.sendPacket("parameter 6 "+Wet);
			lastWet = Wet;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 7 "+Width);
			lastWidth = Width;
		}
		if(PreDelay != lastPreDelay) {
			client.sendPacket("parameter 8 "+PreDelay);
			lastPreDelay = PreDelay;
		}
		if(RT60 != lastRT60) {
			client.sendPacket("parameter 9 "+RT60);
			lastRT60 = RT60;
		}
		if(InLPF != lastInLPF) {
			client.sendPacket("parameter 10 "+InLPF);
			lastInLPF = InLPF;
		}
		if(Damping != lastDamping) {
			client.sendPacket("parameter 11 "+Damping);
			lastDamping = Damping;
		}
		if(BassLPF != lastBassLPF) {
			client.sendPacket("parameter 12 "+BassLPF);
			lastBassLPF = BassLPF;
		}
		if(BassFact != lastBassFact) {
			client.sendPacket("parameter 13 "+BassFact);
			lastBassFact = BassFact;
		}
		if(OutLPF != lastOutLPF) {
			client.sendPacket("parameter 14 "+OutLPF);
			lastOutLPF = OutLPF;
		}
		if(OutLPBW != lastOutLPBW) {
			client.sendPacket("parameter 15 "+OutLPBW);
			lastOutLPBW = OutLPBW;
		}
		if(Spin != lastSpin) {
			client.sendPacket("parameter 16 "+Spin);
			lastSpin = Spin;
		}
		if(Wander != lastWander) {
			client.sendPacket("parameter 17 "+Wander);
			lastWander = Wander;
		}
	}

	public override void resetStateTrackers() {
		lastSRCFact = -1f;
		lastDry = -1f;
		lastERefWet = -1f;
		lastERefWid = -1f;
		lastERefFac = -1f;
		lastERefSend = -1f;
		lastWet = -1f;
		lastWidth = -1f;
		lastPreDelay = -1f;
		lastRT60 = -1f;
		lastInLPF = -1f;
		lastDamping = -1f;
		lastBassLPF = -1f;
		lastBassFact = -1f;
		lastOutLPF = -1f;
		lastOutLPBW = -1f;
		lastSpin = -1f;
		lastWander = -1f;
	}
}
