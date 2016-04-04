using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GDelay")]
public class GDelay : VSTFilter {

	public readonly string pluginPath = "GDelay.dll";

	public override void resetToDefaults() {
		Delay = 0.09954978f;
		Feedback = 0.0f;
		Effect = 0.70794576f;
		Dry = 1.0f;
	}

	[Tooltip("1.0ms  |  2000.0ms")]
	[Range(0.0f, 1.0f)]
	public float Delay = 0.09954978f;
	private float lastDelay = -1f;
	public readonly int DelayIndex = 0;
	public readonly string DelayLow = "1.0ms";
	public readonly string DelayHigh = "2000.0ms";

	[Tooltip("-InfdB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Feedback = 0.0f;
	private float lastFeedback = -1f;
	public readonly int FeedbackIndex = 1;
	public readonly string FeedbackLow = "-InfdB";
	public readonly string FeedbackHigh = "0.0dB";

	[Tooltip("-InfdB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Effect = 0.70794576f;
	private float lastEffect = -1f;
	public readonly int EffectIndex = 2;
	public readonly string EffectLow = "-InfdB";
	public readonly string EffectHigh = "0.0dB";

	[Tooltip("-InfdB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 1.0f;
	private float lastDry = -1f;
	public readonly int DryIndex = 3;
	public readonly string DryLow = "-InfdB";
	public readonly string DryHigh = "0.0dB";

	public override string getFilterName() {
		return "./vst/GDelay.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Delay != lastDelay) isUpdated = true;
		if(Feedback != lastFeedback) isUpdated = true;
		if(Effect != lastEffect) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GDelay.dll");
		if(Delay != lastDelay) {
			client.sendPacket("parameter 0 "+Delay);
			lastDelay = Delay;
		}
		if(Feedback != lastFeedback) {
			client.sendPacket("parameter 1 "+Feedback);
			lastFeedback = Feedback;
		}
		if(Effect != lastEffect) {
			client.sendPacket("parameter 2 "+Effect);
			lastEffect = Effect;
		}
		if(Dry != lastDry) {
			client.sendPacket("parameter 3 "+Dry);
			lastDry = Dry;
		}
	}

	public override void resetStateTrackers() {
		lastDelay = -1f;
		lastFeedback = -1f;
		lastEffect = -1f;
		lastDry = -1f;
	}
}
