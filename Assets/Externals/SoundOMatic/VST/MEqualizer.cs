using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MEqualizer")]
public class MEqualizer : VSTFilter {

	public readonly string pluginPath = "MEqualizer.dll";

	public override void resetToDefaults() {
		Drywet = 1.0f;
		Gain = 0.5f;
		Softsaturation = 0.0f;
		Equalizerband1Enabl = 0.0f;
		Equalizerband1Frequ = 0.14285715f;
		Equalizerband1Gain = 0.5f;
		Equalizerband1Q1 = 0.87461686f;
		Equalizerband1Type = 0.125f;
		Equalizerband2Enabl = 0.0f;
		Equalizerband2Frequ = 0.2857143f;
		Equalizerband2Gain = 0.5f;
		Equalizerband2Q2 = 0.87461686f;
		Equalizerband2Type = 0.0f;
		Equalizerband3Enabl = 0.0f;
		Equalizerband3Frequ = 0.42857143f;
		Equalizerband3Gain = 0.5f;
		Equalizerband3Q3 = 0.87461686f;
		Equalizerband3Type = 0.0f;
		Equalizerband4Enabl = 1.0f;
		Equalizerband4Frequ = 0.5714286f;
		Equalizerband4Gain = 0.5f;
		Equalizerband4Q4 = 0.87461686f;
		Equalizerband4Type = 0.0f;
		Equalizerband5Enabl = 0.0f;
		Equalizerband5Frequ = 0.71428573f;
		Equalizerband5Gain = 0.5f;
		Equalizerband5Q5 = 0.87461686f;
		Equalizerband5Type = 0.0f;
		Equalizerband6Enabl = 0.0f;
		Equalizerband6Frequ = 0.85714287f;
		Equalizerband6Gain = 0.5f;
		Equalizerband6Q6 = 0.87461686f;
		Equalizerband6Type = 0.25f;
	}

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Drywet = 1.0f;
	private float lastDrywet = -1f;
	public readonly int DrywetIndex = 0;
	public readonly string DrywetLow = "0.00%";
	public readonly string DrywetHigh = "100.0%";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Gain = 0.5f;
	private float lastGain = -1f;
	public readonly int GainIndex = 1;
	public readonly string GainLow = "-24.00 dB";
	public readonly string GainHigh = "+24.00 dB";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Softsaturation = 0.0f;
	private float lastSoftsaturation = -1f;
	public readonly int SoftsaturationIndex = 2;
	public readonly string SoftsaturationLow = "0.00%";
	public readonly string SoftsaturationHigh = "100.0%";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband1Enabl = 0.0f;
	private float lastEqualizerband1Enabl = -1f;
	public readonly int Equalizerband1EnablIndex = 3;
	public readonly string Equalizerband1EnablLow = "Off";
	public readonly string Equalizerband1EnablHigh = "On";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband1Frequ = 0.14285715f;
	private float lastEqualizerband1Frequ = -1f;
	public readonly int Equalizerband1FrequIndex = 4;
	public readonly string Equalizerband1FrequLow = "20.0 Hz";
	public readonly string Equalizerband1FrequHigh = "20.0 kHz";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband1Gain = 0.5f;
	private float lastEqualizerband1Gain = -1f;
	public readonly int Equalizerband1GainIndex = 5;
	public readonly string Equalizerband1GainLow = "-24.00 dB";
	public readonly string Equalizerband1GainHigh = "+24.00 dB";

