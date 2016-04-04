using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MarvelGEQ")]
public class MarvelGEQ : VSTFilter {

	public readonly string pluginPath = "Marvel GEQ.dll";

	public override void resetToDefaults() {
		Bypass = 0.0f;
		_1EQ0 = 0.5f;
		_1EQ1 = 0.5f;
		_1EQ2 = 0.5f;
		_1EQ3 = 0.5f;
		_1EQ4 = 0.5f;
		_1EQ5 = 0.5f;
		_1EQ6 = 0.5f;
		_1EQ7 = 0.5f;
		_1EQ8 = 0.5f;
		_1EQ9 = 0.5f;
		_1EQ10 = 0.5f;
		_1EQ11 = 0.5f;
		_1EQ12 = 0.5f;
		_1EQ13 = 0.5f;
		_1EQ14 = 0.5f;
		_1EQ15 = 0.5f;
		_1OGain = 0.5f;
		_2EQ0 = 0.5f;
		_2EQ1 = 0.5f;
		_2EQ2 = 0.5f;
		_2EQ3 = 0.5f;
		_2EQ4 = 0.5f;
		_2EQ5 = 0.5f;
		_2EQ6 = 0.5f;
		_2EQ7 = 0.5f;
		_2EQ8 = 0.5f;
		_2EQ9 = 0.5f;
		_2EQ10 = 0.5f;
		_2EQ11 = 0.5f;
		_2EQ12 = 0.5f;
		_2EQ13 = 0.5f;
		_2EQ14 = 0.5f;
		_2EQ15 = 0.5f;
		_2OGain = 0.5f;
	}

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Bypass = 0.0f;
	private float lastBypass = -1f;
	public readonly int BypassIndex = 0;
	public readonly string BypassLow = "Off";
	public readonly string BypassHigh = "On";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ0 = 0.5f;
	private float last_1EQ0 = -1f;
	public readonly int _1EQ0Index = 1;
	public readonly string _1EQ0Low = "-12.0dB";
	public readonly string _1EQ0High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ1 = 0.5f;
	private float last_1EQ1 = -1f;
	public readonly int _1EQ1Index = 2;
	public readonly string _1EQ1Low = "-12.0dB";
	public readonly string _1EQ1High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ2 = 0.5f;
	private float last_1EQ2 = -1f;
	public readonly int _1EQ2Index = 3;
	public readonly string _1EQ2Low = "-12.0dB";
	public readonly string _1EQ2High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ3 = 0.5f;
	private float last_1EQ3 = -1f;
	public readonly int _1EQ3Index = 4;
	public readonly string _1EQ3Low = "-12.0dB";
	public readonly string _1EQ3High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ4 = 0.5f;
	private float last_1EQ4 = -1f;
	public readonly int _1EQ4Index = 5;
	public readonly string _1EQ4Low = "-12.0dB";
	public readonly string _1EQ4High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ5 = 0.5f;
	private float last_1EQ5 = -1f;
	public readonly int _1EQ5Index = 6;
	public readonly string _1EQ5Low = "-12.0dB";
	public readonly string _1EQ5High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ6 = 0.5f;
	private float last_1EQ6 = -1f;
	public readonly int _1EQ6Index = 7;
	public readonly string _1EQ6Low = "-12.0dB";
	public readonly string _1EQ6High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ7 = 0.5f;
	private float last_1EQ7 = -1f;
	public readonly int _1EQ7Index = 8;
	public readonly string _1EQ7Low = "-12.0dB";
	public readonly string _1EQ7High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ8 = 0.5f;
	private float last_1EQ8 = -1f;
	public readonly int _1EQ8Index = 9;
	public readonly string _1EQ8Low = "-12.0dB";
	public readonly string _1EQ8High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ9 = 0.5f;
	private float last_1EQ9 = -1f;
	public readonly int _1EQ9Index = 10;
	public readonly string _1EQ9Low = "-12.0dB";
	public readonly string _1EQ9High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ10 = 0.5f;
	private float last_1EQ10 = -1f;
	public readonly int _1EQ10Index = 11;
	public readonly string _1EQ10Low = "-12.0dB";
	public readonly string _1EQ10High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ11 = 0.5f;
	private float last_1EQ11 = -1f;
	public readonly int _1EQ11Index = 12;
	public readonly string _1EQ11Low = "-12.0dB";
	public readonly string _1EQ11High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ12 = 0.5f;
	private float last_1EQ12 = -1f;
	public readonly int _1EQ12Index = 13;
	public readonly string _1EQ12Low = "-12.0dB";
	public readonly string _1EQ12High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ13 = 0.5f;
	private float last_1EQ13 = -1f;
	public readonly int _1EQ13Index = 14;
	public readonly string _1EQ13Low = "-12.0dB";
	public readonly string _1EQ13High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ14 = 0.5f;
	private float last_1EQ14 = -1f;
	public readonly int _1EQ14Index = 15;
	public readonly string _1EQ14Low = "-12.0dB";
	public readonly string _1EQ14High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1EQ15 = 0.5f;
	private float last_1EQ15 = -1f;
	public readonly int _1EQ15Index = 16;
	public readonly string _1EQ15Low = "-12.0dB";
	public readonly string _1EQ15High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _1OGain = 0.5f;
	private float last_1OGain = -1f;
	public readonly int _1OGainIndex = 17;
	public readonly string _1OGainLow = "-12.0dB";
	public readonly string _1OGainHigh = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ0 = 0.5f;
	private float last_2EQ0 = -1f;
	public readonly int _2EQ0Index = 18;
	public readonly string _2EQ0Low = "-12.0dB";
	public readonly string _2EQ0High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ1 = 0.5f;
	private float last_2EQ1 = -1f;
	public readonly int _2EQ1Index = 19;
	public readonly string _2EQ1Low = "-12.0dB";
	public readonly string _2EQ1High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ2 = 0.5f;
	private float last_2EQ2 = -1f;
	public readonly int _2EQ2Index = 20;
	public readonly string _2EQ2Low = "-12.0dB";
	public readonly string _2EQ2High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ3 = 0.5f;
	private float last_2EQ3 = -1f;
	public readonly int _2EQ3Index = 21;
	public readonly string _2EQ3Low = "-12.0dB";
	public readonly string _2EQ3High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ4 = 0.5f;
	private float last_2EQ4 = -1f;
	public readonly int _2EQ4Index = 22;
	public readonly string _2EQ4Low = "-12.0dB";
	public readonly string _2EQ4High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ5 = 0.5f;
	private float last_2EQ5 = -1f;
	public readonly int _2EQ5Index = 23;
	public readonly string _2EQ5Low = "-12.0dB";
	public readonly string _2EQ5High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ6 = 0.5f;
	private float last_2EQ6 = -1f;
	public readonly int _2EQ6Index = 24;
	public readonly string _2EQ6Low = "-12.0dB";
	public readonly string _2EQ6High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ7 = 0.5f;
	private float last_2EQ7 = -1f;
	public readonly int _2EQ7Index = 25;
	public readonly string _2EQ7Low = "-12.0dB";
	public readonly string _2EQ7High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ8 = 0.5f;
	private float last_2EQ8 = -1f;
	public readonly int _2EQ8Index = 26;
	public readonly string _2EQ8Low = "-12.0dB";
	public readonly string _2EQ8High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ9 = 0.5f;
	private float last_2EQ9 = -1f;
	public readonly int _2EQ9Index = 27;
	public readonly string _2EQ9Low = "-12.0dB";
	public readonly string _2EQ9High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ10 = 0.5f;
	private float last_2EQ10 = -1f;
	public readonly int _2EQ10Index = 28;
	public readonly string _2EQ10Low = "-12.0dB";
	public readonly string _2EQ10High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ11 = 0.5f;
	private float last_2EQ11 = -1f;
	public readonly int _2EQ11Index = 29;
	public readonly string _2EQ11Low = "-12.0dB";
	public readonly string _2EQ11High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ12 = 0.5f;
	private float last_2EQ12 = -1f;
	public readonly int _2EQ12Index = 30;
	public readonly string _2EQ12Low = "-12.0dB";
	public readonly string _2EQ12High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ13 = 0.5f;
	private float last_2EQ13 = -1f;
	public readonly int _2EQ13Index = 31;
	public readonly string _2EQ13Low = "-12.0dB";
	public readonly string _2EQ13High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ14 = 0.5f;
	private float last_2EQ14 = -1f;
	public readonly int _2EQ14Index = 32;
	public readonly string _2EQ14Low = "-12.0dB";
	public readonly string _2EQ14High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2EQ15 = 0.5f;
	private float last_2EQ15 = -1f;
	public readonly int _2EQ15Index = 33;
	public readonly string _2EQ15Low = "-12.0dB";
	public readonly string _2EQ15High = "12.0dB";

