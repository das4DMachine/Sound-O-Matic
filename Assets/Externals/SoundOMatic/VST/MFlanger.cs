using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MFlanger")]
public class MFlanger : VSTFilter {

	public readonly string pluginPath = "MFlanger.dll";

	public override void resetToDefaults() {
		Mode = 0.0f;
		Depth = 0.75f;
		Range = 0.28284273f;
		Rate = 0.3941285f;
		Feedback = 0.5f;
		Phasedifference = 0.5f;
		Delay = 0.0f;
		Minfrequency = 0.10034333f;
		Maxfrequency = 1.0f;
		Jet = 0.5f;
		Jetphase = 0.0f;
		Saturation = 0.0f;
		ShapeShape = 0.33333334f;
		ShapeCustommorph = 0.0f;
		ShapeSmoothness = 0.0f;
	}

	[Tooltip("Default  |  Tape 2")]
	[Range(0.0f, 1.0f)]
	public float Mode = 0.0f;
	private float lastMode = -1f;
	public readonly int ModeIndex = 0;
	public readonly string ModeLow = "Default";
	public readonly string ModeHigh = "Tape 2";

	[Tooltip("-100% wet, 0% dry  |  100% wet, 0% dry")]
	[Range(0.0f, 1.0f)]
	public float Depth = 0.75f;
	private float lastDepth = -1f;
	public readonly int DepthIndex = 1;
	public readonly string DepthLow = "-100% wet, 0% dry";
	public readonly string DepthHigh = "100% wet, 0% dry";

	[Tooltip("0 ms  |  10 ms")]
	[Range(0.0f, 1.0f)]
	public float Range = 0.28284273f;
	private float lastRange = -1f;
	public readonly int RangeIndex = 2;
	public readonly string RangeLow = "0 ms";
	public readonly string RangeHigh = "10 ms";

	[Tooltip("0.0100 Hz  |  20.0 Hz")]
	[Range(0.0f, 1.0f)]
	public float Rate = 0.3941285f;
	private float lastRate = -1f;
	public readonly int RateIndex = 3;
	public readonly string RateLow = "0.0100 Hz";
	public readonly string RateHigh = "20.0 Hz";

