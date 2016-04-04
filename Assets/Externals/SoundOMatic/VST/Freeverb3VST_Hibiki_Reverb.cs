using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Freeverb3VST_Hibiki_Reverb")]
public class Freeverb3VST_Hibiki_Reverb : VSTFilter {

	public readonly string pluginPath = "Freeverb3VST_Hibiki_Reverb.dll";

	public override void resetToDefaults() {
		SRCFact = 0.25f;
		Dry = 0.75f;
		ERefWet = 0.75f;
		ERefWid = 0.85f;
		ERefFac = 0.5848035f;
		ERefSend = 0.4f;
		LateWet = 0.75f;
		Width = 1.0f;
		PreDelay = 0.13416408f;
		RoomSize = 0.7402018f;
		RT60 = 0.6517801f;
		XOLow = 0.15811388f;
		XOHigh = 0.5458938f;
		RT60LoG = 0.25f;
		RT60HiG = 0.037499998f;
		Diffuse = 0.9f;
		FDNApFb = 0.9f;
		EarlyLPF = 1.0f;
		EarlyHPF = 0.014142135f;
		LateLPF = 0.8062258f;
		LateHPF = 0.014142135f;
		LFO1 = 0.29999998f;
		LFO2 = 0.3605551f;
		LFOFact = 0.3f;
		Spin = 0.48989797f;
		Wander = 0.73333335f;
		SpinFact = 0.3f;
		RevType = 0.0f;
	}

	[Tooltip("1x  |  4x")]
	[Range(0.0f, 1.0f)]
	public float SRCFact = 0.25f;
	private float lastSRCFact = -1f;
	public readonly int SRCFactIndex = 0;
	public readonly string SRCFactLow = "1x";
	public readonly string SRCFactHigh = "4x";

