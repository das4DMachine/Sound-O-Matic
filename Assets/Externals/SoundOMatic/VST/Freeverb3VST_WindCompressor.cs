using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Freeverb3VST_WindCompressor")]
public class Freeverb3VST_WindCompressor : VSTFilter {

	public readonly string pluginPath = "Freeverb3VST_WindCompressor.dll";

	public override void resetToDefaults() {
		LoFreqDv = 0.005757197f;
		HiFreqDv = 0.31414267f;
		OACRMS = 0.29999998f;
		OACLooka = 0.099999994f;
		LAttack = 0.0f;
		LReleas = 0.01f;
		LThresh = 0.4125f;
		LSoftKn = 0.5f;
		LRatio = 0.24623115f;
		LGain = 0.7f;
		MAttack = 0.0f;
		MReleas = 0.015999999f;
		MThresh = 0.5375f;
		MSoftKn = 0.5f;
		MRatio = 0.14572865f;
		MGain = 0.7f;
		HAttack = 0.0f;
		HReleas = 0.015999999f;
		HThresh = 0.5f;
		HSoftKn = 0.5f;
		HRatio = 0.34673366f;
		HGain = 0.7f;
		LimitRMS = 0.0f;
		LiLookah = 0.1f;
		LiAttack = 0.0f;
		LiReleas = 0.02f;
		LThresho = 0.725f;
		LCeiling = 0.75f;
		AutoGain = 1.0f;
	}

