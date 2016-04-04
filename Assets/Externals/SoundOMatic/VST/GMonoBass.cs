using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/GMonoBass")]
public class GMonoBass : VSTFilter {

	public readonly string pluginPath = "GMonoBass.dll";

	public override void resetToDefaults() {
		XOver = 0.43753064f;
		Width = 0.0f;
	}

	[Tooltip("20.0Hz  |  2000.0Hz")]
	[Range(0.0f, 1.0f)]
	public float XOver = 0.43753064f;
	private float lastXOver = -1f;
	public readonly int XOverIndex = 0;
	public readonly string XOverLow = "20.0Hz";
	public readonly string XOverHigh = "2000.0Hz";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Width = 0.0f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 1;
	public readonly string WidthLow = "0%";
	public readonly string WidthHigh = "100%";

	public override string getFilterName() {
		return "./vst/GMonoBass.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(XOver != lastXOver) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/GMonoBass.dll");
		if(XOver != lastXOver) {
			client.sendPacket("parameter 0 "+XOver);
			lastXOver = XOver;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 1 "+Width);
			lastWidth = Width;
		}
	}

	public override void resetStateTrackers() {
		lastXOver = -1f;
		lastWidth = -1f;
	}
}
