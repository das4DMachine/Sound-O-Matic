using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MFreqShifter")]
public class MFreqShifter : VSTFilter {

	public readonly string pluginPath = "MFreqShifter.dll";

	public override void resetToDefaults() {
		Drywet = 1.0f;
		Shift = 0.5f;
		Width = 0.75f;
		Feedback = 0.0f;
		Delay = 0.1f;
		Character = 0.0f;
		Prefiltering = 1.0f;
		ShapeShape = 0.33333334f;
		ShapeCustommorph = 0.0f;
		ShapeSmoothness = 0.0f;
	}

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Drywet = 1.0f;
	private float lastDrywet = -1f;
	public readonly int DrywetIndex = 0;
	public readonly string DrywetLow = "0.00%";
	public readonly string DrywetHigh = "100.0%";

	[Tooltip("-10.0 kHz  |  10.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Shift = 0.5f;
	private float lastShift = -1f;
	public readonly int ShiftIndex = 1;
	public readonly string ShiftLow = "-10.0 kHz";
	public readonly string ShiftHigh = "10.0 kHz";

	[Tooltip("-200.0%  |  200.0%")]
	[Range(0.0f, 1.0f)]
	public float Width = 0.75f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 2;
	public readonly string WidthLow = "-200.0%";
	public readonly string WidthHigh = "200.0%";

	[Tooltip("0.00%  |  99.0%")]
	[Range(0.0f, 1.0f)]
	public float Feedback = 0.0f;
	private float lastFeedback = -1f;
	public readonly int FeedbackIndex = 3;
	public readonly string FeedbackLow = "0.00%";
	public readonly string FeedbackHigh = "99.0%";

	[Tooltip("0 ms  |  1000 ms")]
	[Range(0.0f, 1.0f)]
	public float Delay = 0.1f;
	private float lastDelay = -1f;
	public readonly int DelayIndex = 4;
	public readonly string DelayLow = "0 ms";
	public readonly string DelayHigh = "1000 ms";

	[Tooltip("Clean  |  Ugly")]
	[Range(0.0f, 1.0f)]
	public float Character = 0.0f;
	private float lastCharacter = -1f;
	public readonly int CharacterIndex = 5;
	public readonly string CharacterLow = "Clean";
	public readonly string CharacterHigh = "Ugly";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Prefiltering = 1.0f;
	private float lastPrefiltering = -1f;
	public readonly int PrefilteringIndex = 6;
	public readonly string PrefilteringLow = "Off";
	public readonly string PrefilteringHigh = "On";

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

	public override string getFilterName() {
		return "./vst/MFreqShifter.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Drywet != lastDrywet) isUpdated = true;
		if(Shift != lastShift) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;
		if(Feedback != lastFeedback) isUpdated = true;
		if(Delay != lastDelay) isUpdated = true;
		if(Character != lastCharacter) isUpdated = true;
		if(Prefiltering != lastPrefiltering) isUpdated = true;
		if(ShapeShape != lastShapeShape) isUpdated = true;
		if(ShapeCustommorph != lastShapeCustommorph) isUpdated = true;
		if(ShapeSmoothness != lastShapeSmoothness) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MFreqShifter.dll");
		if(Drywet != lastDrywet) {
			client.sendPacket("parameter 0 "+Drywet);
			lastDrywet = Drywet;
		}
		if(Shift != lastShift) {
			client.sendPacket("parameter 1 "+Shift);
			lastShift = Shift;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 2 "+Width);
			lastWidth = Width;
		}
		if(Feedback != lastFeedback) {
			client.sendPacket("parameter 3 "+Feedback);
			lastFeedback = Feedback;
		}
		if(Delay != lastDelay) {
			client.sendPacket("parameter 4 "+Delay);
			lastDelay = Delay;
		}
		if(Character != lastCharacter) {
			client.sendPacket("parameter 5 "+Character);
			lastCharacter = Character;
		}
		if(Prefiltering != lastPrefiltering) {
			client.sendPacket("parameter 6 "+Prefiltering);
			lastPrefiltering = Prefiltering;
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
	}

	public override void resetStateTrackers() {
		lastDrywet = -1f;
		lastShift = -1f;
		lastWidth = -1f;
		lastFeedback = -1f;
		lastDelay = -1f;
		lastCharacter = -1f;
		lastPrefiltering = -1f;
		lastShapeShape = -1f;
		lastShapeCustommorph = -1f;
		lastShapeSmoothness = -1f;
	}
}
