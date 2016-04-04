using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MPhaser")]
public class MPhaser : VSTFilter {

	public readonly string pluginPath = "MPhaser.dll";

	public override void resetToDefaults() {
		Drywet = 0.4f;
		Minfrequency = 0.43367666f;
		Maxfrequency = 0.6666667f;
		Rate = 0.6970642f;
		Feedback = 0.7f;
		Mode = 0.030303031f;
		Phasedifference = 0.75f;
		ShapeShape = 0.33333334f;
		ShapeCustommorph = 0.0f;
		ShapeSmoothness = 0.0f;
		Shapemode = 0.0f;
		Saturation = 0.0f;
		Invertfeedbackpolarity = 0.0f;
	}

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Drywet = 0.4f;
	private float lastDrywet = -1f;
	public readonly int DrywetIndex = 0;
	public readonly string DrywetLow = "0.00%";
	public readonly string DrywetHigh = "100.0%";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Minfrequency = 0.43367666f;
	private float lastMinfrequency = -1f;
	public readonly int MinfrequencyIndex = 1;
	public readonly string MinfrequencyLow = "20.0 Hz";
	public readonly string MinfrequencyHigh = "20.0 kHz";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Maxfrequency = 0.6666667f;
	private float lastMaxfrequency = -1f;
	public readonly int MaxfrequencyIndex = 2;
	public readonly string MaxfrequencyLow = "20.0 Hz";
	public readonly string MaxfrequencyHigh = "20.0 kHz";

	[Tooltip("0.0100 Hz  |  20.0 Hz")]
	[Range(0.0f, 1.0f)]
	public float Rate = 0.6970642f;
	private float lastRate = -1f;
	public readonly int RateIndex = 3;
	public readonly string RateLow = "0.0100 Hz";
	public readonly string RateHigh = "20.0 Hz";

	[Tooltip("silence  |  0.00 dB")]
	[Range(0.0f, 1.0f)]
	public float Feedback = 0.7f;
	private float lastFeedback = -1f;
	public readonly int FeedbackIndex = 4;
	public readonly string FeedbackLow = "silence";
	public readonly string FeedbackHigh = "0.00 dB";

	[Tooltip("1  |  100")]
	[Range(0.0f, 1.0f)]
	public float Mode = 0.030303031f;
	private float lastMode = -1f;
	public readonly int ModeIndex = 5;
	public readonly string ModeLow = "1";
	public readonly string ModeHigh = "100";

	[Tooltip("-360° (-100.0%)  |  360° (100.0%)")]
	[Range(0.0f, 1.0f)]
	public float Phasedifference = 0.75f;
	private float lastPhasedifference = -1f;
	public readonly int PhasedifferenceIndex = 6;
	public readonly string PhasedifferenceLow = "-360° (-100.0%)";
	public readonly string PhasedifferenceHigh = "360° (100.0%)";

	[Tooltip("Exponential  |  Mess")]
	[Range(0.0f, 1.0f)]
	public float ShapeShape = 0.33333334f;
	private float lastShapeShape = -1f;
	public readonly int ShapeShapeIndex = 11;
	public readonly string ShapeShapeLow = "Exponential";
	public readonly string ShapeShapeHigh = "Mess";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float ShapeCustommorph = 0.0f;
	private float lastShapeCustommorph = -1f;
	public readonly int ShapeCustommorphIndex = 12;
	public readonly string ShapeCustommorphLow = "0.00%";
	public readonly string ShapeCustommorphHigh = "100.0%";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float ShapeSmoothness = 0.0f;
	private float lastShapeSmoothness = -1f;
	public readonly int ShapeSmoothnessIndex = 14;
	public readonly string ShapeSmoothnessLow = "0.00%";
	public readonly string ShapeSmoothnessHigh = "100.0%";

