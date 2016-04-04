using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/BitterSweetV3")]
public class BitterSweetV3 : VSTFilter {

	public readonly string pluginPath = "BitterSweetV3.dll";

	public override void resetToDefaults() {
		Bypass = 0.0f;
		Morphing = 0.0f;
		LinkGain = 1.0f;
		OutputGain = 0.5f;
		Mode = 0.0f;
		Amount = 0.5f;
		Period = 0.2f;
		SpeedMode = 0.0f;
		MorphingAutomation = 0.0f;
	}

	[Tooltip("OffOn/Off  |  OnOn/Off")]
	[Range(0.0f, 1.0f)]
	public float Bypass = 0.0f;
	private float lastBypass = -1f;
	public readonly int BypassIndex = 0;
	public readonly string BypassLow = "OffOn/Off";
	public readonly string BypassHigh = "OnOn/Off";

	[Tooltip("0.00%  |  0.00%")]
	[Range(0.0f, 1.0f)]
	public float Morphing = 0.0f;
	private float lastMorphing = -1f;
	public readonly int MorphingIndex = 1;
	public readonly string MorphingLow = "0.00%";
	public readonly string MorphingHigh = "0.00%";

	[Tooltip("OffOn/Off  |  OnOn/Off")]
	[Range(0.0f, 1.0f)]
	public float LinkGain = 1.0f;
	private float lastLinkGain = -1f;
	public readonly int LinkGainIndex = 2;
	public readonly string LinkGainLow = "OffOn/Off";
	public readonly string LinkGainHigh = "OnOn/Off";

	[Tooltip("0.00dB  |  0.00dB")]
	[Range(0.0f, 1.0f)]
	public float OutputGain = 0.5f;
	private float lastOutputGain = -1f;
	public readonly int OutputGainIndex = 3;
	public readonly string OutputGainLow = "0.00dB";
	public readonly string OutputGainHigh = "0.00dB";

	[Tooltip("All  |  Stereo")]
	[Range(0.0f, 1.0f)]
	public float Mode = 0.0f;
	private float lastMode = -1f;
	public readonly int ModeIndex = 4;
	public readonly string ModeLow = "All";
	public readonly string ModeHigh = "Stereo";

	[Tooltip("-100.00%  |  100.00%")]
	[Range(0.0f, 1.0f)]
	public float Amount = 0.5f;
	private float lastAmount = -1f;
	public readonly int AmountIndex = 5;
	public readonly string AmountLow = "-100.00%";
	public readonly string AmountHigh = "100.00%";

	[Tooltip("20.0ms  |  120.0ms")]
	[Range(0.0f, 1.0f)]
	public float Period = 0.2f;
	private float lastPeriod = -1f;
	public readonly int PeriodIndex = 6;
	public readonly string PeriodLow = "20.0ms";
	public readonly string PeriodHigh = "120.0ms";

	[Tooltip("0  |  2")]
	[Range(0.0f, 1.0f)]
	public float SpeedMode = 0.0f;
	private float lastSpeedMode = -1f;
	public readonly int SpeedModeIndex = 7;
	public readonly string SpeedModeLow = "0";
	public readonly string SpeedModeHigh = "2";

	[Tooltip("OffOn/Off  |  OnOn/Off")]
	[Range(0.0f, 1.0f)]
	public float MorphingAutomation = 0.0f;
	private float lastMorphingAutomation = -1f;
	public readonly int MorphingAutomationIndex = 8;
	public readonly string MorphingAutomationLow = "OffOn/Off";
	public readonly string MorphingAutomationHigh = "OnOn/Off";

	public override string getFilterName() {
		return "./vst/BitterSweetV3.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Bypass != lastBypass) isUpdated = true;
		if(Morphing != lastMorphing) isUpdated = true;
		if(LinkGain != lastLinkGain) isUpdated = true;
		if(OutputGain != lastOutputGain) isUpdated = true;
		if(Mode != lastMode) isUpdated = true;
		if(Amount != lastAmount) isUpdated = true;
		if(Period != lastPeriod) isUpdated = true;
		if(SpeedMode != lastSpeedMode) isUpdated = true;
		if(MorphingAutomation != lastMorphingAutomation) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/BitterSweetV3.dll");
		if(Bypass != lastBypass) {
			client.sendPacket("parameter 0 "+Bypass);
			lastBypass = Bypass;
		}
		if(Morphing != lastMorphing) {
			client.sendPacket("parameter 1 "+Morphing);
			lastMorphing = Morphing;
		}
		if(LinkGain != lastLinkGain) {
			client.sendPacket("parameter 2 "+LinkGain);
			lastLinkGain = LinkGain;
		}
		if(OutputGain != lastOutputGain) {
			client.sendPacket("parameter 3 "+OutputGain);
			lastOutputGain = OutputGain;
		}
		if(Mode != lastMode) {
			client.sendPacket("parameter 4 "+Mode);
			lastMode = Mode;
		}
		if(Amount != lastAmount) {
			client.sendPacket("parameter 5 "+Amount);
			lastAmount = Amount;
		}
		if(Period != lastPeriod) {
			client.sendPacket("parameter 6 "+Period);
			lastPeriod = Period;
		}
		if(SpeedMode != lastSpeedMode) {
			client.sendPacket("parameter 7 "+SpeedMode);
			lastSpeedMode = SpeedMode;
		}
		if(MorphingAutomation != lastMorphingAutomation) {
			client.sendPacket("parameter 8 "+MorphingAutomation);
			lastMorphingAutomation = MorphingAutomation;
		}
	}

	public override void resetStateTrackers() {
		lastBypass = -1f;
		lastMorphing = -1f;
		lastLinkGain = -1f;
		lastOutputGain = -1f;
		lastMode = -1f;
		lastAmount = -1f;
		lastPeriod = -1f;
		lastSpeedMode = -1f;
		lastMorphingAutomation = -1f;
	}
}