	[Tooltip("-100.0%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Feedback = 0.5f;
	private float lastFeedback = -1f;
	public readonly int FeedbackIndex = 4;
	public readonly string FeedbackLow = "-100.0%";
	public readonly string FeedbackHigh = "100.0%";

	[Tooltip("-360° (-100.0%)  |  360° (100.0%)")]
	[Range(0.0f, 1.0f)]
	public float Phasedifference = 0.5f;
	private float lastPhasedifference = -1f;
	public readonly int PhasedifferenceIndex = 5;
	public readonly string PhasedifferenceLow = "-360° (-100.0%)";
	public readonly string PhasedifferenceHigh = "360° (100.0%)";

	[Tooltip("0 ms  |  20 ms")]
	[Range(0.0f, 1.0f)]
	public float Delay = 0.0f;
	private float lastDelay = -1f;
	public readonly int DelayIndex = 6;
	public readonly string DelayLow = "0 ms";
	public readonly string DelayHigh = "20 ms";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Minfrequency = 0.10034333f;
	private float lastMinfrequency = -1f;
	public readonly int MinfrequencyIndex = 7;
	public readonly string MinfrequencyLow = "20.0 Hz";
	public readonly string MinfrequencyHigh = "20.0 kHz";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Maxfrequency = 1.0f;
	private float lastMaxfrequency = -1f;
	public readonly int MaxfrequencyIndex = 8;
	public readonly string MaxfrequencyLow = "20.0 Hz";
	public readonly string MaxfrequencyHigh = "20.0 kHz";

	[Tooltip("-100.0%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Jet = 0.5f;
	private float lastJet = -1f;
	public readonly int JetIndex = 9;
	public readonly string JetLow = "-100.0%";
	public readonly string JetHigh = "100.0%";

	[Tooltip("0° (0%)  |  360° (100.0%)")]
	[Range(0.0f, 1.0f)]
	public float Jetphase = 0.0f;
	private float lastJetphase = -1f;
	public readonly int JetphaseIndex = 10;
	public readonly string JetphaseLow = "0° (0%)";
	public readonly string JetphaseHigh = "360° (100.0%)";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Saturation = 0.0f;
	private float lastSaturation = -1f;
	public readonly int SaturationIndex = 11;
	public readonly string SaturationLow = "0.00%";
	public readonly string SaturationHigh = "100.0%";

	[Tooltip("Exponential  |  Mess")]
	[Range(0.0f, 1.0f)]
	public float ShapeShape = 0.33333334f;
	private float lastShapeShape = -1f;
	public readonly int ShapeShapeIndex = 16;
	public readonly string ShapeShapeLow = "Exponential";
	public readonly string ShapeShapeHigh = "Mess";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float ShapeCustommorph = 0.0f;
	private float lastShapeCustommorph = -1f;
	public readonly int ShapeCustommorphIndex = 17;
	public readonly string ShapeCustommorphLow = "0.00%";
	public readonly string ShapeCustommorphHigh = "100.0%";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float ShapeSmoothness = 0.0f;
	private float lastShapeSmoothness = -1f;
	public readonly int ShapeSmoothnessIndex = 19;
	public readonly string ShapeSmoothnessLow = "0.00%";
	public readonly string ShapeSmoothnessHigh = "100.0%";

	public override string getFilterName() {
		return "./vst/MFlanger.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Mode != lastMode) isUpdated = true;
		if(Depth != lastDepth) isUpdated = true;
		if(Range != lastRange) isUpdated = true;
		if(Rate != lastRate) isUpdated = true;
		if(Feedback != lastFeedback) isUpdated = true;
		if(Phasedifference != lastPhasedifference) isUpdated = true;
		if(Delay != lastDelay) isUpdated = true;
		if(Minfrequency != lastMinfrequency) isUpdated = true;
		if(Maxfrequency != lastMaxfrequency) isUpdated = true;
		if(Jet != lastJet) isUpdated = true;
		if(Jetphase != lastJetphase) isUpdated = true;
		if(Saturation != lastSaturation) isUpdated = true;
		if(ShapeShape != lastShapeShape) isUpdated = true;
		if(ShapeCustommorph != lastShapeCustommorph) isUpdated = true;
		if(ShapeSmoothness != lastShapeSmoothness) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MFlanger.dll");
		if(Mode != lastMode) {
			client.sendPacket("parameter 0 "+Mode);
			lastMode = Mode;
		}
		if(Depth != lastDepth) {
			client.sendPacket("parameter 1 "+Depth);
			lastDepth = Depth;
		}
		if(Range != lastRange) {
			client.sendPacket("parameter 2 "+Range);
			lastRange = Range;
		}
		if(Rate != lastRate) {
			client.sendPacket("parameter 3 "+Rate);
			lastRate = Rate;
		}
		if(Feedback != lastFeedback) {
			client.sendPacket("parameter 4 "+Feedback);
			lastFeedback = Feedback;
		}
		if(Phasedifference != lastPhasedifference) {
			client.sendPacket("parameter 5 "+Phasedifference);
			lastPhasedifference = Phasedifference;
		}
		if(Delay != lastDelay) {
			client.sendPacket("parameter 6 "+Delay);
			lastDelay = Delay;
		}
		if(Minfrequency != lastMinfrequency) {
			client.sendPacket("parameter 7 "+Minfrequency);
			lastMinfrequency = Minfrequency;
		}
		if(Maxfrequency != lastMaxfrequency) {
			client.sendPacket("parameter 8 "+Maxfrequency);
			lastMaxfrequency = Maxfrequency;
		}
		if(Jet != lastJet) {
			client.sendPacket("parameter 9 "+Jet);
			lastJet = Jet;
		}
		if(Jetphase != lastJetphase) {
			client.sendPacket("parameter 10 "+Jetphase);
			lastJetphase = Jetphase;
		}
		if(Saturation != lastSaturation) {
			client.sendPacket("parameter 11 "+Saturation);
			lastSaturation = Saturation;
		}
		if(ShapeShape != lastShapeShape) {
			client.sendPacket("parameter 16 "+ShapeShape);
			lastShapeShape = ShapeShape;
		}
		if(ShapeCustommorph != lastShapeCustommorph) {
			client.sendPacket("parameter 17 "+ShapeCustommorph);
			lastShapeCustommorph = ShapeCustommorph;
		}
		if(ShapeSmoothness != lastShapeSmoothness) {
			client.sendPacket("parameter 19 "+ShapeSmoothness);
			lastShapeSmoothness = ShapeSmoothness;
		}
	}

	public override void resetStateTrackers() {
		lastMode = -1f;
		lastDepth = -1f;
		lastRange = -1f;
		lastRate = -1f;
		lastFeedback = -1f;
		lastPhasedifference = -1f;
		lastDelay = -1f;
		lastMinfrequency = -1f;
		lastMaxfrequency = -1f;
		lastJet = -1f;
		lastJetphase = -1f;
		lastSaturation = -1f;
		lastShapeShape = -1f;
		lastShapeCustommorph = -1f;
		lastShapeSmoothness = -1f;
	}
}
