using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GMulti")]
public class GMulti : VSTFilter {

	public readonly string pluginPath = "GMulti.dll";

	public override void resetToDefaults() {
		Gain = 0.625f;
		LoCut = 0.2631579f;
		Freq1 = 0.60206f;
		Freq2 = 0.39794f;
		Thresh1 = 0.4f;
		Ratio1 = 0.033333335f;
		Attk1 = 0.4f;
		Rel1 = 0.5959596f;
		Width1 = 0.0f;
		Level1 = 0.375f;
		Mute1 = 0.0f;
		Thresh2 = 0.5f;
		Ratio2 = 0.022222223f;
		Attk2 = 0.1f;
		Rel2 = 0.1919192f;
		Width2 = 0.575f;
		Level2 = 0.375f;
		Mute2 = 0.0f;
		Thresh3 = 0.4f;
		Ratio3 = 0.022222223f;
		Attk3 = 0.05f;
		Rel3 = 0.09090909f;
		Width3 = 0.65f;
		Level3 = 0.375f;
		Mute3 = 0.0f;
		Mix = 0.75f;
	}

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.625f;
	private float lastGain = -1f;
	public readonly int GainIndex = 0;
	public readonly string GainLow = "-12.0dB";
	public readonly string GainHigh = "12.0dB";

	[Tooltip("OffHz  |  100Hz")]
	[Range(0.0f, 1.0f)]
	public float LoCut = 0.2631579f;
	private float lastLoCut = -1f;
	public readonly int LoCutIndex = 1;
	public readonly string LoCutLow = "OffHz";
	public readonly string LoCutHigh = "100Hz";

	[Tooltip("50Hz  |  500Hz")]
	[Range(0.0f, 1.0f)]
	public float Freq1 = 0.60206f;
	private float lastFreq1 = -1f;
	public readonly int Freq1Index = 2;
	public readonly string Freq1Low = "50Hz";
	public readonly string Freq1High = "500Hz";

	[Tooltip("800Hz  |  8000Hz")]
	[Range(0.0f, 1.0f)]
	public float Freq2 = 0.39794f;
	private float lastFreq2 = -1f;
	public readonly int Freq2Index = 3;
	public readonly string Freq2Low = "800Hz";
	public readonly string Freq2High = "8000Hz";

	[Tooltip("-50dB  |  0dB")]
	[Range(0.0f, 1.0f)]
	public float Thresh1 = 0.4f;
	private float lastThresh1 = -1f;
	public readonly int Thresh1Index = 4;
	public readonly string Thresh1Low = "-50dB";
	public readonly string Thresh1High = "0dB";

	[Tooltip("1.0: 1  |  10.0: 1")]
	[Range(0.0f, 1.0f)]
	public float Ratio1 = 0.033333335f;
	private float lastRatio1 = -1f;
	public readonly int Ratio1Index = 5;
	public readonly string Ratio1Low = "1.0: 1";
	public readonly string Ratio1High = "10.0: 1";

	[Tooltip("0.0ms  |  20.0ms")]
	[Range(0.0f, 1.0f)]
	public float Attk1 = 0.4f;
	private float lastAttk1 = -1f;
	public readonly int Attk1Index = 6;
	public readonly string Attk1Low = "0.0ms";
	public readonly string Attk1High = "20.0ms";

	[Tooltip("0.01s  |  1.00s")]
	[Range(0.0f, 1.0f)]
	public float Rel1 = 0.5959596f;
	private float lastRel1 = -1f;
	public readonly int Rel1Index = 7;
	public readonly string Rel1Low = "0.01s";
	public readonly string Rel1High = "1.00s";

	[Tooltip("0%  |  200%")]
	[Range(0.0f, 1.0f)]
	public float Width1 = 0.0f;
	private float lastWidth1 = -1f;
	public readonly int Width1Index = 8;
	public readonly string Width1Low = "0%";
	public readonly string Width1High = "200%";

	[Tooltip("-6.0dB  |  18.0dB")]
	[Range(0.0f, 1.0f)]
	public float Level1 = 0.375f;
	private float lastLevel1 = -1f;
	public readonly int Level1Index = 9;
	public readonly string Level1Low = "-6.0dB";
	public readonly string Level1High = "18.0dB";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Mute1 = 0.0f;
	private float lastMute1 = -1f;
	public readonly int Mute1Index = 10;
	public readonly string Mute1Low = "Off";
	public readonly string Mute1High = "On";

	[Tooltip("-50dB  |  0dB")]
	[Range(0.0f, 1.0f)]
	public float Thresh2 = 0.5f;
	private float lastThresh2 = -1f;
	public readonly int Thresh2Index = 11;
	public readonly string Thresh2Low = "-50dB";
	public readonly string Thresh2High = "0dB";

	[Tooltip("1.0: 1  |  10.0: 1")]
	[Range(0.0f, 1.0f)]
	public float Ratio2 = 0.022222223f;
	private float lastRatio2 = -1f;
	public readonly int Ratio2Index = 12;
	public readonly string Ratio2Low = "1.0: 1";
	public readonly string Ratio2High = "10.0: 1";

