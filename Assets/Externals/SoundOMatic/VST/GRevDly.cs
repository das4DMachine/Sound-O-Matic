using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GRevDly")]
public class GRevDly : VSTFilter {

	public readonly string pluginPath = "GRevDly.dll";

	public override void resetToDefaults() {
		Time = 0.7487437f;
		Overlap = 1.0f;
		Effect = 0.5956621f;
		Dry = 1.0f;
	}

	[Tooltip("5.0ms  |  1000.0ms")]
	[Range(0.0f, 1.0f)]
	public float Time = 0.7487437f;
	private float lastTime = -1f;
	public readonly int TimeIndex = 0;
	public readonly string TimeLow = "5.0ms";
	public readonly string TimeHigh = "1000.0ms";

	[Tooltip("5%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Overlap = 1.0f;
	private float lastOverlap = -1f;
	public readonly int OverlapIndex = 1;
	public readonly string OverlapLow = "5%";
	public readonly string OverlapHigh = "100%";

	[Tooltip("-InfdB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Effect = 0.5956621f;
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
		return "./vst/GRevDly.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Time != lastTime) isUpdated = true;
		if(Overlap != lastOverlap) isUpdated = true;
		if(Effect != lastEffect) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GRevDly.dll");
		if(Time != lastTime) {
			client.sendPacket("parameter 0 "+Time);
			lastTime = Time;
		}
		if(Overlap != lastOverlap) {
			client.sendPacket("parameter 1 "+Overlap);
			lastOverlap = Overlap;
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
		lastTime = -1f;
		lastOverlap = -1f;
		lastEffect = -1f;
		lastDry = -1f;
	}
}
