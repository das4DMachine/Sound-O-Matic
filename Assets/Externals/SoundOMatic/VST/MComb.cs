using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MComb")]
public class MComb : VSTFilter {

	public readonly string pluginPath = "MComb.dll";

	public override void resetToDefaults() {
		Drywet = 1.0f;
		Outputgain = 0.5f;
		Filter1Filter1 = 1.0f;
		Filter1Gain = 1.0f;
		Filter1Frequency = 0.4650049f;
		Filter1Feedback = 0.5f;
		Filter1Panorama = 0.5f;
		Filter1Minfrequency = 0.0f;
		Filter1Maxfrequency = 1.0f;
		Filter1Limiterattac = 0.0f;
		Filter1Limiterrelea = 0.17782794f;
		Filter1InvL = 0.0f;
		Filter1InvR = 0.0f;
		Filter1InvfbL = 0.0f;
		Filter1InvfbR = 0.0f;
		Filter2Filter2 = 0.0f;
		Filter2Gain = 1.0f;
		Filter2Frequency = 0.5812561f;
		Filter2Feedback = 0.5f;
		Filter2Panorama = 0.5f;
		Filter2Minfrequency = 0.0f;
		Filter2Maxfrequency = 1.0f;
		Filter2Limiterattac = 0.0f;
		Filter2Limiterrelea = 0.17782794f;
		Filter2InvL = 0.0f;
		Filter2InvR = 0.0f;
		Filter2InvfbL = 0.0f;
		Filter2InvfbR = 0.0f;
		Filter2Serial = 0.0f;
		Filter3Filter3 = 0.0f;
		Filter3Gain = 1.0f;
		Filter3Frequency = 0.6975073f;
		Filter3Feedback = 0.5f;
		Filter3Panorama = 0.5f;
		Filter3Minfrequency = 0.0f;
		Filter3Maxfrequency = 1.0f;
		Filter3Limiterattac = 0.0f;
		Filter3Limiterrelea = 0.17782794f;
		Filter3InvL = 0.0f;
		Filter3InvR = 0.0f;
		Filter3InvfbL = 0.0f;
		Filter3InvfbR = 0.0f;
		Filter3Serial = 0.0f;
		Filter4Filter4 = 0.0f;
		Filter4Gain = 1.0f;
		Filter4Frequency = 0.81375855f;
		Filter4Feedback = 0.5f;
		Filter4Panorama = 0.5f;
		Filter4Minfrequency = 0.0f;
		Filter4Maxfrequency = 1.0f;
		Filter4Limiterattac = 0.0f;
		Filter4Limiterrelea = 0.17782794f;
		Filter4InvL = 0.0f;
		Filter4InvR = 0.0f;
		Filter4InvfbL = 0.0f;
		Filter4InvfbR = 0.0f;
		Filter4Serial = 0.0f;
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
	public float Outputgain = 0.5f;
	private float lastOutputgain = -1f;
	public readonly int OutputgainIndex = 1;
	public readonly string OutputgainLow = "-24.00 dB";
	public readonly string OutputgainHigh = "+24.00 dB";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter1Filter1 = 1.0f;
	private float lastFilter1Filter1 = -1f;
	public readonly int Filter1Filter1Index = 2;
	public readonly string Filter1Filter1Low = "Off";
	public readonly string Filter1Filter1High = "On";

	[Tooltip("silence  |  0.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Filter1Gain = 1.0f;
	private float lastFilter1Gain = -1f;
	public readonly int Filter1GainIndex = 3;
	public readonly string Filter1GainLow = "silence";
	public readonly string Filter1GainHigh = "0.00 dB";

	[Tooltip("1.00 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Filter1Frequency = 0.4650049f;
	private float lastFilter1Frequency = -1f;
	public readonly int Filter1FrequencyIndex = 4;
	public readonly string Filter1FrequencyLow = "1.00 Hz";
	public readonly string Filter1FrequencyHigh = "20.0 kHz";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Filter1Feedback = 0.5f;
	private float lastFilter1Feedback = -1f;
	public readonly int Filter1FeedbackIndex = 5;
	public readonly string Filter1FeedbackLow = "0.00%";
	public readonly string Filter1FeedbackHigh = "100.0%";

	[Tooltip("100% left  |  100% right")]
	[Range(0.0f, 1.0f)]
	public float Filter1Panorama = 0.5f;
	private float lastFilter1Panorama = -1f;
	public readonly int Filter1PanoramaIndex = 6;
	public readonly string Filter1PanoramaLow = "100% left";
	public readonly string Filter1PanoramaHigh = "100% right";

	[Tooltip("Off  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Filter1Minfrequency = 0.0f;
	private float lastFilter1Minfrequency = -1f;
	public readonly int Filter1MinfrequencyIndex = 7;
	public readonly string Filter1MinfrequencyLow = "Off";
	public readonly string Filter1MinfrequencyHigh = "20.0 kHz";

	[Tooltip("20.0 Hz  |  Off")]
	[Range(0.0f, 1.0f)]
	public float Filter1Maxfrequency = 1.0f;
	private float lastFilter1Maxfrequency = -1f;
	public readonly int Filter1MaxfrequencyIndex = 8;
	public readonly string Filter1MaxfrequencyLow = "20.0 Hz";
	public readonly string Filter1MaxfrequencyHigh = "Off";

	[Tooltip("0 ms  |  1000 ms")]
	[Range(0.0f, 1.0f)]
	public float Filter1Limiterattac = 0.0f;
	private float lastFilter1Limiterattac = -1f;
	public readonly int Filter1LimiterattacIndex = 9;
	public readonly string Filter1LimiterattacLow = "0 ms";
	public readonly string Filter1LimiterattacHigh = "1000 ms";

	[Tooltip("Disabled  |  10000 ms")]
	[Range(0.0f, 1.0f)]
	public float Filter1Limiterrelea = 0.17782794f;
	private float lastFilter1Limiterrelea = -1f;
	public readonly int Filter1LimiterreleaIndex = 10;
	public readonly string Filter1LimiterreleaLow = "Disabled";
	public readonly string Filter1LimiterreleaHigh = "10000 ms";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter1InvL = 0.0f;
	private float lastFilter1InvL = -1f;
	public readonly int Filter1InvLIndex = 11;
	public readonly string Filter1InvLLow = "Off";
	public readonly string Filter1InvLHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter1InvR = 0.0f;
	private float lastFilter1InvR = -1f;
	public readonly int Filter1InvRIndex = 12;
	public readonly string Filter1InvRLow = "Off";
	public readonly string Filter1InvRHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter1InvfbL = 0.0f;
	private float lastFilter1InvfbL = -1f;
	public readonly int Filter1InvfbLIndex = 13;
	public readonly string Filter1InvfbLLow = "Off";
	public readonly string Filter1InvfbLHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter1InvfbR = 0.0f;
	private float lastFilter1InvfbR = -1f;
	public readonly int Filter1InvfbRIndex = 14;
	public readonly string Filter1InvfbRLow = "Off";
	public readonly string Filter1InvfbRHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter2Filter2 = 0.0f;
	private float lastFilter2Filter2 = -1f;
	public readonly int Filter2Filter2Index = 15;
	public readonly string Filter2Filter2Low = "Off";
	public readonly string Filter2Filter2High = "On";

	[Tooltip("silence  |  0.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Filter2Gain = 1.0f;
	private float lastFilter2Gain = -1f;
	public readonly int Filter2GainIndex = 16;
	public readonly string Filter2GainLow = "silence";
	public readonly string Filter2GainHigh = "0.00 dB";

	[Tooltip("1.00 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Filter2Frequency = 0.5812561f;
	private float lastFilter2Frequency = -1f;
	public readonly int Filter2FrequencyIndex = 17;
	public readonly string Filter2FrequencyLow = "1.00 Hz";
	public readonly string Filter2FrequencyHigh = "20.0 kHz";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Filter2Feedback = 0.5f;
	private float lastFilter2Feedback = -1f;
	public readonly int Filter2FeedbackIndex = 18;
	public readonly string Filter2FeedbackLow = "0.00%";
	public readonly string Filter2FeedbackHigh = "100.0%";

	[Tooltip("100% left  |  100% right")]
	[Range(0.0f, 1.0f)]
	public float Filter2Panorama = 0.5f;
	private float lastFilter2Panorama = -1f;
	public readonly int Filter2PanoramaIndex = 19;
	public readonly string Filter2PanoramaLow = "100% left";
	public readonly string Filter2PanoramaHigh = "100% right";

	[Tooltip("Off  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Filter2Minfrequency = 0.0f;
	private float lastFilter2Minfrequency = -1f;
	public readonly int Filter2MinfrequencyIndex = 20;
	public readonly string Filter2MinfrequencyLow = "Off";
	public readonly string Filter2MinfrequencyHigh = "20.0 kHz";

	[Tooltip("20.0 Hz  |  Off")]
	[Range(0.0f, 1.0f)]
	public float Filter2Maxfrequency = 1.0f;
	private float lastFilter2Maxfrequency = -1f;
	public readonly int Filter2MaxfrequencyIndex = 21;
	public readonly string Filter2MaxfrequencyLow = "20.0 Hz";
	public readonly string Filter2MaxfrequencyHigh = "Off";

	[Tooltip("0 ms  |  1000 ms")]
	[Range(0.0f, 1.0f)]
	public float Filter2Limiterattac = 0.0f;
	private float lastFilter2Limiterattac = -1f;
	public readonly int Filter2LimiterattacIndex = 22;
	public readonly string Filter2LimiterattacLow = "0 ms";
	public readonly string Filter2LimiterattacHigh = "1000 ms";

	[Tooltip("Disabled  |  10000 ms")]
	[Range(0.0f, 1.0f)]
	public float Filter2Limiterrelea = 0.17782794f;
	private float lastFilter2Limiterrelea = -1f;
	public readonly int Filter2LimiterreleaIndex = 23;
	public readonly string Filter2LimiterreleaLow = "Disabled";
	public readonly string Filter2LimiterreleaHigh = "10000 ms";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter2InvL = 0.0f;
	private float lastFilter2InvL = -1f;
	public readonly int Filter2InvLIndex = 24;
	public readonly string Filter2InvLLow = "Off";
	public readonly string Filter2InvLHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter2InvR = 0.0f;
	private float lastFilter2InvR = -1f;
	public readonly int Filter2InvRIndex = 25;
	public readonly string Filter2InvRLow = "Off";
	public readonly string Filter2InvRHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter2InvfbL = 0.0f;
	private float lastFilter2InvfbL = -1f;
	public readonly int Filter2InvfbLIndex = 26;
	public readonly string Filter2InvfbLLow = "Off";
	public readonly string Filter2InvfbLHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter2InvfbR = 0.0f;
	private float lastFilter2InvfbR = -1f;
	public readonly int Filter2InvfbRIndex = 27;
	public readonly string Filter2InvfbRLow = "Off";
	public readonly string Filter2InvfbRHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter2Serial = 0.0f;
	private float lastFilter2Serial = -1f;
	public readonly int Filter2SerialIndex = 28;
	public readonly string Filter2SerialLow = "Off";
	public readonly string Filter2SerialHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter3Filter3 = 0.0f;
	private float lastFilter3Filter3 = -1f;
	public readonly int Filter3Filter3Index = 29;
	public readonly string Filter3Filter3Low = "Off";
	public readonly string Filter3Filter3High = "On";

	[Tooltip("silence  |  0.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Filter3Gain = 1.0f;
	private float lastFilter3Gain = -1f;
	public readonly int Filter3GainIndex = 30;
	public readonly string Filter3GainLow = "silence";
	public readonly string Filter3GainHigh = "0.00 dB";

	[Tooltip("1.00 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Filter3Frequency = 0.6975073f;
	private float lastFilter3Frequency = -1f;
	public readonly int Filter3FrequencyIndex = 31;
	public readonly string Filter3FrequencyLow = "1.00 Hz";
	public readonly string Filter3FrequencyHigh = "20.0 kHz";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Filter3Feedback = 0.5f;
	private float lastFilter3Feedback = -1f;
	public readonly int Filter3FeedbackIndex = 32;
	public readonly string Filter3FeedbackLow = "0.00%";
	public readonly string Filter3FeedbackHigh = "100.0%";

	[Tooltip("100% left  |  100% right")]
	[Range(0.0f, 1.0f)]
	public float Filter3Panorama = 0.5f;
	private float lastFilter3Panorama = -1f;
	public readonly int Filter3PanoramaIndex = 33;
	public readonly string Filter3PanoramaLow = "100% left";
	public readonly string Filter3PanoramaHigh = "100% right";

	[Tooltip("Off  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Filter3Minfrequency = 0.0f;
	private float lastFilter3Minfrequency = -1f;
	public readonly int Filter3MinfrequencyIndex = 34;
	public readonly string Filter3MinfrequencyLow = "Off";
	public readonly string Filter3MinfrequencyHigh = "20.0 kHz";

	[Tooltip("20.0 Hz  |  Off")]
	[Range(0.0f, 1.0f)]
	public float Filter3Maxfrequency = 1.0f;
	private float lastFilter3Maxfrequency = -1f;
	public readonly int Filter3MaxfrequencyIndex = 35;
	public readonly string Filter3MaxfrequencyLow = "20.0 Hz";
	public readonly string Filter3MaxfrequencyHigh = "Off";

	[Tooltip("0 ms  |  1000 ms")]
	[Range(0.0f, 1.0f)]
	public float Filter3Limiterattac = 0.0f;
	private float lastFilter3Limiterattac = -1f;
	public readonly int Filter3LimiterattacIndex = 36;
	public readonly string Filter3LimiterattacLow = "0 ms";
	public readonly string Filter3LimiterattacHigh = "1000 ms";

	[Tooltip("Disabled  |  10000 ms")]
	[Range(0.0f, 1.0f)]
	public float Filter3Limiterrelea = 0.17782794f;
	private float lastFilter3Limiterrelea = -1f;
	public readonly int Filter3LimiterreleaIndex = 37;
	public readonly string Filter3LimiterreleaLow = "Disabled";
	public readonly string Filter3LimiterreleaHigh = "10000 ms";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter3InvL = 0.0f;
	private float lastFilter3InvL = -1f;
	public readonly int Filter3InvLIndex = 38;
	public readonly string Filter3InvLLow = "Off";
	public readonly string Filter3InvLHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter3InvR = 0.0f;
	private float lastFilter3InvR = -1f;
	public readonly int Filter3InvRIndex = 39;
	public readonly string Filter3InvRLow = "Off";
	public readonly string Filter3InvRHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter3InvfbL = 0.0f;
	private float lastFilter3InvfbL = -1f;
	public readonly int Filter3InvfbLIndex = 40;
	public readonly string Filter3InvfbLLow = "Off";
	public readonly string Filter3InvfbLHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter3InvfbR = 0.0f;
	private float lastFilter3InvfbR = -1f;
	public readonly int Filter3InvfbRIndex = 41;
	public readonly string Filter3InvfbRLow = "Off";
	public readonly string Filter3InvfbRHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter3Serial = 0.0f;
	private float lastFilter3Serial = -1f;
	public readonly int Filter3SerialIndex = 42;
	public readonly string Filter3SerialLow = "Off";
	public readonly string Filter3SerialHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter4Filter4 = 0.0f;
	private float lastFilter4Filter4 = -1f;
	public readonly int Filter4Filter4Index = 43;
	public readonly string Filter4Filter4Low = "Off";
	public readonly string Filter4Filter4High = "On";

	[Tooltip("silence  |  0.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Filter4Gain = 1.0f;
	private float lastFilter4Gain = -1f;
	public readonly int Filter4GainIndex = 44;
	public readonly string Filter4GainLow = "silence";
	public readonly string Filter4GainHigh = "0.00 dB";

	[Tooltip("1.00 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Filter4Frequency = 0.81375855f;
	private float lastFilter4Frequency = -1f;
	public readonly int Filter4FrequencyIndex = 45;
	public readonly string Filter4FrequencyLow = "1.00 Hz";
	public readonly string Filter4FrequencyHigh = "20.0 kHz";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Filter4Feedback = 0.5f;
	private float lastFilter4Feedback = -1f;
	public readonly int Filter4FeedbackIndex = 46;
	public readonly string Filter4FeedbackLow = "0.00%";
	public readonly string Filter4FeedbackHigh = "100.0%";

	[Tooltip("100% left  |  100% right")]
	[Range(0.0f, 1.0f)]
	public float Filter4Panorama = 0.5f;
	private float lastFilter4Panorama = -1f;
	public readonly int Filter4PanoramaIndex = 47;
	public readonly string Filter4PanoramaLow = "100% left";
	public readonly string Filter4PanoramaHigh = "100% right";

	[Tooltip("Off  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Filter4Minfrequency = 0.0f;
	private float lastFilter4Minfrequency = -1f;
	public readonly int Filter4MinfrequencyIndex = 48;
	public readonly string Filter4MinfrequencyLow = "Off";
	public readonly string Filter4MinfrequencyHigh = "20.0 kHz";

	[Tooltip("20.0 Hz  |  Off")]
	[Range(0.0f, 1.0f)]
	public float Filter4Maxfrequency = 1.0f;
	private float lastFilter4Maxfrequency = -1f;
	public readonly int Filter4MaxfrequencyIndex = 49;
	public readonly string Filter4MaxfrequencyLow = "20.0 Hz";
	public readonly string Filter4MaxfrequencyHigh = "Off";

	[Tooltip("0 ms  |  1000 ms")]
	[Range(0.0f, 1.0f)]
	public float Filter4Limiterattac = 0.0f;
	private float lastFilter4Limiterattac = -1f;
	public readonly int Filter4LimiterattacIndex = 50;
	public readonly string Filter4LimiterattacLow = "0 ms";
	public readonly string Filter4LimiterattacHigh = "1000 ms";

	[Tooltip("Disabled  |  10000 ms")]
	[Range(0.0f, 1.0f)]
	public float Filter4Limiterrelea = 0.17782794f;
	private float lastFilter4Limiterrelea = -1f;
	public readonly int Filter4LimiterreleaIndex = 51;
	public readonly string Filter4LimiterreleaLow = "Disabled";
	public readonly string Filter4LimiterreleaHigh = "10000 ms";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter4InvL = 0.0f;
	private float lastFilter4InvL = -1f;
	public readonly int Filter4InvLIndex = 52;
	public readonly string Filter4InvLLow = "Off";
	public readonly string Filter4InvLHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter4InvR = 0.0f;
	private float lastFilter4InvR = -1f;
	public readonly int Filter4InvRIndex = 53;
	public readonly string Filter4InvRLow = "Off";
	public readonly string Filter4InvRHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter4InvfbL = 0.0f;
	private float lastFilter4InvfbL = -1f;
	public readonly int Filter4InvfbLIndex = 54;
	public readonly string Filter4InvfbLLow = "Off";
	public readonly string Filter4InvfbLHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter4InvfbR = 0.0f;
	private float lastFilter4InvfbR = -1f;
	public readonly int Filter4InvfbRIndex = 55;
	public readonly string Filter4InvfbRLow = "Off";
	public readonly string Filter4InvfbRHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Filter4Serial = 0.0f;
	private float lastFilter4Serial = -1f;
	public readonly int Filter4SerialIndex = 56;
	public readonly string Filter4SerialLow = "Off";
	public readonly string Filter4SerialHigh = "On";

	public override string getFilterName() {
		return "./vst/MComb.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Drywet != lastDrywet) isUpdated = true;
		if(Outputgain != lastOutputgain) isUpdated = true;
		if(Filter1Filter1 != lastFilter1Filter1) isUpdated = true;
		if(Filter1Gain != lastFilter1Gain) isUpdated = true;
		if(Filter1Frequency != lastFilter1Frequency) isUpdated = true;
		if(Filter1Feedback != lastFilter1Feedback) isUpdated = true;
		if(Filter1Panorama != lastFilter1Panorama) isUpdated = true;
		if(Filter1Minfrequency != lastFilter1Minfrequency) isUpdated = true;
		if(Filter1Maxfrequency != lastFilter1Maxfrequency) isUpdated = true;
		if(Filter1Limiterattac != lastFilter1Limiterattac) isUpdated = true;
		if(Filter1Limiterrelea != lastFilter1Limiterrelea) isUpdated = true;
		if(Filter1InvL != lastFilter1InvL) isUpdated = true;
		if(Filter1InvR != lastFilter1InvR) isUpdated = true;
		if(Filter1InvfbL != lastFilter1InvfbL) isUpdated = true;
		if(Filter1InvfbR != lastFilter1InvfbR) isUpdated = true;
		if(Filter2Filter2 != lastFilter2Filter2) isUpdated = true;
		if(Filter2Gain != lastFilter2Gain) isUpdated = true;
		if(Filter2Frequency != lastFilter2Frequency) isUpdated = true;
		if(Filter2Feedback != lastFilter2Feedback) isUpdated = true;
		if(Filter2Panorama != lastFilter2Panorama) isUpdated = true;
		if(Filter2Minfrequency != lastFilter2Minfrequency) isUpdated = true;
		if(Filter2Maxfrequency != lastFilter2Maxfrequency) isUpdated = true;
		if(Filter2Limiterattac != lastFilter2Limiterattac) isUpdated = true;
		if(Filter2Limiterrelea != lastFilter2Limiterrelea) isUpdated = true;
		if(Filter2InvL != lastFilter2InvL) isUpdated = true;
		if(Filter2InvR != lastFilter2InvR) isUpdated = true;
		if(Filter2InvfbL != lastFilter2InvfbL) isUpdated = true;
		if(Filter2InvfbR != lastFilter2InvfbR) isUpdated = true;
		if(Filter2Serial != lastFilter2Serial) isUpdated = true;
		if(Filter3Filter3 != lastFilter3Filter3) isUpdated = true;
		if(Filter3Gain != lastFilter3Gain) isUpdated = true;
		if(Filter3Frequency != lastFilter3Frequency) isUpdated = true;
		if(Filter3Feedback != lastFilter3Feedback) isUpdated = true;
		if(Filter3Panorama != lastFilter3Panorama) isUpdated = true;
		if(Filter3Minfrequency != lastFilter3Minfrequency) isUpdated = true;
		if(Filter3Maxfrequency != lastFilter3Maxfrequency) isUpdated = true;
		if(Filter3Limiterattac != lastFilter3Limiterattac) isUpdated = true;
		if(Filter3Limiterrelea != lastFilter3Limiterrelea) isUpdated = true;
		if(Filter3InvL != lastFilter3InvL) isUpdated = true;
		if(Filter3InvR != lastFilter3InvR) isUpdated = true;
		if(Filter3InvfbL != lastFilter3InvfbL) isUpdated = true;
		if(Filter3InvfbR != lastFilter3InvfbR) isUpdated = true;
		if(Filter3Serial != lastFilter3Serial) isUpdated = true;
		if(Filter4Filter4 != lastFilter4Filter4) isUpdated = true;
		if(Filter4Gain != lastFilter4Gain) isUpdated = true;
		if(Filter4Frequency != lastFilter4Frequency) isUpdated = true;
		if(Filter4Feedback != lastFilter4Feedback) isUpdated = true;
		if(Filter4Panorama != lastFilter4Panorama) isUpdated = true;
		if(Filter4Minfrequency != lastFilter4Minfrequency) isUpdated = true;
		if(Filter4Maxfrequency != lastFilter4Maxfrequency) isUpdated = true;
		if(Filter4Limiterattac != lastFilter4Limiterattac) isUpdated = true;
		if(Filter4Limiterrelea != lastFilter4Limiterrelea) isUpdated = true;
		if(Filter4InvL != lastFilter4InvL) isUpdated = true;
		if(Filter4InvR != lastFilter4InvR) isUpdated = true;
		if(Filter4InvfbL != lastFilter4InvfbL) isUpdated = true;
		if(Filter4InvfbR != lastFilter4InvfbR) isUpdated = true;
		if(Filter4Serial != lastFilter4Serial) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MComb.dll");
		if(Drywet != lastDrywet) {
			client.sendPacket("parameter 0 "+Drywet);
			lastDrywet = Drywet;
		}
		if(Outputgain != lastOutputgain) {
			client.sendPacket("parameter 1 "+Outputgain);
			lastOutputgain = Outputgain;
		}
		if(Filter1Filter1 != lastFilter1Filter1) {
			client.sendPacket("parameter 2 "+Filter1Filter1);
			lastFilter1Filter1 = Filter1Filter1;
		}
		if(Filter1Gain != lastFilter1Gain) {
			client.sendPacket("parameter 3 "+Filter1Gain);
			lastFilter1Gain = Filter1Gain;
		}
		if(Filter1Frequency != lastFilter1Frequency) {
			client.sendPacket("parameter 4 "+Filter1Frequency);
			lastFilter1Frequency = Filter1Frequency;
		}
		if(Filter1Feedback != lastFilter1Feedback) {
			client.sendPacket("parameter 5 "+Filter1Feedback);
			lastFilter1Feedback = Filter1Feedback;
		}
		if(Filter1Panorama != lastFilter1Panorama) {
			client.sendPacket("parameter 6 "+Filter1Panorama);
			lastFilter1Panorama = Filter1Panorama;
		}
		if(Filter1Minfrequency != lastFilter1Minfrequency) {
			client.sendPacket("parameter 7 "+Filter1Minfrequency);
			lastFilter1Minfrequency = Filter1Minfrequency;
		}
		if(Filter1Maxfrequency != lastFilter1Maxfrequency) {
			client.sendPacket("parameter 8 "+Filter1Maxfrequency);
			lastFilter1Maxfrequency = Filter1Maxfrequency;
		}
		if(Filter1Limiterattac != lastFilter1Limiterattac) {
			client.sendPacket("parameter 9 "+Filter1Limiterattac);
			lastFilter1Limiterattac = Filter1Limiterattac;
		}
		if(Filter1Limiterrelea != lastFilter1Limiterrelea) {
			client.sendPacket("parameter 10 "+Filter1Limiterrelea);
			lastFilter1Limiterrelea = Filter1Limiterrelea;
		}
		if(Filter1InvL != lastFilter1InvL) {
			client.sendPacket("parameter 11 "+Filter1InvL);
			lastFilter1InvL = Filter1InvL;
		}
		if(Filter1InvR != lastFilter1InvR) {
			client.sendPacket("parameter 12 "+Filter1InvR);
			lastFilter1InvR = Filter1InvR;
		}
		if(Filter1InvfbL != lastFilter1InvfbL) {
			client.sendPacket("parameter 13 "+Filter1InvfbL);
			lastFilter1InvfbL = Filter1InvfbL;
		}
		if(Filter1InvfbR != lastFilter1InvfbR) {
			client.sendPacket("parameter 14 "+Filter1InvfbR);
			lastFilter1InvfbR = Filter1InvfbR;
		}
		if(Filter2Filter2 != lastFilter2Filter2) {
			client.sendPacket("parameter 15 "+Filter2Filter2);
			lastFilter2Filter2 = Filter2Filter2;
		}
		if(Filter2Gain != lastFilter2Gain) {
			client.sendPacket("parameter 16 "+Filter2Gain);
			lastFilter2Gain = Filter2Gain;
		}
		if(Filter2Frequency != lastFilter2Frequency) {
			client.sendPacket("parameter 17 "+Filter2Frequency);
			lastFilter2Frequency = Filter2Frequency;
		}
		if(Filter2Feedback != lastFilter2Feedback) {
			client.sendPacket("parameter 18 "+Filter2Feedback);
			lastFilter2Feedback = Filter2Feedback;
		}
		if(Filter2Panorama != lastFilter2Panorama) {
			client.sendPacket("parameter 19 "+Filter2Panorama);
			lastFilter2Panorama = Filter2Panorama;
		}
		if(Filter2Minfrequency != lastFilter2Minfrequency) {
			client.sendPacket("parameter 20 "+Filter2Minfrequency);
			lastFilter2Minfrequency = Filter2Minfrequency;
		}
		if(Filter2Maxfrequency != lastFilter2Maxfrequency) {
			client.sendPacket("parameter 21 "+Filter2Maxfrequency);
			lastFilter2Maxfrequency = Filter2Maxfrequency;
		}
		if(Filter2Limiterattac != lastFilter2Limiterattac) {
			client.sendPacket("parameter 22 "+Filter2Limiterattac);
			lastFilter2Limiterattac = Filter2Limiterattac;
		}
		if(Filter2Limiterrelea != lastFilter2Limiterrelea) {
			client.sendPacket("parameter 23 "+Filter2Limiterrelea);
			lastFilter2Limiterrelea = Filter2Limiterrelea;
		}
		if(Filter2InvL != lastFilter2InvL) {
			client.sendPacket("parameter 24 "+Filter2InvL);
			lastFilter2InvL = Filter2InvL;
		}
		if(Filter2InvR != lastFilter2InvR) {
			client.sendPacket("parameter 25 "+Filter2InvR);
			lastFilter2InvR = Filter2InvR;
		}
		if(Filter2InvfbL != lastFilter2InvfbL) {
			client.sendPacket("parameter 26 "+Filter2InvfbL);
			lastFilter2InvfbL = Filter2InvfbL;
		}
		if(Filter2InvfbR != lastFilter2InvfbR) {
			client.sendPacket("parameter 27 "+Filter2InvfbR);
			lastFilter2InvfbR = Filter2InvfbR;
		}
		if(Filter2Serial != lastFilter2Serial) {
			client.sendPacket("parameter 28 "+Filter2Serial);
			lastFilter2Serial = Filter2Serial;
		}
		if(Filter3Filter3 != lastFilter3Filter3) {
			client.sendPacket("parameter 29 "+Filter3Filter3);
			lastFilter3Filter3 = Filter3Filter3;
		}
		if(Filter3Gain != lastFilter3Gain) {
			client.sendPacket("parameter 30 "+Filter3Gain);
			lastFilter3Gain = Filter3Gain;
		}
		if(Filter3Frequency != lastFilter3Frequency) {
			client.sendPacket("parameter 31 "+Filter3Frequency);
			lastFilter3Frequency = Filter3Frequency;
		}
		if(Filter3Feedback != lastFilter3Feedback) {
			client.sendPacket("parameter 32 "+Filter3Feedback);
			lastFilter3Feedback = Filter3Feedback;
		}
		if(Filter3Panorama != lastFilter3Panorama) {
			client.sendPacket("parameter 33 "+Filter3Panorama);
			lastFilter3Panorama = Filter3Panorama;
		}
		if(Filter3Minfrequency != lastFilter3Minfrequency) {
			client.sendPacket("parameter 34 "+Filter3Minfrequency);
			lastFilter3Minfrequency = Filter3Minfrequency;
		}
		if(Filter3Maxfrequency != lastFilter3Maxfrequency) {
			client.sendPacket("parameter 35 "+Filter3Maxfrequency);
			lastFilter3Maxfrequency = Filter3Maxfrequency;
		}
		if(Filter3Limiterattac != lastFilter3Limiterattac) {
			client.sendPacket("parameter 36 "+Filter3Limiterattac);
			lastFilter3Limiterattac = Filter3Limiterattac;
		}
		if(Filter3Limiterrelea != lastFilter3Limiterrelea) {
			client.sendPacket("parameter 37 "+Filter3Limiterrelea);
			lastFilter3Limiterrelea = Filter3Limiterrelea;
		}
		if(Filter3InvL != lastFilter3InvL) {
			client.sendPacket("parameter 38 "+Filter3InvL);
			lastFilter3InvL = Filter3InvL;
		}
		if(Filter3InvR != lastFilter3InvR) {
			client.sendPacket("parameter 39 "+Filter3InvR);
			lastFilter3InvR = Filter3InvR;
		}
		if(Filter3InvfbL != lastFilter3InvfbL) {
			client.sendPacket("parameter 40 "+Filter3InvfbL);
			lastFilter3InvfbL = Filter3InvfbL;
		}
		if(Filter3InvfbR != lastFilter3InvfbR) {
			client.sendPacket("parameter 41 "+Filter3InvfbR);
			lastFilter3InvfbR = Filter3InvfbR;
		}
		if(Filter3Serial != lastFilter3Serial) {
			client.sendPacket("parameter 42 "+Filter3Serial);
			lastFilter3Serial = Filter3Serial;
		}
		if(Filter4Filter4 != lastFilter4Filter4) {
			client.sendPacket("parameter 43 "+Filter4Filter4);
			lastFilter4Filter4 = Filter4Filter4;
		}
		if(Filter4Gain != lastFilter4Gain) {
			client.sendPacket("parameter 44 "+Filter4Gain);
			lastFilter4Gain = Filter4Gain;
		}
		if(Filter4Frequency != lastFilter4Frequency) {
			client.sendPacket("parameter 45 "+Filter4Frequency);
			lastFilter4Frequency = Filter4Frequency;
		}
		if(Filter4Feedback != lastFilter4Feedback) {
			client.sendPacket("parameter 46 "+Filter4Feedback);
			lastFilter4Feedback = Filter4Feedback;
		}
		if(Filter4Panorama != lastFilter4Panorama) {
			client.sendPacket("parameter 47 "+Filter4Panorama);
			lastFilter4Panorama = Filter4Panorama;
		}
		if(Filter4Minfrequency != lastFilter4Minfrequency) {
			client.sendPacket("parameter 48 "+Filter4Minfrequency);
			lastFilter4Minfrequency = Filter4Minfrequency;
		}
		if(Filter4Maxfrequency != lastFilter4Maxfrequency) {
			client.sendPacket("parameter 49 "+Filter4Maxfrequency);
			lastFilter4Maxfrequency = Filter4Maxfrequency;
		}
		if(Filter4Limiterattac != lastFilter4Limiterattac) {
			client.sendPacket("parameter 50 "+Filter4Limiterattac);
			lastFilter4Limiterattac = Filter4Limiterattac;
		}
		if(Filter4Limiterrelea != lastFilter4Limiterrelea) {
			client.sendPacket("parameter 51 "+Filter4Limiterrelea);
			lastFilter4Limiterrelea = Filter4Limiterrelea;
		}
		if(Filter4InvL != lastFilter4InvL) {
			client.sendPacket("parameter 52 "+Filter4InvL);
			lastFilter4InvL = Filter4InvL;
		}
		if(Filter4InvR != lastFilter4InvR) {
			client.sendPacket("parameter 53 "+Filter4InvR);
			lastFilter4InvR = Filter4InvR;
		}
		if(Filter4InvfbL != lastFilter4InvfbL) {
			client.sendPacket("parameter 54 "+Filter4InvfbL);
			lastFilter4InvfbL = Filter4InvfbL;
		}
		if(Filter4InvfbR != lastFilter4InvfbR) {
			client.sendPacket("parameter 55 "+Filter4InvfbR);
			lastFilter4InvfbR = Filter4InvfbR;
		}
		if(Filter4Serial != lastFilter4Serial) {
			client.sendPacket("parameter 56 "+Filter4Serial);
			lastFilter4Serial = Filter4Serial;
		}
	}

	public override void resetStateTrackers() {
		lastDrywet = -1f;
		lastOutputgain = -1f;
		lastFilter1Filter1 = -1f;
		lastFilter1Gain = -1f;
		lastFilter1Frequency = -1f;
		lastFilter1Feedback = -1f;
		lastFilter1Panorama = -1f;
		lastFilter1Minfrequency = -1f;
		lastFilter1Maxfrequency = -1f;
		lastFilter1Limiterattac = -1f;
		lastFilter1Limiterrelea = -1f;
		lastFilter1InvL = -1f;
		lastFilter1InvR = -1f;
		lastFilter1InvfbL = -1f;
		lastFilter1InvfbR = -1f;
		lastFilter2Filter2 = -1f;
		lastFilter2Gain = -1f;
		lastFilter2Frequency = -1f;
		lastFilter2Feedback = -1f;
		lastFilter2Panorama = -1f;
		lastFilter2Minfrequency = -1f;
		lastFilter2Maxfrequency = -1f;
		lastFilter2Limiterattac = -1f;
		lastFilter2Limiterrelea = -1f;
		lastFilter2InvL = -1f;
		lastFilter2InvR = -1f;
		lastFilter2InvfbL = -1f;
		lastFilter2InvfbR = -1f;
		lastFilter2Serial = -1f;
		lastFilter3Filter3 = -1f;
		lastFilter3Gain = -1f;
		lastFilter3Frequency = -1f;
		lastFilter3Feedback = -1f;
		lastFilter3Panorama = -1f;
		lastFilter3Minfrequency = -1f;
		lastFilter3Maxfrequency = -1f;
		lastFilter3Limiterattac = -1f;
		lastFilter3Limiterrelea = -1f;
		lastFilter3InvL = -1f;
		lastFilter3InvR = -1f;
		lastFilter3InvfbL = -1f;
		lastFilter3InvfbR = -1f;
		lastFilter3Serial = -1f;
		lastFilter4Filter4 = -1f;
		lastFilter4Gain = -1f;
		lastFilter4Frequency = -1f;
		lastFilter4Feedback = -1f;
		lastFilter4Panorama = -1f;
		lastFilter4Minfrequency = -1f;
		lastFilter4Maxfrequency = -1f;
		lastFilter4Limiterattac = -1f;
		lastFilter4Limiterrelea = -1f;
		lastFilter4InvL = -1f;
		lastFilter4InvR = -1f;
		lastFilter4InvfbL = -1f;
		lastFilter4InvfbR = -1f;
		lastFilter4Serial = -1f;
	}
}