	[Tooltip("25.00000Hz  |  20000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float LoFreqDv = 0.005757197f;
	private float lastLoFreqDv = -1f;
	public readonly int LoFreqDvIndex = 0;
	public readonly string LoFreqDvLow = "25.00000Hz";
	public readonly string LoFreqDvHigh = "20000.00Hz";

	[Tooltip("25.00000Hz  |  20000.00Hz")]
	[Range(0.0f, 1.0f)]
	public float HiFreqDv = 0.31414267f;
	private float lastHiFreqDv = -1f;
	public readonly int HiFreqDvIndex = 1;
	public readonly string HiFreqDvLow = "25.00000Hz";
	public readonly string HiFreqDvHigh = "20000.00Hz";

	[Tooltip("0.000000ms  |  100.0000ms")]
	[Range(0.0f, 1.0f)]
	public float OACRMS = 0.29999998f;
	private float lastOACRMS = -1f;
	public readonly int OACRMSIndex = 2;
	public readonly string OACRMSLow = "0.000000ms";
	public readonly string OACRMSHigh = "100.0000ms";

	[Tooltip("0.000000ms  |  100.0000ms")]
	[Range(0.0f, 1.0f)]
	public float OACLooka = 0.099999994f;
	private float lastOACLooka = -1f;
	public readonly int OACLookaIndex = 3;
	public readonly string OACLookaLow = "0.000000ms";
	public readonly string OACLookaHigh = "100.0000ms";

	[Tooltip("0.000000ms  |  5000.000ms")]
	[Range(0.0f, 1.0f)]
	public float LAttack = 0.0f;
	private float lastLAttack = -1f;
	public readonly int LAttackIndex = 4;
	public readonly string LAttackLow = "0.000000ms";
	public readonly string LAttackHigh = "5000.000ms";

	[Tooltip("0.000000ms  |  5000.000ms")]
	[Range(0.0f, 1.0f)]
	public float LReleas = 0.01f;
	private float lastLReleas = -1f;
	public readonly int LReleasIndex = 5;
	public readonly string LReleasLow = "0.000000ms";
	public readonly string LReleasHigh = "5000.000ms";

	[Tooltip("-60.0000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float LThresh = 0.4125f;
	private float lastLThresh = -1f;
	public readonly int LThreshIndex = 6;
	public readonly string LThreshLow = "-60.0000dB";
	public readonly string LThreshHigh = "20.00000dB";

	[Tooltip("0.000000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float LSoftKn = 0.5f;
	private float lastLSoftKn = -1f;
	public readonly int LSoftKnIndex = 7;
	public readonly string LSoftKnLow = "0.000000dB";
	public readonly string LSoftKnHigh = "20.00000dB";

	[Tooltip("0.100000x  |  20.00000x")]
	[Range(0.0f, 1.0f)]
	public float LRatio = 0.24623115f;
	private float lastLRatio = -1f;
	public readonly int LRatioIndex = 8;
	public readonly string LRatioLow = "0.100000x";
	public readonly string LRatioHigh = "20.00000x";

	[Tooltip("-60.0000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float LGain = 0.7f;
	private float lastLGain = -1f;
	public readonly int LGainIndex = 9;
	public readonly string LGainLow = "-60.0000dB";
	public readonly string LGainHigh = "20.00000dB";

	[Tooltip("0.000000ms  |  5000.000ms")]
	[Range(0.0f, 1.0f)]
	public float MAttack = 0.0f;
	private float lastMAttack = -1f;
	public readonly int MAttackIndex = 10;
	public readonly string MAttackLow = "0.000000ms";
	public readonly string MAttackHigh = "5000.000ms";

	[Tooltip("0.000000ms  |  5000.000ms")]
	[Range(0.0f, 1.0f)]
	public float MReleas = 0.015999999f;
	private float lastMReleas = -1f;
	public readonly int MReleasIndex = 11;
	public readonly string MReleasLow = "0.000000ms";
	public readonly string MReleasHigh = "5000.000ms";

	[Tooltip("-60.0000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float MThresh = 0.5375f;
	private float lastMThresh = -1f;
	public readonly int MThreshIndex = 12;
	public readonly string MThreshLow = "-60.0000dB";
	public readonly string MThreshHigh = "20.00000dB";

	[Tooltip("0.000000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float MSoftKn = 0.5f;
	private float lastMSoftKn = -1f;
	public readonly int MSoftKnIndex = 13;
	public readonly string MSoftKnLow = "0.000000dB";
	public readonly string MSoftKnHigh = "20.00000dB";

	[Tooltip("0.100000x  |  20.00000x")]
	[Range(0.0f, 1.0f)]
	public float MRatio = 0.14572865f;
	private float lastMRatio = -1f;
	public readonly int MRatioIndex = 14;
	public readonly string MRatioLow = "0.100000x";
	public readonly string MRatioHigh = "20.00000x";

	[Tooltip("-60.0000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float MGain = 0.7f;
	private float lastMGain = -1f;
	public readonly int MGainIndex = 15;
	public readonly string MGainLow = "-60.0000dB";
	public readonly string MGainHigh = "20.00000dB";

	[Tooltip("0.000000ms  |  5000.000ms")]
	[Range(0.0f, 1.0f)]
	public float HAttack = 0.0f;
	private float lastHAttack = -1f;
	public readonly int HAttackIndex = 16;
	public readonly string HAttackLow = "0.000000ms";
	public readonly string HAttackHigh = "5000.000ms";

	[Tooltip("0.000000ms  |  5000.000ms")]
	[Range(0.0f, 1.0f)]
	public float HReleas = 0.015999999f;
	private float lastHReleas = -1f;
	public readonly int HReleasIndex = 17;
	public readonly string HReleasLow = "0.000000ms";
	public readonly string HReleasHigh = "5000.000ms";

	[Tooltip("-60.0000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float HThresh = 0.5f;
	private float lastHThresh = -1f;
	public readonly int HThreshIndex = 18;
	public readonly string HThreshLow = "-60.0000dB";
	public readonly string HThreshHigh = "20.00000dB";

	[Tooltip("0.000000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float HSoftKn = 0.5f;
	private float lastHSoftKn = -1f;
	public readonly int HSoftKnIndex = 19;
	public readonly string HSoftKnLow = "0.000000dB";
	public readonly string HSoftKnHigh = "20.00000dB";

	[Tooltip("0.100000x  |  20.00000x")]
	[Range(0.0f, 1.0f)]
	public float HRatio = 0.34673366f;
	private float lastHRatio = -1f;
	public readonly int HRatioIndex = 20;
	public readonly string HRatioLow = "0.100000x";
	public readonly string HRatioHigh = "20.00000x";

	[Tooltip("-60.0000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float HGain = 0.7f;
	private float lastHGain = -1f;
	public readonly int HGainIndex = 21;
	public readonly string HGainLow = "-60.0000dB";
	public readonly string HGainHigh = "20.00000dB";

	[Tooltip("0.000000ms  |  100.0000ms")]
	[Range(0.0f, 1.0f)]
	public float LimitRMS = 0.0f;
	private float lastLimitRMS = -1f;
	public readonly int LimitRMSIndex = 22;
	public readonly string LimitRMSLow = "0.000000ms";
	public readonly string LimitRMSHigh = "100.0000ms";

	[Tooltip("0.000000ms  |  10.00000ms")]
	[Range(0.0f, 1.0f)]
	public float LiLookah = 0.1f;
	private float lastLiLookah = -1f;
	public readonly int LiLookahIndex = 23;
	public readonly string LiLookahLow = "0.000000ms";
	public readonly string LiLookahHigh = "10.00000ms";

	[Tooltip("0.000000ms  |  5000.000ms")]
	[Range(0.0f, 1.0f)]
	public float LiAttack = 0.0f;
	private float lastLiAttack = -1f;
	public readonly int LiAttackIndex = 24;
	public readonly string LiAttackLow = "0.000000ms";
	public readonly string LiAttackHigh = "5000.000ms";

	[Tooltip("0.000000ms  |  5000.000ms")]
	[Range(0.0f, 1.0f)]
	public float LiReleas = 0.02f;
	private float lastLiReleas = -1f;
	public readonly int LiReleasIndex = 25;
	public readonly string LiReleasLow = "0.000000ms";
	public readonly string LiReleasHigh = "5000.000ms";

	[Tooltip("-60.0000dB  |  0.000000dB")]
	[Range(0.0f, 1.0f)]
	public float LThresho = 0.725f;
	private float lastLThresho = -1f;
	public readonly int LThreshoIndex = 26;
	public readonly string LThreshoLow = "-60.0000dB";
	public readonly string LThreshoHigh = "0.000000dB";

	[Tooltip("20.00000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float LCeiling = 0.75f;
	private float lastLCeiling = -1f;
	public readonly int LCeilingIndex = 27;
	public readonly string LCeilingLow = "20.00000dB";
	public readonly string LCeilingHigh = "20.00000dB";

	[Tooltip("OFF-  |  ON-")]
	[Range(0.0f, 1.0f)]
	public float AutoGain = 1.0f;
	private float lastAutoGain = -1f;
	public readonly int AutoGainIndex = 28;
	public readonly string AutoGainLow = "OFF-";
	public readonly string AutoGainHigh = "ON-";

	public override string getFilterName() {
		return "./vst/Freeverb3VST_WindCompressor.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(LoFreqDv != lastLoFreqDv) isUpdated = true;
		if(HiFreqDv != lastHiFreqDv) isUpdated = true;
		if(OACRMS != lastOACRMS) isUpdated = true;
		if(OACLooka != lastOACLooka) isUpdated = true;
		if(LAttack != lastLAttack) isUpdated = true;
		if(LReleas != lastLReleas) isUpdated = true;
		if(LThresh != lastLThresh) isUpdated = true;
		if(LSoftKn != lastLSoftKn) isUpdated = true;
		if(LRatio != lastLRatio) isUpdated = true;
		if(LGain != lastLGain) isUpdated = true;
		if(MAttack != lastMAttack) isUpdated = true;
		if(MReleas != lastMReleas) isUpdated = true;
		if(MThresh != lastMThresh) isUpdated = true;
		if(MSoftKn != lastMSoftKn) isUpdated = true;
		if(MRatio != lastMRatio) isUpdated = true;
		if(MGain != lastMGain) isUpdated = true;
		if(HAttack != lastHAttack) isUpdated = true;
		if(HReleas != lastHReleas) isUpdated = true;
		if(HThresh != lastHThresh) isUpdated = true;
		if(HSoftKn != lastHSoftKn) isUpdated = true;
		if(HRatio != lastHRatio) isUpdated = true;
		if(HGain != lastHGain) isUpdated = true;
		if(LimitRMS != lastLimitRMS) isUpdated = true;
		if(LiLookah != lastLiLookah) isUpdated = true;
		if(LiAttack != lastLiAttack) isUpdated = true;
		if(LiReleas != lastLiReleas) isUpdated = true;
		if(LThresho != lastLThresho) isUpdated = true;
		if(LCeiling != lastLCeiling) isUpdated = true;
		if(AutoGain != lastAutoGain) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Freeverb3VST_WindCompressor.dll");
		if(LoFreqDv != lastLoFreqDv) {
			client.sendPacket("parameter 0 "+LoFreqDv);
			lastLoFreqDv = LoFreqDv;
		}
		if(HiFreqDv != lastHiFreqDv) {
			client.sendPacket("parameter 1 "+HiFreqDv);
			lastHiFreqDv = HiFreqDv;
		}
		if(OACRMS != lastOACRMS) {
			client.sendPacket("parameter 2 "+OACRMS);
			lastOACRMS = OACRMS;
		}
		if(OACLooka != lastOACLooka) {
			client.sendPacket("parameter 3 "+OACLooka);
			lastOACLooka = OACLooka;
		}
		if(LAttack != lastLAttack) {
			client.sendPacket("parameter 4 "+LAttack);
			lastLAttack = LAttack;
		}
		if(LReleas != lastLReleas) {
			client.sendPacket("parameter 5 "+LReleas);
			lastLReleas = LReleas;
		}
		if(LThresh != lastLThresh) {
			client.sendPacket("parameter 6 "+LThresh);
			lastLThresh = LThresh;
		}
		if(LSoftKn != lastLSoftKn) {
			client.sendPacket("parameter 7 "+LSoftKn);
			lastLSoftKn = LSoftKn;
		}
		if(LRatio != lastLRatio) {
			client.sendPacket("parameter 8 "+LRatio);
			lastLRatio = LRatio;
		}
		if(LGain != lastLGain) {
			client.sendPacket("parameter 9 "+LGain);
			lastLGain = LGain;
		}
		if(MAttack != lastMAttack) {
			client.sendPacket("parameter 10 "+MAttack);
			lastMAttack = MAttack;
		}
		if(MReleas != lastMReleas) {
			client.sendPacket("parameter 11 "+MReleas);
			lastMReleas = MReleas;
		}
		if(MThresh != lastMThresh) {
			client.sendPacket("parameter 12 "+MThresh);
			lastMThresh = MThresh;
		}
		if(MSoftKn != lastMSoftKn) {
			client.sendPacket("parameter 13 "+MSoftKn);
			lastMSoftKn = MSoftKn;
		}
		if(MRatio != lastMRatio) {
			client.sendPacket("parameter 14 "+MRatio);
			lastMRatio = MRatio;
		}
		if(MGain != lastMGain) {
			client.sendPacket("parameter 15 "+MGain);
			lastMGain = MGain;
		}
		if(HAttack != lastHAttack) {
			client.sendPacket("parameter 16 "+HAttack);
			lastHAttack = HAttack;
		}
		if(HReleas != lastHReleas) {
			client.sendPacket("parameter 17 "+HReleas);
			lastHReleas = HReleas;
		}
		if(HThresh != lastHThresh) {
			client.sendPacket("parameter 18 "+HThresh);
			lastHThresh = HThresh;
		}
		if(HSoftKn != lastHSoftKn) {
			client.sendPacket("parameter 19 "+HSoftKn);
			lastHSoftKn = HSoftKn;
		}
		if(HRatio != lastHRatio) {
			client.sendPacket("parameter 20 "+HRatio);
			lastHRatio = HRatio;
		}
		if(HGain != lastHGain) {
			client.sendPacket("parameter 21 "+HGain);
			lastHGain = HGain;
		}
		if(LimitRMS != lastLimitRMS) {
			client.sendPacket("parameter 22 "+LimitRMS);
			lastLimitRMS = LimitRMS;
		}
		if(LiLookah != lastLiLookah) {
			client.sendPacket("parameter 23 "+LiLookah);
			lastLiLookah = LiLookah;
		}
		if(LiAttack != lastLiAttack) {
			client.sendPacket("parameter 24 "+LiAttack);
			lastLiAttack = LiAttack;
		}
		if(LiReleas != lastLiReleas) {
			client.sendPacket("parameter 25 "+LiReleas);
			lastLiReleas = LiReleas;
		}
		if(LThresho != lastLThresho) {
			client.sendPacket("parameter 26 "+LThresho);
			lastLThresho = LThresho;
		}
		if(LCeiling != lastLCeiling) {
			client.sendPacket("parameter 27 "+LCeiling);
			lastLCeiling = LCeiling;
		}
		if(AutoGain != lastAutoGain) {
			client.sendPacket("parameter 28 "+AutoGain);
			lastAutoGain = AutoGain;
		}
	}

	public override void resetStateTrackers() {
		lastLoFreqDv = -1f;
		lastHiFreqDv = -1f;
		lastOACRMS = -1f;
		lastOACLooka = -1f;
		lastLAttack = -1f;
		lastLReleas = -1f;
		lastLThresh = -1f;
		lastLSoftKn = -1f;
		lastLRatio = -1f;
		lastLGain = -1f;
		lastMAttack = -1f;
		lastMReleas = -1f;
		lastMThresh = -1f;
		lastMSoftKn = -1f;
		lastMRatio = -1f;
		lastMGain = -1f;
		lastHAttack = -1f;
		lastHReleas = -1f;
		lastHThresh = -1f;
		lastHSoftKn = -1f;
		lastHRatio = -1f;
		lastHGain = -1f;
		lastLimitRMS = -1f;
		lastLiLookah = -1f;
		lastLiAttack = -1f;
		lastLiReleas = -1f;
		lastLThresho = -1f;
		lastLCeiling = -1f;
		lastAutoGain = -1f;
	}
}
