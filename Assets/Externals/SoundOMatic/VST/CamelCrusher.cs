using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/CamelCrusher")]
public class CamelCrusher : VSTFilter {

	public readonly string pluginPath = "CamelCrusher.dll";

	public override void resetToDefaults() {
		DistOn = 0.0f;
		DistMech = 0.0f;
		DistTube = 0.0f;
		MmFilterOn = 0.0f;
		MmFilterCutoff = 0.0f;
		MmFilterRes = 0.0f;
		CompressOn = 0.0f;
		CompressAmount = 0.0f;
		CompressMode = 0.0f;
		MasterOn = 0.0f;
		MasterMix = 0.0f;
		MasterVolume = 0.0f;
		Unused1 = 0.0f;
		Unused2 = 0.0f;
		Unused3 = 0.0f;
		Unused4 = 0.0f;
		Unused5 = 0.0f;
	}

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float DistOn = 0.0f;
	private float lastDistOn = -1f;
	public readonly int DistOnIndex = 0;
	public readonly string DistOnLow = "0";
	public readonly string DistOnHigh = "1";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float DistMech = 0.0f;
	private float lastDistMech = -1f;
	public readonly int DistMechIndex = 1;
	public readonly string DistMechLow = "0%";
	public readonly string DistMechHigh = "100%";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float DistTube = 0.0f;
	private float lastDistTube = -1f;
	public readonly int DistTubeIndex = 2;
	public readonly string DistTubeLow = "0%";
	public readonly string DistTubeHigh = "100%";

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float MmFilterOn = 0.0f;
	private float lastMmFilterOn = -1f;
	public readonly int MmFilterOnIndex = 3;
	public readonly string MmFilterOnLow = "0";
	public readonly string MmFilterOnHigh = "1";

	[Tooltip("80Hz  |  16000Hz")]
	[Range(0.0f, 1.0f)]
	public float MmFilterCutoff = 0.0f;
	private float lastMmFilterCutoff = -1f;
	public readonly int MmFilterCutoffIndex = 4;
	public readonly string MmFilterCutoffLow = "80Hz";
	public readonly string MmFilterCutoffHigh = "16000Hz";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float MmFilterRes = 0.0f;
	private float lastMmFilterRes = -1f;
	public readonly int MmFilterResIndex = 5;
	public readonly string MmFilterResLow = "0%";
	public readonly string MmFilterResHigh = "100%";

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float CompressOn = 0.0f;
	private float lastCompressOn = -1f;
	public readonly int CompressOnIndex = 6;
	public readonly string CompressOnLow = "0";
	public readonly string CompressOnHigh = "1";

	[Tooltip("0dB  |  -40dB")]
	[Range(0.0f, 1.0f)]
	public float CompressAmount = 0.0f;
	private float lastCompressAmount = -1f;
	public readonly int CompressAmountIndex = 7;
	public readonly string CompressAmountLow = "0dB";
	public readonly string CompressAmountHigh = "-40dB";

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float CompressMode = 0.0f;
	private float lastCompressMode = -1f;
	public readonly int CompressModeIndex = 8;
	public readonly string CompressModeLow = "0";
	public readonly string CompressModeHigh = "1";

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float MasterOn = 0.0f;
	private float lastMasterOn = -1f;
	public readonly int MasterOnIndex = 9;
	public readonly string MasterOnLow = "0";
	public readonly string MasterOnHigh = "1";

	[Tooltip("0%  |  100%")]
	[Range(0.0f, 1.0f)]
	public float MasterMix = 0.0f;
	private float lastMasterMix = -1f;
	public readonly int MasterMixIndex = 10;
	public readonly string MasterMixLow = "0%";
	public readonly string MasterMixHigh = "100%";

	[Tooltip("-infdB  |  0dB")]
	[Range(0.0f, 1.0f)]
	public float MasterVolume = 0.0f;
	private float lastMasterVolume = -1f;
	public readonly int MasterVolumeIndex = 11;
	public readonly string MasterVolumeLow = "-infdB";
	public readonly string MasterVolumeHigh = "0dB";

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float Unused1 = 0.0f;
	private float lastUnused1 = -1f;
	public readonly int Unused1Index = 12;
	public readonly string Unused1Low = "0";
	public readonly string Unused1High = "1";

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float Unused2 = 0.0f;
	private float lastUnused2 = -1f;
	public readonly int Unused2Index = 13;
	public readonly string Unused2Low = "0";
	public readonly string Unused2High = "1";

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float Unused3 = 0.0f;
	private float lastUnused3 = -1f;
	public readonly int Unused3Index = 14;
	public readonly string Unused3Low = "0";
	public readonly string Unused3High = "1";

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float Unused4 = 0.0f;
	private float lastUnused4 = -1f;
	public readonly int Unused4Index = 15;
	public readonly string Unused4Low = "0";
	public readonly string Unused4High = "1";

