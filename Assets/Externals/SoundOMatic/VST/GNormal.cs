using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GNormal")]
public class GNormal : VSTFilter {

	public readonly string pluginPath = "GNormal.dll";

	public override void resetToDefaults() {
		Level = 0.5f;
		Type = 0.0f;
	}

	[Tooltip("-600dB  |  -100dB")]
	[Range(0.0f, 1.0f)]
	public float Level = 0.5f;
	private float lastLevel = -1f;
	public readonly int LevelIndex = 0;
	public readonly string LevelLow = "-600dB";
	public readonly string LevelHigh = "-100dB";

	[Tooltip("DC  |  Noise")]
	[Range(0.0f, 1.0f)]
	public float Type = 0.0f;
	private float lastType = -1f;
	public readonly int TypeIndex = 1;
	public readonly string TypeLow = "DC";
	public readonly string TypeHigh = "Noise";

	public override string getFilterName() {
		return "./vst/GNormal.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Level != lastLevel) isUpdated = true;
		if(Type != lastType) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GNormal.dll");
		if(Level != lastLevel) {
			client.sendPacket("parameter 0 "+Level);
			lastLevel = Level;
		}
		if(Type != lastType) {
			client.sendPacket("parameter 1 "+Type);
			lastType = Type;
		}
	}

	public override void resetStateTrackers() {
		lastLevel = -1f;
		lastType = -1f;
	}
}