	[Tooltip("-12.0dB  |  12.0dB")]
	[Range(0.0f, 1.0f)]
	public float _2OGain = 0.5f;
	private float last_2OGain = -1f;
	public readonly int _2OGainIndex = 34;
	public readonly string _2OGainLow = "-12.0dB";
	public readonly string _2OGainHigh = "12.0dB";

	public override string getFilterName() {
		return "./vst/Marvel GEQ.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Bypass != lastBypass) isUpdated = true;
		if(_1EQ0 != last_1EQ0) isUpdated = true;
		if(_1EQ1 != last_1EQ1) isUpdated = true;
		if(_1EQ2 != last_1EQ2) isUpdated = true;
		if(_1EQ3 != last_1EQ3) isUpdated = true;
		if(_1EQ4 != last_1EQ4) isUpdated = true;
		if(_1EQ5 != last_1EQ5) isUpdated = true;
		if(_1EQ6 != last_1EQ6) isUpdated = true;
		if(_1EQ7 != last_1EQ7) isUpdated = true;
		if(_1EQ8 != last_1EQ8) isUpdated = true;
		if(_1EQ9 != last_1EQ9) isUpdated = true;
		if(_1EQ10 != last_1EQ10) isUpdated = true;
		if(_1EQ11 != last_1EQ11) isUpdated = true;
		if(_1EQ12 != last_1EQ12) isUpdated = true;
		if(_1EQ13 != last_1EQ13) isUpdated = true;
		if(_1EQ14 != last_1EQ14) isUpdated = true;
		if(_1EQ15 != last_1EQ15) isUpdated = true;
		if(_1OGain != last_1OGain) isUpdated = true;
		if(_2EQ0 != last_2EQ0) isUpdated = true;
		if(_2EQ1 != last_2EQ1) isUpdated = true;
		if(_2EQ2 != last_2EQ2) isUpdated = true;
		if(_2EQ3 != last_2EQ3) isUpdated = true;
		if(_2EQ4 != last_2EQ4) isUpdated = true;
		if(_2EQ5 != last_2EQ5) isUpdated = true;
		if(_2EQ6 != last_2EQ6) isUpdated = true;
		if(_2EQ7 != last_2EQ7) isUpdated = true;
		if(_2EQ8 != last_2EQ8) isUpdated = true;
		if(_2EQ9 != last_2EQ9) isUpdated = true;
		if(_2EQ10 != last_2EQ10) isUpdated = true;
		if(_2EQ11 != last_2EQ11) isUpdated = true;
		if(_2EQ12 != last_2EQ12) isUpdated = true;
		if(_2EQ13 != last_2EQ13) isUpdated = true;
		if(_2EQ14 != last_2EQ14) isUpdated = true;
		if(_2EQ15 != last_2EQ15) isUpdated = true;
		if(_2OGain != last_2OGain) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Marvel GEQ.dll");
		if(Bypass != lastBypass) {
			client.sendPacket("parameter 0 "+Bypass);
			lastBypass = Bypass;
		}
		if(_1EQ0 != last_1EQ0) {
			client.sendPacket("parameter 1 "+_1EQ0);
			last_1EQ0 = _1EQ0;
		}
		if(_1EQ1 != last_1EQ1) {
			client.sendPacket("parameter 2 "+_1EQ1);
			last_1EQ1 = _1EQ1;
		}
		if(_1EQ2 != last_1EQ2) {
			client.sendPacket("parameter 3 "+_1EQ2);
			last_1EQ2 = _1EQ2;
		}
		if(_1EQ3 != last_1EQ3) {
			client.sendPacket("parameter 4 "+_1EQ3);
			last_1EQ3 = _1EQ3;
		}
		if(_1EQ4 != last_1EQ4) {
			client.sendPacket("parameter 5 "+_1EQ4);
			last_1EQ4 = _1EQ4;
		}
		if(_1EQ5 != last_1EQ5) {
			client.sendPacket("parameter 6 "+_1EQ5);
			last_1EQ5 = _1EQ5;
		}
		if(_1EQ6 != last_1EQ6) {
			client.sendPacket("parameter 7 "+_1EQ6);
			last_1EQ6 = _1EQ6;
		}
		if(_1EQ7 != last_1EQ7) {
			client.sendPacket("parameter 8 "+_1EQ7);
			last_1EQ7 = _1EQ7;
		}
		if(_1EQ8 != last_1EQ8) {
			client.sendPacket("parameter 9 "+_1EQ8);
			last_1EQ8 = _1EQ8;
		}
		if(_1EQ9 != last_1EQ9) {
			client.sendPacket("parameter 10 "+_1EQ9);
			last_1EQ9 = _1EQ9;
		}
		if(_1EQ10 != last_1EQ10) {
			client.sendPacket("parameter 11 "+_1EQ10);
			last_1EQ10 = _1EQ10;
		}
		if(_1EQ11 != last_1EQ11) {
			client.sendPacket("parameter 12 "+_1EQ11);
			last_1EQ11 = _1EQ11;
		}
		if(_1EQ12 != last_1EQ12) {
			client.sendPacket("parameter 13 "+_1EQ12);
			last_1EQ12 = _1EQ12;
		}
		if(_1EQ13 != last_1EQ13) {
			client.sendPacket("parameter 14 "+_1EQ13);
			last_1EQ13 = _1EQ13;
		}
		if(_1EQ14 != last_1EQ14) {
			client.sendPacket("parameter 15 "+_1EQ14);
			last_1EQ14 = _1EQ14;
		}
		if(_1EQ15 != last_1EQ15) {
			client.sendPacket("parameter 16 "+_1EQ15);
			last_1EQ15 = _1EQ15;
		}
		if(_1OGain != last_1OGain) {
			client.sendPacket("parameter 17 "+_1OGain);
			last_1OGain = _1OGain;
		}
		if(_2EQ0 != last_2EQ0) {
			client.sendPacket("parameter 18 "+_2EQ0);
			last_2EQ0 = _2EQ0;
		}
		if(_2EQ1 != last_2EQ1) {
			client.sendPacket("parameter 19 "+_2EQ1);
			last_2EQ1 = _2EQ1;
		}
		if(_2EQ2 != last_2EQ2) {
			client.sendPacket("parameter 20 "+_2EQ2);
			last_2EQ2 = _2EQ2;
		}
		if(_2EQ3 != last_2EQ3) {
			client.sendPacket("parameter 21 "+_2EQ3);
			last_2EQ3 = _2EQ3;
		}
		if(_2EQ4 != last_2EQ4) {
			client.sendPacket("parameter 22 "+_2EQ4);
			last_2EQ4 = _2EQ4;
		}
		if(_2EQ5 != last_2EQ5) {
			client.sendPacket("parameter 23 "+_2EQ5);
			last_2EQ5 = _2EQ5;
		}
		if(_2EQ6 != last_2EQ6) {
			client.sendPacket("parameter 24 "+_2EQ6);
			last_2EQ6 = _2EQ6;
		}
		if(_2EQ7 != last_2EQ7) {
			client.sendPacket("parameter 25 "+_2EQ7);
			last_2EQ7 = _2EQ7;
		}
		if(_2EQ8 != last_2EQ8) {
			client.sendPacket("parameter 26 "+_2EQ8);
			last_2EQ8 = _2EQ8;
		}
		if(_2EQ9 != last_2EQ9) {
			client.sendPacket("parameter 27 "+_2EQ9);
			last_2EQ9 = _2EQ9;
		}
		if(_2EQ10 != last_2EQ10) {
			client.sendPacket("parameter 28 "+_2EQ10);
			last_2EQ10 = _2EQ10;
		}
		if(_2EQ11 != last_2EQ11) {
			client.sendPacket("parameter 29 "+_2EQ11);
			last_2EQ11 = _2EQ11;
		}
		if(_2EQ12 != last_2EQ12) {
			client.sendPacket("parameter 30 "+_2EQ12);
			last_2EQ12 = _2EQ12;
		}
		if(_2EQ13 != last_2EQ13) {
			client.sendPacket("parameter 31 "+_2EQ13);
			last_2EQ13 = _2EQ13;
		}
		if(_2EQ14 != last_2EQ14) {
			client.sendPacket("parameter 32 "+_2EQ14);
			last_2EQ14 = _2EQ14;
		}
		if(_2EQ15 != last_2EQ15) {
			client.sendPacket("parameter 33 "+_2EQ15);
			last_2EQ15 = _2EQ15;
		}
		if(_2OGain != last_2OGain) {
			client.sendPacket("parameter 34 "+_2OGain);
			last_2OGain = _2OGain;
		}
	}