	[Tooltip("20.000000  |  0.050000")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband1Q1 = 0.87461686f;
	private float lastEqualizerband1Q1 = -1f;
	public readonly int Equalizerband1Q1Index = 6;
	public readonly string Equalizerband1Q1Low = "20.000000";
	public readonly string Equalizerband1Q1High = "0.050000";

	[Tooltip("Peak  |  Notch")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband1Type = 0.125f;
	private float lastEqualizerband1Type = -1f;
	public readonly int Equalizerband1TypeIndex = 7;
	public readonly string Equalizerband1TypeLow = "Peak";
	public readonly string Equalizerband1TypeHigh = "Notch";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband2Enabl = 0.0f;
	private float lastEqualizerband2Enabl = -1f;
	public readonly int Equalizerband2EnablIndex = 10;
	public readonly string Equalizerband2EnablLow = "Off";
	public readonly string Equalizerband2EnablHigh = "On";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband2Frequ = 0.2857143f;
	private float lastEqualizerband2Frequ = -1f;
	public readonly int Equalizerband2FrequIndex = 11;
	public readonly string Equalizerband2FrequLow = "20.0 Hz";
	public readonly string Equalizerband2FrequHigh = "20.0 kHz";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband2Gain = 0.5f;
	private float lastEqualizerband2Gain = -1f;
	public readonly int Equalizerband2GainIndex = 12;
	public readonly string Equalizerband2GainLow = "-24.00 dB";
	public readonly string Equalizerband2GainHigh = "+24.00 dB";

	[Tooltip("20.000000  |  0.050000")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband2Q2 = 0.87461686f;
	private float lastEqualizerband2Q2 = -1f;
	public readonly int Equalizerband2Q2Index = 13;
	public readonly string Equalizerband2Q2Low = "20.000000";
	public readonly string Equalizerband2Q2High = "0.050000";

	[Tooltip("Peak  |  Notch")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband2Type = 0.0f;
	private float lastEqualizerband2Type = -1f;
	public readonly int Equalizerband2TypeIndex = 14;
	public readonly string Equalizerband2TypeLow = "Peak";
	public readonly string Equalizerband2TypeHigh = "Notch";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband3Enabl = 0.0f;
	private float lastEqualizerband3Enabl = -1f;
	public readonly int Equalizerband3EnablIndex = 17;
	public readonly string Equalizerband3EnablLow = "Off";
	public readonly string Equalizerband3EnablHigh = "On";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband3Frequ = 0.42857143f;
	private float lastEqualizerband3Frequ = -1f;
	public readonly int Equalizerband3FrequIndex = 18;
	public readonly string Equalizerband3FrequLow = "20.0 Hz";
	public readonly string Equalizerband3FrequHigh = "20.0 kHz";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband3Gain = 0.5f;
	private float lastEqualizerband3Gain = -1f;
	public readonly int Equalizerband3GainIndex = 19;
	public readonly string Equalizerband3GainLow = "-24.00 dB";
	public readonly string Equalizerband3GainHigh = "+24.00 dB";

	[Tooltip("20.000000  |  0.050000")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband3Q3 = 0.87461686f;
	private float lastEqualizerband3Q3 = -1f;
	public readonly int Equalizerband3Q3Index = 20;
	public readonly string Equalizerband3Q3Low = "20.000000";
	public readonly string Equalizerband3Q3High = "0.050000";

	[Tooltip("Peak  |  Notch")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband3Type = 0.0f;
	private float lastEqualizerband3Type = -1f;
	public readonly int Equalizerband3TypeIndex = 21;
	public readonly string Equalizerband3TypeLow = "Peak";
	public readonly string Equalizerband3TypeHigh = "Notch";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband4Enabl = 1.0f;
	private float lastEqualizerband4Enabl = -1f;
	public readonly int Equalizerband4EnablIndex = 24;
	public readonly string Equalizerband4EnablLow = "Off";
	public readonly string Equalizerband4EnablHigh = "On";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband4Frequ = 0.5714286f;
	private float lastEqualizerband4Frequ = -1f;
	public readonly int Equalizerband4FrequIndex = 25;
	public readonly string Equalizerband4FrequLow = "20.0 Hz";
	public readonly string Equalizerband4FrequHigh = "20.0 kHz";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband4Gain = 0.5f;
	private float lastEqualizerband4Gain = -1f;
	public readonly int Equalizerband4GainIndex = 26;
	public readonly string Equalizerband4GainLow = "-24.00 dB";
	public readonly string Equalizerband4GainHigh = "+24.00 dB";

	[Tooltip("20.000000  |  0.050000")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband4Q4 = 0.87461686f;
	private float lastEqualizerband4Q4 = -1f;
	public readonly int Equalizerband4Q4Index = 27;
	public readonly string Equalizerband4Q4Low = "20.000000";
	public readonly string Equalizerband4Q4High = "0.050000";

	[Tooltip("Peak  |  Notch")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband4Type = 0.0f;
	private float lastEqualizerband4Type = -1f;
	public readonly int Equalizerband4TypeIndex = 28;
	public readonly string Equalizerband4TypeLow = "Peak";
	public readonly string Equalizerband4TypeHigh = "Notch";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband5Enabl = 0.0f;
	private float lastEqualizerband5Enabl = -1f;
	public readonly int Equalizerband5EnablIndex = 31;
	public readonly string Equalizerband5EnablLow = "Off";
	public readonly string Equalizerband5EnablHigh = "On";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband5Frequ = 0.71428573f;
	private float lastEqualizerband5Frequ = -1f;
	public readonly int Equalizerband5FrequIndex = 32;
	public readonly string Equalizerband5FrequLow = "20.0 Hz";
	public readonly string Equalizerband5FrequHigh = "20.0 kHz";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband5Gain = 0.5f;
	private float lastEqualizerband5Gain = -1f;
	public readonly int Equalizerband5GainIndex = 33;
	public readonly string Equalizerband5GainLow = "-24.00 dB";
	public readonly string Equalizerband5GainHigh = "+24.00 dB";

	[Tooltip("20.000000  |  0.050000")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband5Q5 = 0.87461686f;
	private float lastEqualizerband5Q5 = -1f;
	public readonly int Equalizerband5Q5Index = 34;
	public readonly string Equalizerband5Q5Low = "20.000000";
	public readonly string Equalizerband5Q5High = "0.050000";

	[Tooltip("Peak  |  Notch")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband5Type = 0.0f;
	private float lastEqualizerband5Type = -1f;
	public readonly int Equalizerband5TypeIndex = 35;
	public readonly string Equalizerband5TypeLow = "Peak";
	public readonly string Equalizerband5TypeHigh = "Notch";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband6Enabl = 0.0f;
	private float lastEqualizerband6Enabl = -1f;
	public readonly int Equalizerband6EnablIndex = 38;
	public readonly string Equalizerband6EnablLow = "Off";
	public readonly string Equalizerband6EnablHigh = "On";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband6Frequ = 0.85714287f;
	private float lastEqualizerband6Frequ = -1f;
	public readonly int Equalizerband6FrequIndex = 39;
	public readonly string Equalizerband6FrequLow = "20.0 Hz";
	public readonly string Equalizerband6FrequHigh = "20.0 kHz";

	[Tooltip("-24.00 dB  |  +24.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband6Gain = 0.5f;
	private float lastEqualizerband6Gain = -1f;
	public readonly int Equalizerband6GainIndex = 40;
	public readonly string Equalizerband6GainLow = "-24.00 dB";
	public readonly string Equalizerband6GainHigh = "+24.00 dB";

	[Tooltip("20.000000  |  0.050000")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband6Q6 = 0.87461686f;
	private float lastEqualizerband6Q6 = -1f;
	public readonly int Equalizerband6Q6Index = 41;
	public readonly string Equalizerband6Q6Low = "20.000000";
	public readonly string Equalizerband6Q6High = "0.050000";

	[Tooltip("Peak  |  Notch")]
	[Range(0.0f, 1.0f)]
	public float Equalizerband6Type = 0.25f;
	private float lastEqualizerband6Type = -1f;
	public readonly int Equalizerband6TypeIndex = 42;
	public readonly string Equalizerband6TypeLow = "Peak";
	public readonly string Equalizerband6TypeHigh = "Notch";

	public override string getFilterName() {
		return "./vst/MEqualizer.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Drywet != lastDrywet) isUpdated = true;
		if(Gain != lastGain) isUpdated = true;
		if(Softsaturation != lastSoftsaturation) isUpdated = true;
		if(Equalizerband1Enabl != lastEqualizerband1Enabl) isUpdated = true;
		if(Equalizerband1Frequ != lastEqualizerband1Frequ) isUpdated = true;
		if(Equalizerband1Gain != lastEqualizerband1Gain) isUpdated = true;
		if(Equalizerband1Q1 != lastEqualizerband1Q1) isUpdated = true;
		if(Equalizerband1Type != lastEqualizerband1Type) isUpdated = true;
		if(Equalizerband2Enabl != lastEqualizerband2Enabl) isUpdated = true;
		if(Equalizerband2Frequ != lastEqualizerband2Frequ) isUpdated = true;
		if(Equalizerband2Gain != lastEqualizerband2Gain) isUpdated = true;
		if(Equalizerband2Q2 != lastEqualizerband2Q2) isUpdated = true;
		if(Equalizerband2Type != lastEqualizerband2Type) isUpdated = true;
		if(Equalizerband3Enabl != lastEqualizerband3Enabl) isUpdated = true;
		if(Equalizerband3Frequ != lastEqualizerband3Frequ) isUpdated = true;
		if(Equalizerband3Gain != lastEqualizerband3Gain) isUpdated = true;
		if(Equalizerband3Q3 != lastEqualizerband3Q3) isUpdated = true;
		if(Equalizerband3Type != lastEqualizerband3Type) isUpdated = true;
		if(Equalizerband4Enabl != lastEqualizerband4Enabl) isUpdated = true;
		if(Equalizerband4Frequ != lastEqualizerband4Frequ) isUpdated = true;
		if(Equalizerband4Gain != lastEqualizerband4Gain) isUpdated = true;
		if(Equalizerband4Q4 != lastEqualizerband4Q4) isUpdated = true;
		if(Equalizerband4Type != lastEqualizerband4Type) isUpdated = true;
		if(Equalizerband5Enabl != lastEqualizerband5Enabl) isUpdated = true;
		if(Equalizerband5Frequ != lastEqualizerband5Frequ) isUpdated = true;
		if(Equalizerband5Gain != lastEqualizerband5Gain) isUpdated = true;
		if(Equalizerband5Q5 != lastEqualizerband5Q5) isUpdated = true;
		if(Equalizerband5Type != lastEqualizerband5Type) isUpdated = true;
		if(Equalizerband6Enabl != lastEqualizerband6Enabl) isUpdated = true;
		if(Equalizerband6Frequ != lastEqualizerband6Frequ) isUpdated = true;
		if(Equalizerband6Gain != lastEqualizerband6Gain) isUpdated = true;
		if(Equalizerband6Q6 != lastEqualizerband6Q6) isUpdated = true;
		if(Equalizerband6Type != lastEqualizerband6Type) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MEqualizer.dll");
		if(Drywet != lastDrywet) {
			client.sendPacket("parameter 0 "+Drywet);
			lastDrywet = Drywet;
		}
		if(Gain != lastGain) {
			client.sendPacket("parameter 1 "+Gain);
			lastGain = Gain;
		}
		if(Softsaturation != lastSoftsaturation) {
			client.sendPacket("parameter 2 "+Softsaturation);
			lastSoftsaturation = Softsaturation;
		}
		if(Equalizerband1Enabl != lastEqualizerband1Enabl) {
			client.sendPacket("parameter 3 "+Equalizerband1Enabl);
			lastEqualizerband1Enabl = Equalizerband1Enabl;
		}
		if(Equalizerband1Frequ != lastEqualizerband1Frequ) {
			client.sendPacket("parameter 4 "+Equalizerband1Frequ);
			lastEqualizerband1Frequ = Equalizerband1Frequ;
		}
		if(Equalizerband1Gain != lastEqualizerband1Gain) {
			client.sendPacket("parameter 5 "+Equalizerband1Gain);
			lastEqualizerband1Gain = Equalizerband1Gain;
		}
		if(Equalizerband1Q1 != lastEqualizerband1Q1) {
			client.sendPacket("parameter 6 "+Equalizerband1Q1);
			lastEqualizerband1Q1 = Equalizerband1Q1;
		}
		if(Equalizerband1Type != lastEqualizerband1Type) {
			client.sendPacket("parameter 7 "+Equalizerband1Type);
			lastEqualizerband1Type = Equalizerband1Type;
		}
		if(Equalizerband2Enabl != lastEqualizerband2Enabl) {
			client.sendPacket("parameter 10 "+Equalizerband2Enabl);
			lastEqualizerband2Enabl = Equalizerband2Enabl;
		}
		if(Equalizerband2Frequ != lastEqualizerband2Frequ) {
			client.sendPacket("parameter 11 "+Equalizerband2Frequ);
			lastEqualizerband2Frequ = Equalizerband2Frequ;
		}
		if(Equalizerband2Gain != lastEqualizerband2Gain) {
			client.sendPacket("parameter 12 "+Equalizerband2Gain);
			lastEqualizerband2Gain = Equalizerband2Gain;
		}
		if(Equalizerband2Q2 != lastEqualizerband2Q2) {
			client.sendPacket("parameter 13 "+Equalizerband2Q2);
			lastEqualizerband2Q2 = Equalizerband2Q2;
		}
		if(Equalizerband2Type != lastEqualizerband2Type) {
			client.sendPacket("parameter 14 "+Equalizerband2Type);
			lastEqualizerband2Type = Equalizerband2Type;
		}
		if(Equalizerband3Enabl != lastEqualizerband3Enabl) {
			client.sendPacket("parameter 17 "+Equalizerband3Enabl);
			lastEqualizerband3Enabl = Equalizerband3Enabl;
		}
		if(Equalizerband3Frequ != lastEqualizerband3Frequ) {
			client.sendPacket("parameter 18 "+Equalizerband3Frequ);
			lastEqualizerband3Frequ = Equalizerband3Frequ;
		}
		if(Equalizerband3Gain != lastEqualizerband3Gain) {
			client.sendPacket("parameter 19 "+Equalizerband3Gain);
			lastEqualizerband3Gain = Equalizerband3Gain;
		}
		if(Equalizerband3Q3 != lastEqualizerband3Q3) {
			client.sendPacket("parameter 20 "+Equalizerband3Q3);
			lastEqualizerband3Q3 = Equalizerband3Q3;
		}
		if(Equalizerband3Type != lastEqualizerband3Type) {
			client.sendPacket("parameter 21 "+Equalizerband3Type);
			lastEqualizerband3Type = Equalizerband3Type;
		}
		if(Equalizerband4Enabl != lastEqualizerband4Enabl) {
			client.sendPacket("parameter 24 "+Equalizerband4Enabl);
			lastEqualizerband4Enabl = Equalizerband4Enabl;
		}
		if(Equalizerband4Frequ != lastEqualizerband4Frequ) {
			client.sendPacket("parameter 25 "+Equalizerband4Frequ);
			lastEqualizerband4Frequ = Equalizerband4Frequ;
		}
		if(Equalizerband4Gain != lastEqualizerband4Gain) {
			client.sendPacket("parameter 26 "+Equalizerband4Gain);
			lastEqualizerband4Gain = Equalizerband4Gain;
		}
		if(Equalizerband4Q4 != lastEqualizerband4Q4) {
			client.sendPacket("parameter 27 "+Equalizerband4Q4);
			lastEqualizerband4Q4 = Equalizerband4Q4;
		}
		if(Equalizerband4Type != lastEqualizerband4Type) {
			client.sendPacket("parameter 28 "+Equalizerband4Type);
			lastEqualizerband4Type = Equalizerband4Type;
		}
		if(Equalizerband5Enabl != lastEqualizerband5Enabl) {
			client.sendPacket("parameter 31 "+Equalizerband5Enabl);
			lastEqualizerband5Enabl = Equalizerband5Enabl;
		}
		if(Equalizerband5Frequ != lastEqualizerband5Frequ) {
			client.sendPacket("parameter 32 "+Equalizerband5Frequ);
			lastEqualizerband5Frequ = Equalizerband5Frequ;
		}
		if(Equalizerband5Gain != lastEqualizerband5Gain) {
			client.sendPacket("parameter 33 "+Equalizerband5Gain);
			lastEqualizerband5Gain = Equalizerband5Gain;
		}
		if(Equalizerband5Q5 != lastEqualizerband5Q5) {
			client.sendPacket("parameter 34 "+Equalizerband5Q5);
			lastEqualizerband5Q5 = Equalizerband5Q5;
		}
		if(Equalizerband5Type != lastEqualizerband5Type) {
			client.sendPacket("parameter 35 "+Equalizerband5Type);
			lastEqualizerband5Type = Equalizerband5Type;
		}
		if(Equalizerband6Enabl != lastEqualizerband6Enabl) {
			client.sendPacket("parameter 38 "+Equalizerband6Enabl);
			lastEqualizerband6Enabl = Equalizerband6Enabl;
		}
		if(Equalizerband6Frequ != lastEqualizerband6Frequ) {
			client.sendPacket("parameter 39 "+Equalizerband6Frequ);
			lastEqualizerband6Frequ = Equalizerband6Frequ;
		}
		if(Equalizerband6Gain != lastEqualizerband6Gain) {
			client.sendPacket("parameter 40 "+Equalizerband6Gain);
			lastEqualizerband6Gain = Equalizerband6Gain;
		}
		if(Equalizerband6Q6 != lastEqualizerband6Q6) {
			client.sendPacket("parameter 41 "+Equalizerband6Q6);
			lastEqualizerband6Q6 = Equalizerband6Q6;
		}
		if(Equalizerband6Type != lastEqualizerband6Type) {
			client.sendPacket("parameter 42 "+Equalizerband6Type);
			lastEqualizerband6Type = Equalizerband6Type;
		}
	}

	public override void resetStateTrackers() {
		lastDrywet = -1f;
		lastGain = -1f;
		lastSoftsaturation = -1f;
		lastEqualizerband1Enabl = -1f;
		lastEqualizerband1Frequ = -1f;
		lastEqualizerband1Gain = -1f;
		lastEqualizerband1Q1 = -1f;
		lastEqualizerband1Type = -1f;
		lastEqualizerband2Enabl = -1f;
		lastEqualizerband2Frequ = -1f;
		lastEqualizerband2Gain = -1f;
		lastEqualizerband2Q2 = -1f;
		lastEqualizerband2Type = -1f;
		lastEqualizerband3Enabl = -1f;
		lastEqualizerband3Frequ = -1f;
		lastEqualizerband3Gain = -1f;
		lastEqualizerband3Q3 = -1f;
		lastEqualizerband3Type = -1f;
		lastEqualizerband4Enabl = -1f;
		lastEqualizerband4Frequ = -1f;
		lastEqualizerband4Gain = -1f;
		lastEqualizerband4Q4 = -1f;
		lastEqualizerband4Type = -1f;
		lastEqualizerband5Enabl = -1f;
		lastEqualizerband5Frequ = -1f;
		lastEqualizerband5Gain = -1f;
		lastEqualizerband5Q5 = -1f;
		lastEqualizerband5Type = -1f;
		lastEqualizerband6Enabl = -1f;
		lastEqualizerband6Frequ = -1f;
		lastEqualizerband6Gain = -1f;
		lastEqualizerband6Q6 = -1f;
		lastEqualizerband6Type = -1f;
	}
}