	[Tooltip("Linear  |  Logarithmic")]
	[Range(0.0f, 1.0f)]
	public float Shapemode = 0.0f;
	private float lastShapemode = -1f;
	public readonly int ShapemodeIndex = 413;
	public readonly string ShapemodeLow = "Linear";
	public readonly string ShapemodeHigh = "Logarithmic";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Saturation = 0.0f;
	private float lastSaturation = -1f;
	public readonly int SaturationIndex = 35;
	public readonly string SaturationLow = "0.00%";
	public readonly string SaturationHigh = "100.0%";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Invertfeedbackpolarity = 0.0f;
	private float lastInvertfeedbackpolarity = -1f;
	public readonly int InvertfeedbackpolarityIndex = 36;
	public readonly string InvertfeedbackpolarityLow = "Off";
	public readonly string InvertfeedbackpolarityHigh = "On";

	public override string getFilterName() {
		return "./vst/MPhaser.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Drywet != lastDrywet) isUpdated = true;
		if(Minfrequency != lastMinfrequency) isUpdated = true;
		if(Maxfrequency != lastMaxfrequency) isUpdated = true;
		if(Rate != lastRate) isUpdated = true;
		if(Feedback != lastFeedback) isUpdated = true;
		if(Mode != lastMode) isUpdated = true;
		if(Phasedifference != lastPhasedifference) isUpdated = true;
		if(ShapeShape != lastShapeShape) isUpdated = true;
		if(ShapeCustommorph != lastShapeCustommorph) isUpdated = true;
		if(ShapeSmoothness != lastShapeSmoothness) isUpdated = true;
		if(Shapemode != lastShapemode) isUpdated = true;
		if(Saturation != lastSaturation) isUpdated = true;
		if(Invertfeedbackpolarity != lastInvertfeedbackpolarity) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MPhaser.dll");
		if(Drywet != lastDrywet) {
			client.sendPacket("parameter 0 "+Drywet);
			lastDrywet = Drywet;
		}
		if(Minfrequency != lastMinfrequency) {
			client.sendPacket("parameter 1 "+Minfrequency);
			lastMinfrequency = Minfrequency;
		}
		if(Maxfrequency != lastMaxfrequency) {
			client.sendPacket("parameter 2 "+Maxfrequency);
			lastMaxfrequency = Maxfrequency;
		}
		if(Rate != lastRate) {
			client.sendPacket("parameter 3 "+Rate);
			lastRate = Rate;
		}
		if(Feedback != lastFeedback) {
			client.sendPacket("parameter 4 "+Feedback);
			lastFeedback = Feedback;
		}
		if(Mode != lastMode) {
			client.sendPacket("parameter 5 "+Mode);
			lastMode = Mode;
		}
		if(Phasedifference != lastPhasedifference) {
			client.sendPacket("parameter 6 "+Phasedifference);
			lastPhasedifference = Phasedifference;
		}
		if(ShapeShape != lastShapeShape) {
			client.sendPacket("parameter 11 "+ShapeShape);
			lastShapeShape = ShapeShape;
		}
		if(ShapeCustommorph != lastShapeCustommorph) {
			client.sendPacket("parameter 12 "+ShapeCustommorph);
			lastShapeCustommorph = ShapeCustommorph;
		}
		if(ShapeSmoothness != lastShapeSmoothness) {
			client.sendPacket("parameter 14 "+ShapeSmoothness);
			lastShapeSmoothness = ShapeSmoothness;
		}
		if(Shapemode != lastShapemode) {
			client.sendPacket("parameter 413 "+Shapemode);
			lastShapemode = Shapemode;
		}
		if(Saturation != lastSaturation) {
			client.sendPacket("parameter 35 "+Saturation);
			lastSaturation = Saturation;
		}
		if(Invertfeedbackpolarity != lastInvertfeedbackpolarity) {
			client.sendPacket("parameter 36 "+Invertfeedbackpolarity);
			lastInvertfeedbackpolarity = Invertfeedbackpolarity;
		}
	}

	public override void resetStateTrackers() {
		lastDrywet = -1f;
		lastMinfrequency = -1f;
		lastMaxfrequency = -1f;
		lastRate = -1f;
		lastFeedback = -1f;
		lastMode = -1f;
		lastPhasedifference = -1f;
		lastShapeShape = -1f;
		lastShapeCustommorph = -1f;
		lastShapeSmoothness = -1f;
		lastShapemode = -1f;
		lastSaturation = -1f;
		lastInvertfeedbackpolarity = -1f;
	}
}