	public override void resetStateTrackers() {
		lastBypass = -1f;
		last_1EQ0 = -1f;
		last_1EQ1 = -1f;
		last_1EQ2 = -1f;
		last_1EQ3 = -1f;
		last_1EQ4 = -1f;
		last_1EQ5 = -1f;
		last_1EQ6 = -1f;
		last_1EQ7 = -1f;
		last_1EQ8 = -1f;
		last_1EQ9 = -1f;
		last_1EQ10 = -1f;
		last_1EQ11 = -1f;
		last_1EQ12 = -1f;
		last_1EQ13 = -1f;
		last_1EQ14 = -1f;
		last_1EQ15 = -1f;
		last_1OGain = -1f;
		last_2EQ0 = -1f;
		last_2EQ1 = -1f;
		last_2EQ2 = -1f;
		last_2EQ3 = -1f;
		last_2EQ4 = -1f;
		last_2EQ5 = -1f;
		last_2EQ6 = -1f;
		last_2EQ7 = -1f;
		last_2EQ8 = -1f;
		last_2EQ9 = -1f;
		last_2EQ10 = -1f;
		last_2EQ11 = -1f;
		last_2EQ12 = -1f;
		last_2EQ13 = -1f;
		last_2EQ14 = -1f;
		last_2EQ15 = -1f;
		last_2OGain = -1f;
	}
}