	[Tooltip("-70.0000dB  |  10.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 0.75f;
	private float lastDry = -1f;
	public readonly int DryIndex = 1;
	public readonly string DryLow = "-70.0000dB";
	public readonly string DryHigh = "10.00000dB";

	[Tooltip("-70.0000dB  |  10.00000dB")]
	[Range(0.0f, 1.0f)]
	public float ERefWet = 0.75f;
	private float lastERefWet = -1f;
	public readonly int ERefWetIndex = 2;
	public readonly string ERefWetLow = "-70.0000dB";
	public readonly string ERefWetHigh = "10.00000dB";

	[Tooltip("-1.00000x  |  1.000000x")]
	[Range(0.0f, 1.0f)]
	public float ERefWid = 0.85f;
	private float lastERefWid = -1f;
	public readonly int ERefWidIndex = 3;
	public readonly string ERefWidLow = "-1.00000x";
	public readonly string ERefWidHigh = "1.000000x";

	[Tooltip("1.000000m  |  26.00000m")]
	[Range(0.0f, 1.0f)]
	public float ERefFac = 0.5848035f;
	private float lastERefFac = -1f;
	public readonly int ERefFacIndex = 4;
	public readonly string ERefFacLow = "1.000000m";
	public readonly string ERefFacHigh = "26.00000m";

	[Tooltip("0.000000x  |  1.000000x")]
	[Range(0.0f, 1.0f)]
	public float ERefSend = 0.4f;
	private float lastERefSend = -1f;
	public readonly int ERefSendIndex = 5;
	public readonly string ERefSendLow = "0.000000x";
	public readonly string ERefSendHigh = "1.000000x";

	[Tooltip("-70.0000dB  |  10.00000dB")]
	[Range(0.0f, 1.0f)]
	public float LateWet = 0.75f;
	private float lastLateWet = -1f;
	public readonly int LateWetIndex = 6;
	public readonly string LateWetLow = "-70.0000dB";
	public readonly string LateWetHigh = "10.00000dB";

	[Tooltip("-1.00000x  |  1.000000x")]
	[Range(0.0f, 1.0f)]
	public float Width = 1.0f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 7;
	public readonly string WidthLow = "-1.00000x";
	public readonly string WidthHigh = "1.000000x";

	[Tooltip("0.000000ms  |  1000.000ms")]
	[Range(0.0f, 1.0f)]
	public float PreDelay = 0.13416408f;
	private float lastPreDelay = -1f;
	public readonly int PreDelayIndex = 8;
	public readonly string PreDelayLow = "0.000000ms";
	public readonly string PreDelayHigh = "1000.000ms";

	[Tooltip("2.000000m  |  182.0000m")]
	[Range(0.0f, 1.0f)]
	public float RoomSize = 0.7402018f;
	private float lastRoomSize = -1f;
	public readonly int RoomSizeIndex = 9;
	public readonly string RoomSizeLow = "2.000000m";
	public readonly string RoomSizeHigh = "182.0000m";

	[Tooltip("0.200000s  |  30.20000s")]
	[Range(0.0f, 1.0f)]
	public float RT60 = 0.6517801f;
	private float lastRT60 = -1f;
	public readonly int RT60Index = 10;
	public readonly string RT60Low = "0.200000s";
	public readonly string RT60High = "30.20000s";

	[Tooltip("40.00000Hz  |  18040.00Hz")]
	[Range(0.0f, 1.0f)]
	public float XOLow = 0.15811388f;
	private float lastXOLow = -1f;
	public readonly int XOLowIndex = 11;
	public readonly string XOLowLow = "40.00000Hz";
	public readonly string XOLowHigh = "18040.00Hz";

	[Tooltip("40.00000Hz  |  20040.00Hz")]
	[Range(0.0f, 1.0f)]
	public float XOHigh = 0.5458938f;
	private float lastXOHigh = -1f;
	public readonly int XOHighIndex = 12;
	public readonly string XOHighLow = "40.00000Hz";
	public readonly string XOHighHigh = "20040.00Hz";

	[Tooltip("0.200000x  |  4.199999x")]
	[Range(0.0f, 1.0f)]
	public float RT60LoG = 0.25f;
	private float lastRT60LoG = -1f;
	public readonly int RT60LoGIndex = 13;
	public readonly string RT60LoGLow = "0.200000x";
	public readonly string RT60LoGHigh = "4.199999x";

	[Tooltip("0.200000x  |  4.199999x")]
	[Range(0.0f, 1.0f)]
	public float RT60HiG = 0.037499998f;
	private float lastRT60HiG = -1f;
	public readonly int RT60HiGIndex = 14;
	public readonly string RT60HiGLow = "0.200000x";
	public readonly string RT60HiGHigh = "4.199999x";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float Diffuse = 0.9f;
	private float lastDiffuse = -1f;
	public readonly int DiffuseIndex = 15;
	public readonly string DiffuseLow = "0.000000%";
	public readonly string DiffuseHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float FDNApFb = 0.9f;
	private float lastFDNApFb = -1f;
	public readonly int FDNApFbIndex = 16;
	public readonly string FDNApFbLow = "0.000000%";
	public readonly string FDNApFbHigh = "100.0000%";

	[Tooltip("0.000000Hz  |  20000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float EarlyLPF = 1.0f;
	private float lastEarlyLPF = -1f;
	public readonly int EarlyLPFIndex = 17;
	public readonly string EarlyLPFLow = "0.000000Hz";
	public readonly string EarlyLPFHigh = "20000.00Hz";

	[Tooltip("0.000000Hz  |  20000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float EarlyHPF = 0.014142135f;
	private float lastEarlyHPF = -1f;
	public readonly int EarlyHPFIndex = 18;
	public readonly string EarlyHPFLow = "0.000000Hz";
	public readonly string EarlyHPFHigh = "20000.00Hz";

	[Tooltip("0.000000Hz  |  20000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float LateLPF = 0.8062258f;
	private float lastLateLPF = -1f;
	public readonly int LateLPFIndex = 19;
	public readonly string LateLPFLow = "0.000000Hz";
	public readonly string LateLPFHigh = "20000.00Hz";

	[Tooltip("0.000000Hz  |  20000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float LateHPF = 0.014142135f;
	private float lastLateHPF = -1f;
	public readonly int LateHPFIndex = 20;
	public readonly string LateHPFLow = "0.000000Hz";
	public readonly string LateHPFHigh = "20000.00Hz";

	[Tooltip("0.000000Hz  |  10.00000Hz")]
	[Range(0.0f, 1.0f)]
	public float LFO1 = 0.29999998f;
	private float lastLFO1 = -1f;
	public readonly int LFO1Index = 21;
	public readonly string LFO1Low = "0.000000Hz";
	public readonly string LFO1High = "10.00000Hz";

	[Tooltip("0.000000Hz  |  10.00000Hz")]
	[Range(0.0f, 1.0f)]
	public float LFO2 = 0.3605551f;
	private float lastLFO2 = -1f;
	public readonly int LFO2Index = 22;
	public readonly string LFO2Low = "0.000000Hz";
	public readonly string LFO2High = "10.00000Hz";

	[Tooltip("0.000000x  |  1.000000x")]
	[Range(0.0f, 1.0f)]
	public float LFOFact = 0.3f;
	private float lastLFOFact = -1f;
	public readonly int LFOFactIndex = 23;
	public readonly string LFOFactLow = "0.000000x";
	public readonly string LFOFactHigh = "1.000000x";

	[Tooltip("0.000000Hz  |  10.00000Hz")]
	[Range(0.0f, 1.0f)]
	public float Spin = 0.48989797f;
	private float lastSpin = -1f;
	public readonly int SpinIndex = 24;
	public readonly string SpinLow = "0.000000Hz";
	public readonly string SpinHigh = "10.00000Hz";

	[Tooltip("0.000000ms  |  30.00000ms")]
	[Range(0.0f, 1.0f)]
	public float Wander = 0.73333335f;
	private float lastWander = -1f;
	public readonly int WanderIndex = 25;
	public readonly string WanderLow = "0.000000ms";
	public readonly string WanderHigh = "30.00000ms";

	[Tooltip("0.000000x  |  1.000000x")]
	[Range(0.0f, 1.0f)]
	public float SpinFact = 0.3f;
	private float lastSpinFact = -1f;
	public readonly int SpinFactIndex = 26;
	public readonly string SpinFactLow = "0.000000x";
	public readonly string SpinFactHigh = "1.000000x";

	[Tooltip("1TL  |  1TL")]
	[Range(0.0f, 1.0f)]
	public float RevType = 0.0f;
	private float lastRevType = -1f;
	public readonly int RevTypeIndex = 27;
	public readonly string RevTypeLow = "1TL";
	public readonly string RevTypeHigh = "1TL";

	public override string getFilterName() {
		return "./vst/Freeverb3VST_Hibiki_Reverb.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(SRCFact != lastSRCFact) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;
		if(ERefWet != lastERefWet) isUpdated = true;
		if(ERefWid != lastERefWid) isUpdated = true;
		if(ERefFac != lastERefFac) isUpdated = true;
		if(ERefSend != lastERefSend) isUpdated = true;
		if(LateWet != lastLateWet) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;
		if(PreDelay != lastPreDelay) isUpdated = true;
		if(RoomSize != lastRoomSize) isUpdated = true;
		if(RT60 != lastRT60) isUpdated = true;
		if(XOLow != lastXOLow) isUpdated = true;
		if(XOHigh != lastXOHigh) isUpdated = true;
		if(RT60LoG != lastRT60LoG) isUpdated = true;
		if(RT60HiG != lastRT60HiG) isUpdated = true;
		if(Diffuse != lastDiffuse) isUpdated = true;
		if(FDNApFb != lastFDNApFb) isUpdated = true;
		if(EarlyLPF != lastEarlyLPF) isUpdated = true;
		if(EarlyHPF != lastEarlyHPF) isUpdated = true;
		if(LateLPF != lastLateLPF) isUpdated = true;
		if(LateHPF != lastLateHPF) isUpdated = true;
		if(LFO1 != lastLFO1) isUpdated = true;
		if(LFO2 != lastLFO2) isUpdated = true;
		if(LFOFact != lastLFOFact) isUpdated = true;
		if(Spin != lastSpin) isUpdated = true;
		if(Wander != lastWander) isUpdated = true;
		if(SpinFact != lastSpinFact) isUpdated = true;
		if(RevType != lastRevType) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Freeverb3VST_Hibiki_Reverb.dll");
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
		if(LateWet != lastLateWet) {
			client.sendPacket("parameter 6 "+LateWet);
			lastLateWet = LateWet;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 7 "+Width);
			lastWidth = Width;
		}
		if(PreDelay != lastPreDelay) {
			client.sendPacket("parameter 8 "+PreDelay);
			lastPreDelay = PreDelay;
		}
		if(RoomSize != lastRoomSize) {
			client.sendPacket("parameter 9 "+RoomSize);
			lastRoomSize = RoomSize;
		}
		if(RT60 != lastRT60) {
			client.sendPacket("parameter 10 "+RT60);
			lastRT60 = RT60;
		}
		if(XOLow != lastXOLow) {
			client.sendPacket("parameter 11 "+XOLow);
			lastXOLow = XOLow;
		}
		if(XOHigh != lastXOHigh) {
			client.sendPacket("parameter 12 "+XOHigh);
			lastXOHigh = XOHigh;
		}
		if(RT60LoG != lastRT60LoG) {
			client.sendPacket("parameter 13 "+RT60LoG);
			lastRT60LoG = RT60LoG;
		}
		if(RT60HiG != lastRT60HiG) {
			client.sendPacket("parameter 14 "+RT60HiG);
			lastRT60HiG = RT60HiG;
		}
		if(Diffuse != lastDiffuse) {
			client.sendPacket("parameter 15 "+Diffuse);
			lastDiffuse = Diffuse;
		}
		if(FDNApFb != lastFDNApFb) {
			client.sendPacket("parameter 16 "+FDNApFb);
			lastFDNApFb = FDNApFb;
		}
		if(EarlyLPF != lastEarlyLPF) {
			client.sendPacket("parameter 17 "+EarlyLPF);
			lastEarlyLPF = EarlyLPF;
		}
		if(EarlyHPF != lastEarlyHPF) {
			client.sendPacket("parameter 18 "+EarlyHPF);
			lastEarlyHPF = EarlyHPF;
		}
		if(LateLPF != lastLateLPF) {
			client.sendPacket("parameter 19 "+LateLPF);
			lastLateLPF = LateLPF;
		}
		if(LateHPF != lastLateHPF) {
			client.sendPacket("parameter 20 "+LateHPF);
			lastLateHPF = LateHPF;
		}
		if(LFO1 != lastLFO1) {
			client.sendPacket("parameter 21 "+LFO1);
			lastLFO1 = LFO1;
		}
		if(LFO2 != lastLFO2) {
			client.sendPacket("parameter 22 "+LFO2);
			lastLFO2 = LFO2;
		}
		if(LFOFact != lastLFOFact) {
			client.sendPacket("parameter 23 "+LFOFact);
			lastLFOFact = LFOFact;
		}
		if(Spin != lastSpin) {
			client.sendPacket("parameter 24 "+Spin);
			lastSpin = Spin;
		}
		if(Wander != lastWander) {
			client.sendPacket("parameter 25 "+Wander);
			lastWander = Wander;
		}
		if(SpinFact != lastSpinFact) {
			client.sendPacket("parameter 26 "+SpinFact);
			lastSpinFact = SpinFact;
		}
		if(RevType != lastRevType) {
			client.sendPacket("parameter 27 "+RevType);
			lastRevType = RevType;
		}
	}

	public override void resetStateTrackers() {
		lastSRCFact = -1f;
		lastDry = -1f;
		lastERefWet = -1f;
		lastERefWid = -1f;
		lastERefFac = -1f;
		lastERefSend = -1f;
		lastLateWet = -1f;
		lastWidth = -1f;
		lastPreDelay = -1f;
		lastRoomSize = -1f;
		lastRT60 = -1f;
		lastXOLow = -1f;
		lastXOHigh = -1f;
		lastRT60LoG = -1f;
		lastRT60HiG = -1f;
		lastDiffuse = -1f;
		lastFDNApFb = -1f;
		lastEarlyLPF = -1f;
		lastEarlyHPF = -1f;
		lastLateLPF = -1f;
		lastLateHPF = -1f;
		lastLFO1 = -1f;
		lastLFO2 = -1f;
		lastLFOFact = -1f;
		lastSpin = -1f;
		lastWander = -1f;
		lastSpinFact = -1f;
		lastRevType = -1f;
	}
}
