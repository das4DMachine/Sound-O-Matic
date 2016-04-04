using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GGate")]
public class GGate : VSTFilter {

	public readonly string pluginPath = "GGate.dll";

	public override void resetToDefaults() {
		Thresh = 0.062469367f;
		Fade = 0.3939394f;
		Attack = 0.06666667f;
	}

	[Tooltip("-100.0dB  |  -1.0dB")]
	[Range(0.0f, 1.0f)]
	public float Thresh = 0.062469367f;
	private float lastThresh = -1f;
	public readonly int ThreshIndex = 0;
	public readonly string ThreshLow = "-100.0dB";
	public readonly string ThreshHigh = "-1.0dB";

	[Tooltip("0.01s  |  1.00s")]
	[Range(0.0f, 1.0f)]
	public float Fade = 0.3939394f;
	private float lastFade = -1f;
	public readonly int FadeIndex = 1;
	public readonly string FadeLow = "0.01s";
	public readonly string FadeHigh = "1.00s";

	[Tooltip("0.0ms  |  30.0ms")]
	[Range(0.0f, 1.0f)]
	public float Attack = 0.06666667f;
	private float lastAttack = -1f;
	public readonly int AttackIndex = 2;
	public readonly string AttackLow = "0.0ms";
	public readonly string AttackHigh = "30.0ms";

	public override string getFilterName() {
		return "./vst/GGate.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Thresh != lastThresh) isUpdated = true;
		if(Fade != lastFade) isUpdated = true;
		if(Attack != lastAttack) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GGate.dll");
		if(Thresh != lastThresh) {
			client.sendPacket("parameter 0 "+Thresh);
			lastThresh = Thresh;
		}
		if(Fade != lastFade) {
			client.sendPacket("parameter 1 "+Fade);
			lastFade = Fade;
		}
		if(Attack != lastAttack) {
			client.sendPacket("parameter 2 "+Attack);
			lastAttack = Attack;
		}
	}

	public override void resetStateTrackers() {
		lastThresh = -1f;
		lastFade = -1f;
		lastAttack = -1f;
	}
}
