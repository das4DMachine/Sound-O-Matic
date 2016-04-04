using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/AbstractChamber_x64")]
public class AbstractChamber_x64 : VSTFilter {

	public readonly string pluginPath = "Abstract Chamber-x64.dll";

	public override void resetToDefaults() {
		mode = 0.0f;
		output = 0.5f;
		LFcut = 0.2399844f;
		HFcut = 0.5f;
		predel = 0.25f;
		RT = 0.5f;
		HFdamp = 0.5f;
		mod = 0.25f;
	}

	[Tooltip("send  |  insert")]
	[Range(0.0f, 1.0f)]
	public float mode = 0.0f;
	private float lastmode = -1f;
	public readonly int modeIndex = 0;
	public readonly string modeLow = "send";
	public readonly string modeHigh = "insert";

	[Tooltip("-infdB  |  0.0dB")]
	[Range(0.0f, 1.0f)]
	public float output = 0.5f;
	private float lastoutput = -1f;
	public readonly int outputIndex = 1;
	public readonly string outputLow = "-infdB";
	public readonly string outputHigh = "0.0dB";

	[Tooltip("40Hz  |  1000Hz")]
	[Range(0.0f, 1.0f)]
	public float LFcut = 0.2399844f;
	private float lastLFcut = -1f;
	public readonly int LFcutIndex = 2;
	public readonly string LFcutLow = "40Hz";
	public readonly string LFcutHigh = "1000Hz";

	[Tooltip("1.00kHz  |  16.00kHz")]
	[Range(0.0f, 1.0f)]
	public float HFcut = 0.5f;
	private float lastHFcut = -1f;
	public readonly int HFcutIndex = 3;
	public readonly string HFcutLow = "1.00kHz";
	public readonly string HFcutHigh = "16.00kHz";

	[Tooltip("0ms  |  100ms")]
	[Range(0.0f, 1.0f)]
	public float predel = 0.25f;
	private float lastpredel = -1f;
	public readonly int predelIndex = 4;
	public readonly string predelLow = "0ms";
	public readonly string predelHigh = "100ms";

	[Tooltip("0.25s  |  25.00s")]
	[Range(0.0f, 1.0f)]
	public float RT = 0.5f;
	private float lastRT = -1f;
	public readonly int RTIndex = 5;
	public readonly string RTLow = "0.25s";
	public readonly string RTHigh = "25.00s";

	[Tooltip("1.00s  |  4.00s")]
	[Range(0.0f, 1.0f)]
	public float HFdamp = 0.5f;
	private float lastHFdamp = -1f;
	public readonly int HFdampIndex = 6;
	public readonly string HFdampLow = "1.00s";
	public readonly string HFdampHigh = "4.00s";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float mod = 0.25f;
	private float lastmod = -1f;
	public readonly int modIndex = 7;
	public readonly string modLow = "0%";
	public readonly string modHigh = "100%";

	public override string getFilterName() {
		return "./vst/Abstract Chamber-x64.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(mode != lastmode) isUpdated = true;
		if(output != lastoutput) isUpdated = true;
		if(LFcut != lastLFcut) isUpdated = true;
		if(HFcut != lastHFcut) isUpdated = true;
		if(predel != lastpredel) isUpdated = true;
		if(RT != lastRT) isUpdated = true;
		if(HFdamp != lastHFdamp) isUpdated = true;
		if(mod != lastmod) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Abstract Chamber-x64.dll");
		if(mode != lastmode) {
			client.sendPacket("parameter 0 "+mode);
			lastmode = mode;
		}
		if(output != lastoutput) {
			client.sendPacket("parameter 1 "+output);
			lastoutput = output;
		}
		if(LFcut != lastLFcut) {
			client.sendPacket("parameter 2 "+LFcut);
			lastLFcut = LFcut;
		}
		if(HFcut != lastHFcut) {
			client.sendPacket("parameter 3 "+HFcut);
			lastHFcut = HFcut;
		}
		if(predel != lastpredel) {
			client.sendPacket("parameter 4 "+predel);
			lastpredel = predel;
		}
		if(RT != lastRT) {
			client.sendPacket("parameter 5 "+RT);
			lastRT = RT;
		}
		if(HFdamp != lastHFdamp) {
			client.sendPacket("parameter 6 "+HFdamp);
			lastHFdamp = HFdamp;
		}
		if(mod != lastmod) {
			client.sendPacket("parameter 7 "+mod);
			lastmod = mod;
		}
	}

	public override void resetStateTrackers() {
		lastmode = -1f;
		lastoutput = -1f;
		lastLFcut = -1f;
		lastHFcut = -1f;
		lastpredel = -1f;
		lastRT = -1f;
		lastHFdamp = -1f;
		lastmod = -1f;
	}
}
