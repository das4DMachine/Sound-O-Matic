using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/FreeverbToo")]
public class FreeverbToo : VSTFilter {

	public readonly string pluginPath = "FreeverbToo.dll";

	public override void resetToDefaults() {
		RoomSize = 0.5418f;
		Damping = 0.23f;
		Predelay = 0.18f;
		HighPass = 0.25f;
		LowPass = 0.0f;
		Width = 1.0f;
		Panorama = 0.5f;
		Quality = 1.0f;
		Gate = 0.0f;
		GateThr = 1.0f;
		GateAtk = 0.02f;
		GateHold = 0.4f;
		GateRel = 0.4f;
		VolumeWet = 0.5f;
		VolumeDry = 0.0f;
		Freeze = 0.0f;
	}

	[Tooltip("3  |  203")]
	[Range(0.0f, 1.0f)]
	public float RoomSize = 0.5418f;
	private float lastRoomSize = -1f;
	public readonly int RoomSizeIndex = 0;
	public readonly string RoomSizeLow = "3";
	public readonly string RoomSizeHigh = "203";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Damping = 0.23f;
	private float lastDamping = -1f;
	public readonly int DampingIndex = 1;
	public readonly string DampingLow = "0%";
	public readonly string DampingHigh = "100%";

	[Tooltip("0ms  |  100ms")]
	[Range(0.0f, 1.0f)]
	public float Predelay = 0.18f;
	private float lastPredelay = -1f;
	public readonly int PredelayIndex = 2;
	public readonly string PredelayLow = "0ms";
	public readonly string PredelayHigh = "100ms";

	[Tooltip("0  |  100")]
	[Range(0.0f, 1.0f)]
	public float HighPass = 0.25f;
	private float lastHighPass = -1f;
	public readonly int HighPassIndex = 3;
	public readonly string HighPassLow = "0";
	public readonly string HighPassHigh = "100";

	[Tooltip("0  |  99")]
	[Range(0.0f, 1.0f)]
	public float LowPass = 0.0f;
	private float lastLowPass = -1f;
	public readonly int LowPassIndex = 4;
	public readonly string LowPassLow = "0";
	public readonly string LowPassHigh = "99";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Width = 1.0f;
	private float lastWidth = -1f;
	public readonly int WidthIndex = 5;
	public readonly string WidthLow = "0%";
	public readonly string WidthHigh = "100%";

	[Tooltip("Left  |  Right")]
	[Range(0.0f, 1.0f)]
	public float Panorama = 0.5f;
	private float lastPanorama = -1f;
	public readonly int PanoramaIndex = 6;
	public readonly string PanoramaLow = "Left";
	public readonly string PanoramaHigh = "Right";