	[Tooltip("0.0ms  |  20.0ms")]
	[Range(0.0f, 1.0f)]
	public float Attk2 = 0.1f;
	private float lastAttk2 = -1f;
	public readonly int Attk2Index = 13;
	public readonly string Attk2Low = "0.0ms";
	public readonly string Attk2High = "20.0ms";

	[Tooltip("0.01s  |  1.00s")]
	[Range(0.0f, 1.0f)]
	public float Rel2 = 0.1919192f;
	private float lastRel2 = -1f;
	public readonly int Rel2Index = 14;
	public readonly string Rel2Low = "0.01s";
	public readonly string Rel2High = "1.00s";

	[Tooltip("0%  |  200%")]
	[Range(0.0f, 1.0f)]
	public float Width2 = 0.575f;
	private float lastWidth2 = -1f;
	public readonly int Width2Index = 15;
	public readonly string Width2Low = "0%";
	public readonly string Width2High = "200%";

	[Tooltip("-6.0dB  |  18.0dB")]
	[Range(0.0f, 1.0f)]
	public float Level2 = 0.375f;
	private float lastLevel2 = -1f;
	public readonly int Level2Index = 16;
	public readonly string Level2Low = "-6.0dB";
	public readonly string Level2High = "18.0dB";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Mute2 = 0.0f;
	private float lastMute2 = -1f;
	public readonly int Mute2Index = 17;
	public readonly string Mute2Low = "Off";
	public readonly string Mute2High = "On";

	[Tooltip("-50dB  |  0dB")]
	[Range(0.0f, 1.0f)]
	public float Thresh3 = 0.4f;
	private float lastThresh3 = -1f;
	public readonly int Thresh3Index = 18;
	public readonly string Thresh3Low = "-50dB";
	public readonly string Thresh3High = "0dB";

	[Tooltip("1.0: 1  |  10.0: 1")]
	[Range(0.0f, 1.0f)]
	public float Ratio3 = 0.022222223f;
	private float lastRatio3 = -1f;
	public readonly int Ratio3Index = 19;
	public readonly string Ratio3Low = "1.0: 1";
	public readonly string Ratio3High = "10.0: 1";

	[Tooltip("0.0ms  |  20.0ms")]
	[Range(0.0f, 1.0f)]
	public float Attk3 = 0.05f;
	private float lastAttk3 = -1f;
	public readonly int Attk3Index = 20;
	public readonly string Attk3Low = "0.0ms";
	public readonly string Attk3High = "20.0ms";

	[Tooltip("0.01s  |  1.00s")]
	[Range(0.0f, 1.0f)]
	public float Rel3 = 0.09090909f;
	private float lastRel3 = -1f;
	public readonly int Rel3Index = 21;
	public readonly string Rel3Low = "0.01s";
	public readonly string Rel3High = "1.00s";

	[Tooltip("0%  |  200%")]
	[Range(0.0f, 1.0f)]
	public float Width3 = 0.65f;
	private float lastWidth3 = -1f;
	public readonly int Width3Index = 22;
	public readonly string Width3Low = "0%";
	public readonly string Width3High = "200%";

	[Tooltip("-6.0dB  |  18.0dB")]
	[Range(0.0f, 1.0f)]
	public float Level3 = 0.375f;
	private float lastLevel3 = -1f;
	public readonly int Level3Index = 23;
	public readonly string Level3Low = "-6.0dB";
	public readonly string Level3High = "18.0dB";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Mute3 = 0.0f;
	private float lastMute3 = -1f;
	public readonly int Mute3Index = 24;
	public readonly string Mute3Low = "Off";
	public readonly string Mute3High = "On";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Mix = 0.75f;
	private float lastMix = -1f;
	public readonly int MixIndex = 25;
	public readonly string MixLow = "0%";
	public readonly string MixHigh = "100%";

