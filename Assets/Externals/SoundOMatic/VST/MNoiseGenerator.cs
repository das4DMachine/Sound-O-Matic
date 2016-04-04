using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MNoiseGenerator")]
public class MNoiseGenerator : VSTFilter {

	public readonly string pluginPath = "MNoiseGenerator.dll";

	public override void resetToDefaults() {
		Wet = 0.8408964f;
		Mode = 0.0f;
		Probability = 0.31622776f;
		Dry = 0.0f;
	}

	[Tooltip("silence  |  0.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Wet = 0.8408964f;
	private float lastWet = -1f;
	public readonly int WetIndex = 0;
	public readonly string WetLow = "silence";
	public readonly string WetHigh = "0.00 dB";

	[Tooltip("White noise  |  Stairs")]
	[Range(0.0f, 1.0f)]
	public float Mode = 0.0f;
	private float lastMode = -1f;
	public readonly int ModeIndex = 1;
	public readonly string ModeLow = "White noise";
	public readonly string ModeHigh = "Stairs";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Probability = 0.31622776f;
	private float lastProbability = -1f;
	public readonly int ProbabilityIndex = 2;
	public readonly string ProbabilityLow = "0.00%";
	public readonly string ProbabilityHigh = "100.0%";

	[Tooltip("silence  |  0.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 0.0f;
	private float lastDry = -1f;
	public readonly int DryIndex = 123;
	public readonly string DryLow = "silence";
	public readonly string DryHigh = "0.00 dB";

	public override string getFilterName() {
		return "./vst/MNoiseGenerator.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Wet != lastWet) isUpdated = true;
		if(Mode != lastMode) isUpdated = true;
		if(Probability != lastProbability) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MNoiseGenerator.dll");
		if(Wet != lastWet) {
			client.sendPacket("parameter 0 "+Wet);
			lastWet = Wet;
		}
		if(Mode != lastMode) {
			client.sendPacket("parameter 1 "+Mode);
			lastMode = Mode;
		}
		if(Probability != lastProbability) {
			client.sendPacket("parameter 2 "+Probability);
			lastProbability = Probability;
		}
		if(Dry != lastDry) {
			client.sendPacket("parameter 123 "+Dry);
			lastDry = Dry;
		}
	}

	public override void resetStateTrackers() {
		lastWet = -1f;
		lastMode = -1f;
		lastProbability = -1f;
		lastDry = -1f;
	}
}
