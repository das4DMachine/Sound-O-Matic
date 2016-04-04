using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GDuckDly")]
public class GDuckDly : VSTFilter {

	public readonly string pluginPath = "GDuckDly.dll";

	public override void resetToDefaults() {
		Delay = 0.12456228f;
		Feedback = 0.7943282f;
		Attack = 0.08163265f;
		Release = 0.051282052f;
		Amount = 0.5f;
		Effect = 0.5956621f;
		Dry = 1.0f;
		PostComp = 1.0f;
	}

	[Tooltip("1.0ms  |  2000.0ms")]
	[Range(0.0f, 1.0f)]
	public float Delay = 0.12456228f;
	private float lastDelay = -1f;
	public readonly int DelayIndex = 0;
	public readonly string DelayLow = "1.0ms";
	public readonly string DelayHigh = "2000.0ms";

	[Tooltip("-InfdB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Feedback = 0.7943282f;
	private float lastFeedback = -1f;
	public readonly int FeedbackIndex = 1;
	public readonly string FeedbackLow = "-InfdB";
	public readonly string FeedbackHigh = "0.0dB";

	[Tooltip("1ms  |  50ms")]
	[Range(0.0f, 1.0f)]
	public float Attack = 0.08163265f;
	private float lastAttack = -1f;
	public readonly int AttackIndex = 2;
	public readonly string AttackLow = "1ms";
	public readonly string AttackHigh = "50ms";

	[Tooltip("5ms  |  200ms")]
	[Range(0.0f, 1.0f)]
	public float Release = 0.051282052f;
	private float lastRelease = -1f;
	public readonly int ReleaseIndex = 3;
	public readonly string ReleaseLow = "5ms";
	public readonly string ReleaseHigh = "200ms";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Amount = 0.5f;
	private float lastAmount = -1f;
	public readonly int AmountIndex = 4;
	public readonly string AmountLow = "0%";
	public readonly string AmountHigh = "100%";

	[Tooltip("-InfdB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Effect = 0.5956621f;
	private float lastEffect = -1f;
	public readonly int EffectIndex = 5;
	public readonly string EffectLow = "-InfdB";
	public readonly string EffectHigh = "0.0dB";

	[Tooltip("-InfdB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 1.0f;
	private float lastDry = -1f;
	public readonly int DryIndex = 6;
	public readonly string DryLow = "-InfdB";
	public readonly string DryHigh = "0.0dB";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float PostComp = 1.0f;
	private float lastPostComp = -1f;
	public readonly int PostCompIndex = 7;
	public readonly string PostCompLow = "Off";
	public readonly string PostCompHigh = "On";

	public override string getFilterName() {
		return "./vst/GDuckDly.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Delay != lastDelay) isUpdated = true;
		if(Feedback != lastFeedback) isUpdated = true;
		if(Attack != lastAttack) isUpdated = true;
		if(Release != lastRelease) isUpdated = true;
		if(Amount != lastAmount) isUpdated = true;
		if(Effect != lastEffect) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;
		if(PostComp != lastPostComp) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GDuckDly.dll");
		if(Delay != lastDelay) {
			client.sendPacket("parameter 0 "+Delay);
			lastDelay = Delay;
		}
		if(Feedback != lastFeedback) {
			client.sendPacket("parameter 1 "+Feedback);
			lastFeedback = Feedback;
		}
		if(Attack != lastAttack) {
			client.sendPacket("parameter 2 "+Attack);
			lastAttack = Attack;
		}
		if(Release != lastRelease) {
			client.sendPacket("parameter 3 "+Release);
			lastRelease = Release;
		}
		if(Amount != lastAmount) {
			client.sendPacket("parameter 4 "+Amount);
			lastAmount = Amount;
		}
		if(Effect != lastEffect) {
			client.sendPacket("parameter 5 "+Effect);
			lastEffect = Effect;
		}
		if(Dry != lastDry) {
			client.sendPacket("parameter 6 "+Dry);
			lastDry = Dry;
		}
		if(PostComp != lastPostComp) {
			client.sendPacket("parameter 7 "+PostComp);
			lastPostComp = PostComp;
		}
	}

	public override void resetStateTrackers() {
		lastDelay = -1f;
		lastFeedback = -1f;
		lastAttack = -1f;
		lastRelease = -1f;
		lastAmount = -1f;
		lastEffect = -1f;
		lastDry = -1f;
		lastPostComp = -1f;
	}
}