	[Tooltip("40%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float Quality = 1.0f;
	private float lastQuality = -1f;
	public readonly int QualityIndex = 7;
	public readonly string QualityLow = "40%";
	public readonly string QualityHigh = "100%";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Gate = 0.0f;
	private float lastGate = -1f;
	public readonly int GateIndex = 8;
	public readonly string GateLow = "Off";
	public readonly string GateHigh = "On";

	[Tooltip("-0dB  |  -70dB")]
	[Range(0.0f, 1.0f)]
	public float GateThr = 1.0f;
	private float lastGateThr = -1f;
	public readonly int GateThrIndex = 9;
	public readonly string GateThrLow = "-0dB";
	public readonly string GateThrHigh = "-70dB";

	[Tooltip("1ms  |  50ms")]
	[Range(0.0f, 1.0f)]
	public float GateAtk = 0.02f;
	private float lastGateAtk = -1f;
	public readonly int GateAtkIndex = 10;
	public readonly string GateAtkLow = "1ms";
	public readonly string GateAtkHigh = "50ms";

	[Tooltip("1ms  |  500ms")]
	[Range(0.0f, 1.0f)]
	public float GateHold = 0.4f;
	private float lastGateHold = -1f;
	public readonly int GateHoldIndex = 11;
	public readonly string GateHoldLow = "1ms";
	public readonly string GateHoldHigh = "500ms";

	[Tooltip("1ms  |  500ms")]
	[Range(0.0f, 1.0f)]
	public float GateRel = 0.4f;
	private float lastGateRel = -1f;
	public readonly int GateRelIndex = 12;
	public readonly string GateRelLow = "1ms";
	public readonly string GateRelHigh = "500ms";

	[Tooltip("mutedB  |  24dB")]
	[Range(0.0f, 1.0f)]
	public float VolumeWet = 0.5f;
	private float lastVolumeWet = -1f;
	public readonly int VolumeWetIndex = 13;
	public readonly string VolumeWetLow = "mutedB";
	public readonly string VolumeWetHigh = "24dB";

	[Tooltip("mutedB  |  24dB")]
	[Range(0.0f, 1.0f)]
	public float VolumeDry = 0.0f;
	private float lastVolumeDry = -1f;
	public readonly int VolumeDryIndex = 14;
	public readonly string VolumeDryLow = "mutedB";
	public readonly string VolumeDryHigh = "24dB";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Freeze = 0.0f;
	private float lastFreeze = -1f;
	public readonly int FreezeIndex = 15;
	public readonly string FreezeLow = "Off";
	public readonly string FreezeHigh = "On";

	public override string getFilterName() {
		return "./vst/FreeverbToo.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(RoomSize != lastRoomSize) isUpdated = true;
		if(Damping != lastDamping) isUpdated = true;
		if(Predelay != lastPredelay) isUpdated = true;
		if(HighPass != lastHighPass) isUpdated = true;
		if(LowPass != lastLowPass) isUpdated = true;
		if(Width != lastWidth) isUpdated = true;
		if(Panorama != lastPanorama) isUpdated = true;
		if(Quality != lastQuality) isUpdated = true;
		if(Gate != lastGate) isUpdated = true;
		if(GateThr != lastGateThr) isUpdated = true;
		if(GateAtk != lastGateAtk) isUpdated = true;
		if(GateHold != lastGateHold) isUpdated = true;
		if(GateRel != lastGateRel) isUpdated = true;
		if(VolumeWet != lastVolumeWet) isUpdated = true;
		if(VolumeDry != lastVolumeDry) isUpdated = true;
		if(Freeze != lastFreeze) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/FreeverbToo.dll");
		if(RoomSize != lastRoomSize) {
			client.sendPacket("parameter 0 "+RoomSize);
			lastRoomSize = RoomSize;
		}
		if(Damping != lastDamping) {
			client.sendPacket("parameter 1 "+Damping);
			lastDamping = Damping;
		}
		if(Predelay != lastPredelay) {
			client.sendPacket("parameter 2 "+Predelay);
			lastPredelay = Predelay;
		}
		if(HighPass != lastHighPass) {
			client.sendPacket("parameter 3 "+HighPass);
			lastHighPass = HighPass;
		}
		if(LowPass != lastLowPass) {
			client.sendPacket("parameter 4 "+LowPass);
			lastLowPass = LowPass;
		}
		if(Width != lastWidth) {
			client.sendPacket("parameter 5 "+Width);
			lastWidth = Width;
		}
		if(Panorama != lastPanorama) {
			client.sendPacket("parameter 6 "+Panorama);
			lastPanorama = Panorama;
		}
		if(Quality != lastQuality) {
			client.sendPacket("parameter 7 "+Quality);
			lastQuality = Quality;
		}
		if(Gate != lastGate) {
			client.sendPacket("parameter 8 "+Gate);
			lastGate = Gate;
		}
		if(GateThr != lastGateThr) {
			client.sendPacket("parameter 9 "+GateThr);
			lastGateThr = GateThr;
		}
		if(GateAtk != lastGateAtk) {
			client.sendPacket("parameter 10 "+GateAtk);
			lastGateAtk = GateAtk;
		}
		if(GateHold != lastGateHold) {
			client.sendPacket("parameter 11 "+GateHold);
			lastGateHold = GateHold;
		}
		if(GateRel != lastGateRel) {
			client.sendPacket("parameter 12 "+GateRel);
			lastGateRel = GateRel;
		}
		if(VolumeWet != lastVolumeWet) {
			client.sendPacket("parameter 13 "+VolumeWet);
			lastVolumeWet = VolumeWet;
		}
		if(VolumeDry != lastVolumeDry) {
			client.sendPacket("parameter 14 "+VolumeDry);
			lastVolumeDry = VolumeDry;
		}
		if(Freeze != lastFreeze) {
			client.sendPacket("parameter 15 "+Freeze);
			lastFreeze = Freeze;
		}
	}

	public override void resetStateTrackers() {
		lastRoomSize = -1f;
		lastDamping = -1f;
		lastPredelay = -1f;
		lastHighPass = -1f;
		lastLowPass = -1f;
		lastWidth = -1f;
		lastPanorama = -1f;
		lastQuality = -1f;
		lastGate = -1f;
		lastGateThr = -1f;
		lastGateAtk = -1f;
		lastGateHold = -1f;
		lastGateRel = -1f;
		lastVolumeWet = -1f;
		lastVolumeDry = -1f;
		lastFreeze = -1f;
	}
}
