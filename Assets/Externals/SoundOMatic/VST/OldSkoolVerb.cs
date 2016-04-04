using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/OldSkoolVerb")]
public class OldSkoolVerb : VSTFilter {

	public readonly string pluginPath = "OldSkoolVerb.dll";

	public override void resetToDefaults() {
		Bypass = 0.0f;
		PreDly = 0.5345225f;
		Space = 0.65465367f;
		Time = 0.42857143f;
		Width = 0.75f;
		DampLo = 0.26164803f;
		DampHi = 0.53277886f;
		EQLo = 0.5f;
		EQMid = 0.375f;
		EQHi = 0.5f;
		RevGain = 0.5714286f;
		DryGain = 0.5f;
		DryMute = 0.0f;
	}

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Bypass = 0.0f;
	private float lastBypass = -1f;
	public readonly int BypassIndex = 0;
	public readonly string BypassLow = "Off";
	public readonly string BypassHigh = "On";

	[Tooltip("10.0ms  |  150ms")]
	[Range(0.0f, 1.0f)]
	public float PreDly = 0.5345225f;
	private float lastPreDly = -1f;
	public readonly int PreDlyIndex = 1;
	public readonly string PreDlyLow = "10.0ms";
	public readonly string PreDlyHigh = "150ms";

	[Tooltip("10.0ms  |  150ms")]
	[Range(0.0f, 1.0f)]
	public float Space = 0.65465367f;
	private float lastSpace = -1f;
	public readonly int SpaceIndex = 2;
	public readonly string SpaceLow = "10.0ms";
	public readonly string SpaceHigh = "150ms";

	[Tooltip("200ms  |  10000ms")]
	[Range(0.0f, 1.0f)]
	public float Time = 0.42857143f;
	private float lastTime = -1f;
	public readonly int TimeIndex = 3;
	public readonly string TimeLow = "200ms";
	public readonly string TimeHigh = "10000ms";

	[Tooltip("0.0%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Width = 0.75f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 4;
	public readonly string WidthLow = "0.0%";
	public readonly string WidthHigh = "100.0%";

	[Tooltip("5.0Hz  |  1.00kHz")]
	[Range(0.0f, 1.0f)]
	public float DampLo = 0.26164803f;
	private float lastDampLo = -1f;
	public readonly int DampLoIndex = 5;
	public readonly string DampLoLow = "5.0Hz";
	public readonly string DampLoHigh = "1.00kHz";

	[Tooltip("2.00kHz  |  21.0kHz")]
	[Range(0.0f, 1.0f)]
	public float DampHi = 0.53277886f;
	private float lastDampHi = -1f;
	public readonly int DampHiIndex = 6;
	public readonly string DampHiLow = "2.00kHz";
	public readonly string DampHiHigh = "21.0kHz";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float EQLo = 0.5f;
	private float lastEQLo = -1f;
	public readonly int EQLoIndex = 7;
	public readonly string EQLoLow = "-12.0dB";
	public readonly string EQLoHigh = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float EQMid = 0.375f;
	private float lastEQMid = -1f;
	public readonly int EQMidIndex = 8;
	public readonly string EQMidLow = "-12.0dB";
	public readonly string EQMidHigh = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float EQHi = 0.5f;
	private float lastEQHi = -1f;
	public readonly int EQHiIndex = 9;
	public readonly string EQHiLow = "-12.0dB";
	public readonly string EQHiHigh = "12.0dB";

	[Tooltip("-30.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float RevGain = 0.5714286f;
	private float lastRevGain = -1f;
	public readonly int RevGainIndex = 10;
	public readonly string RevGainLow = "-30.0dB";
	public readonly string RevGainHigh = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float DryGain = 0.5f;
	private float lastDryGain = -1f;
	public readonly int DryGainIndex = 11;
	public readonly string DryGainLow = "-12.0dB";
	public readonly string DryGainHigh = "12.0dB";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float DryMute = 0.0f;
	private float lastDryMute = -1f;
	public readonly int DryMuteIndex = 12;
	public readonly string DryMuteLow = "Off";
	public readonly string DryMuteHigh = "On";

	public override string getFilterName() {
		return "./vst/OldSkoolVerb.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Bypass != lastBypass) isUpdated = true;
		if(PreDly != lastPreDly) isUpdated = true;
		if(Space != lastSpace) isUpdated = true;
		if(Time != lastTime) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;
		if(DampLo != lastDampLo) isUpdated = true;
		if(DampHi != lastDampHi) isUpdated = true;
		if(EQLo != lastEQLo) isUpdated = true;
		if(EQMid != lastEQMid) isUpdated = true;
		if(EQHi != lastEQHi) isUpdated = true;
		if(RevGain != lastRevGain) isUpdated = true;
		if(DryGain != lastDryGain) isUpdated = true;
		if(DryMute != lastDryMute) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/OldSkoolVerb.dll");
		if(Bypass != lastBypass) {
			client.sendPacket("parameter 0 "+Bypass);
			lastBypass = Bypass;
		}
		if(PreDly != lastPreDly) {
			client.sendPacket("parameter 1 "+PreDly);
			lastPreDly = PreDly;
		}
		if(Space != lastSpace) {
			client.sendPacket("parameter 2 "+Space);
			lastSpace = Space;
		}
		if(Time != lastTime) {
			client.sendPacket("parameter 3 "+Time);
			lastTime = Time;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 4 "+Width);
			lastWidth = Width;
		}
		if(DampLo != lastDampLo) {
			client.sendPacket("parameter 5 "+DampLo);
			lastDampLo = DampLo;
		}
		if(DampHi != lastDampHi) {
			client.sendPacket("parameter 6 "+DampHi);
			lastDampHi = DampHi;
		}
		if(EQLo != lastEQLo) {
			client.sendPacket("parameter 7 "+EQLo);
			lastEQLo = EQLo;
		}
		if(EQMid != lastEQMid) {
			client.sendPacket("parameter 8 "+EQMid);
			lastEQMid = EQMid;
		}
		if(EQHi != lastEQHi) {
			client.sendPacket("parameter 9 "+EQHi);
			lastEQHi = EQHi;
		}
		if(RevGain != lastRevGain) {
			client.sendPacket("parameter 10 "+RevGain);
			lastRevGain = RevGain;
		}
		if(DryGain != lastDryGain) {
			client.sendPacket("parameter 11 "+DryGain);
			lastDryGain = DryGain;
		}
		if(DryMute != lastDryMute) {
			client.sendPacket("parameter 12 "+DryMute);
			lastDryMute = DryMute;
		}
	}

	public override void resetStateTrackers() {
		lastBypass = -1f;
		lastPreDly = -1f;
		lastSpace = -1f;
		lastTime = -1f;
		lastWidth = -1f;
		lastDampLo = -1f;
		lastDampHi = -1f;
		lastEQLo = -1f;
		lastEQMid = -1f;
		lastEQHi = -1f;
		lastRevGain = -1f;
		lastDryGain = -1f;
		lastDryMute = -1f;
	}
}