	public override string getFilterName() {
		return "./vst/GMulti.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Gain != lastGain) isUpdated = true;
		if(LoCut != lastLoCut) isUpdated = true;
		if(Freq1 != lastFreq1) isUpdated = true;
		if(Freq2 != lastFreq2) isUpdated = true;
		if(Thresh1 != lastThresh1) isUpdated = true;
		if(Ratio1 != lastRatio1) isUpdated = true;
		if(Attk1 != lastAttk1) isUpdated = true;
		if(Rel1 != lastRel1) isUpdated = true;
		if(Width1 != lastWidth1) isUpdated = true;
		if(Level1 != lastLevel1) isUpdated = true;
		if(Mute1 != lastMute1) isUpdated = true;
		if(Thresh2 != lastThresh2) isUpdated = true;
		if(Ratio2 != lastRatio2) isUpdated = true;
		if(Attk2 != lastAttk2) isUpdated = true;
		if(Rel2 != lastRel2) isUpdated = true;
		if(Width2 != lastWidth2) isUpdated = true;
		if(Level2 != lastLevel2) isUpdated = true;
		if(Mute2 != lastMute2) isUpdated = true;
		if(Thresh3 != lastThresh3) isUpdated = true;
		if(Ratio3 != lastRatio3) isUpdated = true;
		if(Attk3 != lastAttk3) isUpdated = true;
		if(Rel3 != lastRel3) isUpdated = true;
		if(Width3 != lastWidth3) isUpdated = true;
		if(Level3 != lastLevel3) isUpdated = true;
		if(Mute3 != lastMute3) isUpdated = true;
		if(Mix != lastMix) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GMulti.dll");
		if(Gain != lastGain) {
			client.sendPacket("parameter 0 "+Gain);
			lastGain = Gain;
		}
		if(LoCut != lastLoCut) {
			client.sendPacket("parameter 1 "+LoCut);
			lastLoCut = LoCut;
		}
		if(Freq1 != lastFreq1) {
			client.sendPacket("parameter 2 "+Freq1);
			lastFreq1 = Freq1;
		}
		if(Freq2 != lastFreq2) {
			client.sendPacket("parameter 3 "+Freq2);
			lastFreq2 = Freq2;
		}
		if(Thresh1 != lastThresh1) {
			client.sendPacket("parameter 4 "+Thresh1);
			lastThresh1 = Thresh1;
		}
		if(Ratio1 != lastRatio1) {
			client.sendPacket("parameter 5 "+Ratio1);
			lastRatio1 = Ratio1;
		}
		if(Attk1 != lastAttk1) {
			client.sendPacket("parameter 6 "+Attk1);
			lastAttk1 = Attk1;
		}
		if(Rel1 != lastRel1) {
			client.sendPacket("parameter 7 "+Rel1);
			lastRel1 = Rel1;
		}
		if(Width1 != lastWidth1) {
			client.sendPacket("parameter 8 "+Width1);
			lastWidth1 = Width1;
		}
		if(Level1 != lastLevel1) {
			client.sendPacket("parameter 9 "+Level1);
			lastLevel1 = Level1;
		}
		if(Mute1 != lastMute1) {
			client.sendPacket("parameter 10 "+Mute1);
			lastMute1 = Mute1;
		}
		if(Thresh2 != lastThresh2) {
			client.sendPacket("parameter 11 "+Thresh2);
			lastThresh2 = Thresh2;
		}
		if(Ratio2 != lastRatio2) {
			client.sendPacket("parameter 12 "+Ratio2);
			lastRatio2 = Ratio2;
		}
		if(Attk2 != lastAttk2) {
			client.sendPacket("parameter 13 "+Attk2);
			lastAttk2 = Attk2;
		}
		if(Rel2 != lastRel2) {
			client.sendPacket("parameter 14 "+Rel2);
			lastRel2 = Rel2;
		}
		if(Width2 != lastWidth2) {
			client.sendPacket("parameter 15 "+Width2);
			lastWidth2 = Width2;
		}
		if(Level2 != lastLevel2) {
			client.sendPacket("parameter 16 "+Level2);
			lastLevel2 = Level2;
		}
		if(Mute2 != lastMute2) {
			client.sendPacket("parameter 17 "+Mute2);
			lastMute2 = Mute2;
		}
		if(Thresh3 != lastThresh3) {
			client.sendPacket("parameter 18 "+Thresh3);
			lastThresh3 = Thresh3;
		}
		if(Ratio3 != lastRatio3) {
			client.sendPacket("parameter 19 "+Ratio3);
			lastRatio3 = Ratio3;
		}
		if(Attk3 != lastAttk3) {
			client.sendPacket("parameter 20 "+Attk3);
			lastAttk3 = Attk3;
		}
		if(Rel3 != lastRel3) {
			client.sendPacket("parameter 21 "+Rel3);
			lastRel3 = Rel3;
		}
		if(Width3 != lastWidth3) {
			client.sendPacket("parameter 22 "+Width3);
			lastWidth3 = Width3;
		}
		if(Level3 != lastLevel3) {
			client.sendPacket("parameter 23 "+Level3);
			lastLevel3 = Level3;
		}
		if(Mute3 != lastMute3) {
			client.sendPacket("parameter 24 "+Mute3);
			lastMute3 = Mute3;
		}
		if(Mix != lastMix) {
			client.sendPacket("parameter 25 "+Mix);
			lastMix = Mix;
		}
	}

	public override void resetStateTrackers() {
		lastGain = -1f;
		lastLoCut = -1f;
		lastFreq1 = -1f;
		lastFreq2 = -1f;
		lastThresh1 = -1f;
		lastRatio1 = -1f;
		lastAttk1 = -1f;
		lastRel1 = -1f;
		lastWidth1 = -1f;
		lastLevel1 = -1f;
		lastMute1 = -1f;
		lastThresh2 = -1f;
		lastRatio2 = -1f;
		lastAttk2 = -1f;
		lastRel2 = -1f;
		lastWidth2 = -1f;
		lastLevel2 = -1f;
		lastMute2 = -1f;
		lastThresh3 = -1f;
		lastRatio3 = -1f;
		lastAttk3 = -1f;
		lastRel3 = -1f;
		lastWidth3 = -1f;
		lastLevel3 = -1f;
		lastMute3 = -1f;
		lastMix = -1f;
	}
}
