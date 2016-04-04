using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GComp2")]
public class GComp2 : VSTFilter {

	public readonly string pluginPath = "GComp2.dll";

	public override void resetToDefaults() {
		Gain = 0.5f;
		LoCut = 0.0f;
		HiCut = 1.0f;
		Gate = 0.2020202f;
		Compress = 0.5f;
		Attack = 0.5f;
		Release = 0.79591835f;
		Output = 0.5f;
	}

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.5f;
	private float lastGain = -1f;
	public readonly int GainIndex = 0;
	public readonly string GainLow = "-12.0dB";
	public readonly string GainHigh = "12.0dB";

	[Tooltip("20Hz  |  20000Hz")]
	[Range(0.0f, 1.0f)]
	public float LoCut = 0.0f;
	private float lastLoCut = -1f;
	public readonly int LoCutIndex = 1;
	public readonly string LoCutLow = "20Hz";
	public readonly string LoCutHigh = "20000Hz";

	[Tooltip("20Hz  |  20000Hz")]
	[Range(0.0f, 1.0f)]
	public float HiCut = 1.0f;
	private float lastHiCut = -1f;
	public readonly int HiCutIndex = 2;
	public readonly string HiCutLow = "20Hz";
	public readonly string HiCutHigh = "20000Hz";

	[Tooltip("-100dB  |  -1dB")]
	[Range(0.0f, 1.0f)]
	public float Gate = 0.2020202f;
	private float lastGate = -1f;
	public readonly int GateIndex = 3;
	public readonly string GateLow = "-100dB";
	public readonly string GateHigh = "-1dB";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Compress = 0.5f;
	private float lastCompress = -1f;
	public readonly int CompressIndex = 4;
	public readonly string CompressLow = "0%";
	public readonly string CompressHigh = "100%";

	[Tooltip("0.0ms  |  10.0ms")]
	[Range(0.0f, 1.0f)]
	public float Attack = 0.5f;
	private float lastAttack = -1f;
	public readonly int AttackIndex = 5;
	public readonly string AttackLow = "0.0ms";
	public readonly string AttackHigh = "10.0ms";

	[Tooltip("0.01s  |  0.50s")]
	[Range(0.0f, 1.0f)]
	public float Release = 0.79591835f;
	private float lastRelease = -1f;
	public readonly int ReleaseIndex = 6;
	public readonly string ReleaseLow = "0.01s";
	public readonly string ReleaseHigh = "0.50s";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float Output = 0.5f;
	private float lastOutput = -1f;
	public readonly int OutputIndex = 7;
	public readonly string OutputLow = "-12.0dB";
	public readonly string OutputHigh = "12.0dB";

	public override string getFilterName() {
		return "./vst/GComp2.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;
		if(LoCut != lastLoCut) isUpdated = true;
		if(HiCut != lastHiCut) isUpdated = true;
		if(Gate != lastGate) isUpdated = true;
		if(Compress != lastCompress) isUpdated = true;
		if(Attack != lastAttack) isUpdated = true;
		if(Release != lastRelease) isUpdated = true;
		if(Output != lastOutput) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GComp2.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
		if(LoCut != lastLoCut) {
			client.sendPacket("parameter 1 "+LoCut);
			lastLoCut = LoCut;
		}
		if(HiCut != lastHiCut) {
			client.sendPacket("parameter 2 "+HiCut);
			lastHiCut = HiCut;
		}
		if(Gate != lastGate) {
			client.sendPacket("parameter 3 "+Gate);
			lastGate = Gate;
		}
		if(Compress != lastCompress) {
			client.sendPacket("parameter 4 "+Compress);
			lastCompress = Compress;
		}
		if(Attack != lastAttack) {
			client.sendPacket("parameter 5 "+Attack);
			lastAttack = Attack;
		}
		if(Release != lastRelease) {
			client.sendPacket("parameter 6 "+Release);
			lastRelease = Release;
		}
		if(Output != lastOutput) {
			client.sendPacket("parameter 7 "+Output);
			lastOutput = Output;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
		lastLoCut = -1f;
		lastHiCut = -1f;
		lastGate = -1f;
		lastCompress = -1f;
		lastAttack = -1f;
		lastRelease = -1f;
		lastOutput = -1f;
	}
}