	[Tooltip("0  |  1")]
	[Range(0.0f, 1.0f)]
	public float Unused5 = 0.0f;
	private float lastUnused5 = -1f;
	public readonly int Unused5Index = 16;
	public readonly string Unused5Low = "0";
	public readonly string Unused5High = "1";

	public override string getFilterName() {
		return "./vst/CamelCrusher.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(DistOn != lastDistOn) isUpdated = true;
		if(DistMech != lastDistMech) isUpdated = true;
		if(DistTube != lastDistTube) isUpdated = true;
		if(MmFilterOn != lastMmFilterOn) isUpdated = true;
		if(MmFilterCutoff != lastMmFilterCutoff) isUpdated = true;
		if(MmFilterRes != lastMmFilterRes) isUpdated = true;
		if(CompressOn != lastCompressOn) isUpdated = true;
		if(CompressAmount != lastCompressAmount) isUpdated = true;
		if(CompressMode != lastCompressMode) isUpdated = true;
		if(MasterOn != lastMasterOn) isUpdated = true;
		if(MasterMix != lastMasterMix) isUpdated = true;
		if(MasterVolume != lastMasterVolume) isUpdated = true;
		if(Unused1 != lastUnused1) isUpdated = true;
		if(Unused2 != lastUnused2) isUpdated = true;
		if(Unused3 != lastUnused3) isUpdated = true;
		if(Unused4 != lastUnused4) isUpdated = true;
		if(Unused5 != lastUnused5) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/CamelCrusher.dll");
		if(DistOn != lastDistOn) {
			client.sendPacket("parameter 0 "+DistOn);
			lastDistOn = DistOn;
		}
		if(DistMech != lastDistMech) {
			client.sendPacket("parameter 1 "+DistMech);
			lastDistMech = DistMech;
		}
		if(DistTube != lastDistTube) {
			client.sendPacket("parameter 2 "+DistTube);
			lastDistTube = DistTube;
		}
		if(MmFilterOn != lastMmFilterOn) {
			client.sendPacket("parameter 3 "+MmFilterOn);
			lastMmFilterOn = MmFilterOn;
		}
		if(MmFilterCutoff != lastMmFilterCutoff) {
			client.sendPacket("parameter 4 "+MmFilterCutoff);
			lastMmFilterCutoff = MmFilterCutoff;
		}
		if(MmFilterRes != lastMmFilterRes) {
			client.sendPacket("parameter 5 "+MmFilterRes);
			lastMmFilterRes = MmFilterRes;
		}
		if(CompressOn != lastCompressOn) {
			client.sendPacket("parameter 6 "+CompressOn);
			lastCompressOn = CompressOn;
		}
		if(CompressAmount != lastCompressAmount) {
			client.sendPacket("parameter 7 "+CompressAmount);
			lastCompressAmount = CompressAmount;
		}
		if(CompressMode != lastCompressMode) {
			client.sendPacket("parameter 8 "+CompressMode);
			lastCompressMode = CompressMode;
		}
		if(MasterOn != lastMasterOn) {
			client.sendPacket("parameter 9 "+MasterOn);
			lastMasterOn = MasterOn;
		}
		if(MasterMix != lastMasterMix) {
			client.sendPacket("parameter 10 "+MasterMix);
			lastMasterMix = MasterMix;
		}
		if(MasterVolume != lastMasterVolume) {
			client.sendPacket("parameter 11 "+MasterVolume);
			lastMasterVolume = MasterVolume;
		}
		if(Unused1 != lastUnused1) {
			client.sendPacket("parameter 12 "+Unused1);
			lastUnused1 = Unused1;
		}
		if(Unused2 != lastUnused2) {
			client.sendPacket("parameter 13 "+Unused2);
			lastUnused2 = Unused2;
		}
		if(Unused3 != lastUnused3) {
			client.sendPacket("parameter 14 "+Unused3);
			lastUnused3 = Unused3;
		}
		if(Unused4 != lastUnused4) {
			client.sendPacket("parameter 15 "+Unused4);
			lastUnused4 = Unused4;
		}
		if(Unused5 != lastUnused5) {
			client.sendPacket("parameter 16 "+Unused5);
			lastUnused5 = Unused5;
		}
	}

	public override void resetStateTrackers() {
		lastDistOn = -1f;
		lastDistMech = -1f;
		lastDistTube = -1f;
		lastMmFilterOn = -1f;
		lastMmFilterCutoff = -1f;
		lastMmFilterRes = -1f;
		lastCompressOn = -1f;
		lastCompressAmount = -1f;
		lastCompressMode = -1f;
		lastMasterOn = -1f;
		lastMasterMix = -1f;
		lastMasterVolume = -1f;
		lastUnused1 = -1f;
		lastUnused2 = -1f;
		lastUnused3 = -1f;
		lastUnused4 = -1f;
		lastUnused5 = -1f;
	}
}
