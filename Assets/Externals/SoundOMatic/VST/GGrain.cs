using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GGrain")]
public class GGrain : VSTFilter {

	public readonly string pluginPath = "GGrain.dll";

	public override void resetToDefaults() {
		Grains = 0.375f;
		Size = 0.8f;
		SizeVar = 0.2f;
		Pitch = 0.25f;
		PitchVar = 0.25f;
		Gain = 0.20833333f;
		GainVar = 0.16666667f;
		HiQual = 0.0f;
		Mix = 1.0f;
	}

	[Tooltip("10  |  50")]
	[Range(0.0f, 1.0f)]
	public float Grains = 0.375f;
	private float lastGrains = -1f;
	public readonly int GrainsIndex = 0;
	public readonly string GrainsLow = "10";
	public readonly string GrainsHigh = "50";

	[Tooltip("10ms  |  60ms")]
	[Range(0.0f, 1.0f)]
	public float Size = 0.8f;
	private float lastSize = -1f;
	public readonly int SizeIndex = 1;
	public readonly string SizeLow = "10ms";
	public readonly string SizeHigh = "60ms";

	[Tooltip("0ms  |  25ms")]
	[Range(0.0f, 1.0f)]
	public float SizeVar = 0.2f;
	private float lastSizeVar = -1f;
	public readonly int SizeVarIndex = 2;
	public readonly string SizeVarLow = "0ms";
	public readonly string SizeVarHigh = "25ms";

	[Tooltip("-12.0  |  12.0")]
	[Range(0.0f, 1.0f)]
	public float Pitch = 0.25f;
	private float lastPitch = -1f;
	public readonly int PitchIndex = 3;
	public readonly string PitchLow = "-12.0";
	public readonly string PitchHigh = "12.0";

	[Tooltip("0.0  |  12.0")]
	[Range(0.0f, 1.0f)]
	public float PitchVar = 0.25f;
	private float lastPitchVar = -1f;
	public readonly int PitchVarIndex = 4;
	public readonly string PitchVarLow = "0.0";
	public readonly string PitchVarHigh = "12.0";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.20833333f;
	private float lastGain = -1f;
	public readonly int GainIndex = 5;
	public readonly string GainLow = "-12.0dB";
	public readonly string GainHigh = "12.0dB";

	[Tooltip("0.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float GainVar = 0.16666667f;
	private float lastGainVar = -1f;
	public readonly int GainVarIndex = 6;
	public readonly string GainVarLow = "0.0dB";
	public readonly string GainVarHigh = "12.0dB";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float HiQual = 0.0f;
	private float lastHiQual = -1f;
	public readonly int HiQualIndex = 7;
	public readonly string HiQualLow = "Off";
	public readonly string HiQualHigh = "On";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Mix = 1.0f;
	private float lastMix = -1f;
	public readonly int MixIndex = 8;
	public readonly string MixLow = "0%";
	public readonly string MixHigh = "100%";

	public override string getFilterName() {
		return "./vst/GGrain.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Grains != lastGrains) isUpdated = true;
		if(Size != lastSize) isUpdated = true;
		if(SizeVar != lastSizeVar) isUpdated = true;
		if(Pitch != lastPitch) isUpdated = true;
		if(PitchVar != lastPitchVar) isUpdated = true;
		if(Gain != lastGain) isUpdated = true;
		if(GainVar != lastGainVar) isUpdated = true;
		if(HiQual != lastHiQual) isUpdated = true;
		if(Mix != lastMix) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GGrain.dll");
		if(Grains != lastGrains) {
			client.sendPacket("parameter 0 "+Grains);
			lastGrains = Grains;
		}
		if(Size != lastSize) {
			client.sendPacket("parameter 1 "+Size);
			lastSize = Size;
		}
		if(SizeVar != lastSizeVar) {
			client.sendPacket("parameter 2 "+SizeVar);
			lastSizeVar = SizeVar;
		}
		if(Pitch != lastPitch) {
			client.sendPacket("parameter 3 "+Pitch);
			lastPitch = Pitch;
		}
		if(PitchVar != lastPitchVar) {
			client.sendPacket("parameter 4 "+PitchVar);
			lastPitchVar = PitchVar;
		}
		if(Gain != lastGain) {
			client.sendPacket("parameter 5 "+Gain);
			lastGain = Gain;
		}
		if(GainVar != lastGainVar) {
			client.sendPacket("parameter 6 "+GainVar);
			lastGainVar = GainVar;
		}
		if(HiQual != lastHiQual) {
			client.sendPacket("parameter 7 "+HiQual);
			lastHiQual = HiQual;
		}
		if(Mix != lastMix) {
			client.sendPacket("parameter 8 "+Mix);
			lastMix = Mix;
		}
	}

	public override void resetStateTrackers() {
		lastGrains = -1f;
		lastSize = -1f;
		lastSizeVar = -1f;
		lastPitch = -1f;
		lastPitchVar = -1f;
		lastGain = -1f;
		lastGainVar = -1f;
		lastHiQual = -1f;
		lastMix = -1f;
	}
}
