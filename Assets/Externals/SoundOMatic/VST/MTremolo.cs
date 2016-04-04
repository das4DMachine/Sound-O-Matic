using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MTremolo")]
public class MTremolo : VSTFilter {

	public readonly string pluginPath = "MTremolo.dll";

	public override void resetToDefaults() {
		Depth = 0.5f;
		Rate = 0.788257f;
		Phasedifference = 0.5f;
		Inverttremolophase = 0.0f;
		ShapeShape = 0.33333334f;
		ShapeCustommorph = 0.0f;
		ShapeSmoothness = 0.0f;
	}

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Depth = 0.5f;
	private float lastDepth = -1f;
	public readonly int DepthIndex = 0;
	public readonly string DepthLow = "0.00%";
	public readonly string DepthHigh = "100.0%";

	[Tooltip("0.0100 Hz  |  20.0 Hz")]
	[Range(0.0f, 1.0f)]
	public float Rate = 0.788257f;
	private float lastRate = -1f;
	public readonly int RateIndex = 1;
	public readonly string RateLow = "0.0100 Hz";
	public readonly string RateHigh = "20.0 Hz";

	[Tooltip("-360° (-100.0%)  |  360° (100.0%)")]
	[Range(0.0f, 1.0f)]
	public float Phasedifference = 0.5f;
	private float lastPhasedifference = -1f;
	public readonly int PhasedifferenceIndex = 2;
	public readonly string PhasedifferenceLow = "-360° (-100.0%)";
	public readonly string PhasedifferenceHigh = "360° (100.0%)";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Inverttremolophase = 0.0f;
	private float lastInverttremolophase = -1f;
	public readonly int InverttremolophaseIndex = 3;
	public readonly string InverttremolophaseLow = "Off";
	public readonly string InverttremolophaseHigh = "On";

	[Tooltip("Exponential  |  Mess")]
	[Range(0.0f, 1.0f)]
	public float ShapeShape = 0.33333334f;
	private float lastShapeShape = -1f;
	public readonly int ShapeShapeIndex = 8;
	public readonly string ShapeShapeLow = "Exponential";
	public readonly string ShapeShapeHigh = "Mess";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float ShapeCustommorph = 0.0f;
	private float lastShapeCustommorph = -1f;
	public readonly int ShapeCustommorphIndex = 9;
	public readonly string ShapeCustommorphLow = "0.00%";
	public readonly string ShapeCustommorphHigh = "100.0%";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float ShapeSmoothness = 0.0f;
	private float lastShapeSmoothness = -1f;
	public readonly int ShapeSmoothnessIndex = 11;
	public readonly string ShapeSmoothnessLow = "0.00%";
	public readonly string ShapeSmoothnessHigh = "100.0%";

	public override string getFilterName() {
		return "./vst/MTremolo.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Depth != lastDepth) isUpdated = true;
		if(Rate != lastRate) isUpdated = true;
		if(Phasedifference != lastPhasedifference) isUpdated = true;
		if(Inverttremolophase != lastInverttremolophase) isUpdated = true;
		if(ShapeShape != lastShapeShape) isUpdated = true;
		if(ShapeCustommorph != lastShapeCustommorph) isUpdated = true;
		if(ShapeSmoothness != lastShapeSmoothness) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MTremolo.dll");
		if(Depth != lastDepth) {
			client.sendPacket("parameter 0 "+Depth);
			lastDepth = Depth;
		}
		if(Rate != lastRate) {
			client.sendPacket("parameter 1 "+Rate);
			lastRate = Rate;
		}
		if(Phasedifference != lastPhasedifference) {
			client.sendPacket("parameter 2 "+Phasedifference);
			lastPhasedifference = Phasedifference;
		}
		if(Inverttremolophase != lastInverttremolophase) {
			client.sendPacket("parameter 3 "+Inverttremolophase);
			lastInverttremolophase = Inverttremolophase;
		}
		if(ShapeShape != lastShapeShape) {
			client.sendPacket("parameter 8 "+ShapeShape);
			lastShapeShape = ShapeShape;
		}
		if(ShapeCustommorph != lastShapeCustommorph) {
			client.sendPacket("parameter 9 "+ShapeCustommorph);
			lastShapeCustommorph = ShapeCustommorph;
		}
		if(ShapeSmoothness != lastShapeSmoothness) {
			client.sendPacket("parameter 11 "+ShapeSmoothness);
			lastShapeSmoothness = ShapeSmoothness;
		}
	}

	public override void resetStateTrackers() {
		lastDepth = -1f;
		lastRate = -1f;
		lastPhasedifference = -1f;
		lastInverttremolophase = -1f;
		lastShapeShape = -1f;
		lastShapeCustommorph = -1f;
		lastShapeSmoothness = -1f;
	}
}
