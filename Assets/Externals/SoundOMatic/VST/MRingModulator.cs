using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/MRingModulator")]
public class MRingModulator : VSTFilter {

	public readonly string pluginPath = "MRingModulator.dll";

	public override void resetToDefaults() {
		Modulateoscillators = 0.0f;
		Oscillator1Oscillato = 1.0f;
		Oscillator1Depth = 1.0f;
		Oscillator1Frequency = 0.13264666f;
		Oscillator1Phase = 0.1f;
		Oscillator2Oscillato = 0.0f;
		Oscillator2Depth = 1.0f;
		Oscillator2Frequency = 0.13264666f;
		Oscillator2Phase = 0.1f;
		Oscillator1shapeCus = 0.0f;
		Oscillator1shapeSmo = 0.0f;
		Oscillator2shapeCus = 0.0f;
		Oscillator2shapeSmo = 0.0f;
		Oscillator1Sidechai = 0.0f;
		Oscillator2Sidechai = 0.0f;
	}

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Modulateoscillators = 0.0f;
	private float lastModulateoscillators = -1f;
	public readonly int ModulateoscillatorsIndex = 0;
	public readonly string ModulateoscillatorsLow = "Off";
	public readonly string ModulateoscillatorsHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Oscillator1Oscillato = 1.0f;
	private float lastOscillator1Oscillato = -1f;
	public readonly int Oscillator1OscillatoIndex = 1;
	public readonly string Oscillator1OscillatoLow = "Off";
	public readonly string Oscillator1OscillatoHigh = "On";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Oscillator1Depth = 1.0f;
	private float lastOscillator1Depth = -1f;
	public readonly int Oscillator1DepthIndex = 2;
	public readonly string Oscillator1DepthLow = "0.00%";
	public readonly string Oscillator1DepthHigh = "100.0%";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Oscillator1Frequency = 0.13264666f;
	private float lastOscillator1Frequency = -1f;
	public readonly int Oscillator1FrequencyIndex = 3;
	public readonly string Oscillator1FrequencyLow = "20.0 Hz";
	public readonly string Oscillator1FrequencyHigh = "20.0 kHz";

	[Tooltip("0° (0%)  |  360° (100.0%)")]
	[Range(0.0f, 1.0f)]
	public float Oscillator1Phase = 0.1f;
	private float lastOscillator1Phase = -1f;
	public readonly int Oscillator1PhaseIndex = 4;
	public readonly string Oscillator1PhaseLow = "0° (0%)";
	public readonly string Oscillator1PhaseHigh = "360° (100.0%)";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Oscillator2Oscillato = 0.0f;
	private float lastOscillator2Oscillato = -1f;
	public readonly int Oscillator2OscillatoIndex = 5;
	public readonly string Oscillator2OscillatoLow = "Off";
	public readonly string Oscillator2OscillatoHigh = "On";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Oscillator2Depth = 1.0f;
	private float lastOscillator2Depth = -1f;
	public readonly int Oscillator2DepthIndex = 6;
	public readonly string Oscillator2DepthLow = "0.00%";
	public readonly string Oscillator2DepthHigh = "100.0%";

	[Tooltip("20.0 Hz  |  20.0 kHz")]
	[Range(0.0f, 1.0f)]
	public float Oscillator2Frequency = 0.13264666f;
	private float lastOscillator2Frequency = -1f;
	public readonly int Oscillator2FrequencyIndex = 7;
	public readonly string Oscillator2FrequencyLow = "20.0 Hz";
	public readonly string Oscillator2FrequencyHigh = "20.0 kHz";

	[Tooltip("0° (0%)  |  360° (100.0%)")]
	[Range(0.0f, 1.0f)]
	public float Oscillator2Phase = 0.1f;
	private float lastOscillator2Phase = -1f;
	public readonly int Oscillator2PhaseIndex = 8;
	public readonly string Oscillator2PhaseLow = "0° (0%)";
	public readonly string Oscillator2PhaseHigh = "360° (100.0%)";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Oscillator1shapeCus = 0.0f;
	private float lastOscillator1shapeCus = -1f;
	public readonly int Oscillator1shapeCusIndex = 10;
	public readonly string Oscillator1shapeCusLow = "0.00%";
	public readonly string Oscillator1shapeCusHigh = "100.0%";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Oscillator1shapeSmo = 0.0f;
	private float lastOscillator1shapeSmo = -1f;
	public readonly int Oscillator1shapeSmoIndex = 12;
	public readonly string Oscillator1shapeSmoLow = "0.00%";
	public readonly string Oscillator1shapeSmoHigh = "100.0%";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Oscillator2shapeCus = 0.0f;
	private float lastOscillator2shapeCus = -1f;
	public readonly int Oscillator2shapeCusIndex = 14;
	public readonly string Oscillator2shapeCusLow = "0.00%";
	public readonly string Oscillator2shapeCusHigh = "100.0%";

	[Tooltip("0.00%  |  100.0%")]
	[Range(0.0f, 1.0f)]
	public float Oscillator2shapeSmo = 0.0f;
	private float lastOscillator2shapeSmo = -1f;
	public readonly int Oscillator2shapeSmoIndex = 16;
	public readonly string Oscillator2shapeSmoLow = "0.00%";
	public readonly string Oscillator2shapeSmoHigh = "100.0%";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Oscillator1Sidechai = 0.0f;
	private float lastOscillator1Sidechai = -1f;
	public readonly int Oscillator1SidechaiIndex = 499;
	public readonly string Oscillator1SidechaiLow = "Off";
	public readonly string Oscillator1SidechaiHigh = "On";

	[Tooltip("Off  |  On")]
	[Range(0.0f, 1.0f)]
	public float Oscillator2Sidechai = 0.0f;
	private float lastOscillator2Sidechai = -1f;
	public readonly int Oscillator2SidechaiIndex = 500;
	public readonly string Oscillator2SidechaiLow = "Off";
	public readonly string Oscillator2SidechaiHigh = "On";

	public override string getFilterName() {
		return "./vst/MRingModulator.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(Modulateoscillators != lastModulateoscillators) isUpdated = true;
		if(Oscillator1Oscillato != lastOscillator1Oscillato) isUpdated = true;
		if(Oscillator1Depth != lastOscillator1Depth) isUpdated = true;
		if(Oscillator1Frequency != lastOscillator1Frequency) isUpdated = true;
		if(Oscillator1Phase != lastOscillator1Phase) isUpdated = true;
		if(Oscillator2Oscillato != lastOscillator2Oscillato) isUpdated = true;
		if(Oscillator2Depth != lastOscillator2Depth) isUpdated = true;
		if(Oscillator2Frequency != lastOscillator2Frequency) isUpdated = true;
		if(Oscillator2Phase != lastOscillator2Phase) isUpdated = true;
		if(Oscillator1shapeCus != lastOscillator1shapeCus) isUpdated = true;
		if(Oscillator1shapeSmo != lastOscillator1shapeSmo) isUpdated = true;
		if(Oscillator2shapeCus != lastOscillator2shapeCus) isUpdated = true;
		if(Oscillator2shapeSmo != lastOscillator2shapeSmo) isUpdated = true;
		if(Oscillator1Sidechai != lastOscillator1Sidechai) isUpdated = true;
		if(Oscillator2Sidechai != lastOscillator2Sidechai) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/MRingModulator.dll");
		if(Modulateoscillators != lastModulateoscillators) {
			client.sendPacket("parameter 0 "+Modulateoscillators);
			lastModulateoscillators = Modulateoscillators;
		}
		if(Oscillator1Oscillato != lastOscillator1Oscillato) {
			client.sendPacket("parameter 1 "+Oscillator1Oscillato);
			lastOscillator1Oscillato = Oscillator1Oscillato;
		}
		if(Oscillator1Depth != lastOscillator1Depth) {
			client.sendPacket("parameter 2 "+Oscillator1Depth);
			lastOscillator1Depth = Oscillator1Depth;
		}
		if(Oscillator1Frequency != lastOscillator1Frequency) {
			client.sendPacket("parameter 3 "+Oscillator1Frequency);
			lastOscillator1Frequency = Oscillator1Frequency;
		}
		if(Oscillator1Phase != lastOscillator1Phase) {
			client.sendPacket("parameter 4 "+Oscillator1Phase);
			lastOscillator1Phase = Oscillator1Phase;
		}
		if(Oscillator2Oscillato != lastOscillator2Oscillato) {
			client.sendPacket("parameter 5 "+Oscillator2Oscillato);
			lastOscillator2Oscillato = Oscillator2Oscillato;
		}
		if(Oscillator2Depth != lastOscillator2Depth) {
			client.sendPacket("parameter 6 "+Oscillator2Depth);
			lastOscillator2Depth = Oscillator2Depth;
		}
		if(Oscillator2Frequency != lastOscillator2Frequency) {
			client.sendPacket("parameter 7 "+Oscillator2Frequency);
			lastOscillator2Frequency = Oscillator2Frequency;
		}
		if(Oscillator2Phase != lastOscillator2Phase) {
			client.sendPacket("parameter 8 "+Oscillator2Phase);
			lastOscillator2Phase = Oscillator2Phase;
		}
		if(Oscillator1shapeCus != lastOscillator1shapeCus) {
			client.sendPacket("parameter 10 "+Oscillator1shapeCus);
			lastOscillator1shapeCus = Oscillator1shapeCus;
		}
		if(Oscillator1shapeSmo != lastOscillator1shapeSmo) {
			client.sendPacket("parameter 12 "+Oscillator1shapeSmo);
			lastOscillator1shapeSmo = Oscillator1shapeSmo;
		}
		if(Oscillator2shapeCus != lastOscillator2shapeCus) {
			client.sendPacket("parameter 14 "+Oscillator2shapeCus);
			lastOscillator2shapeCus = Oscillator2shapeCus;
		}
		if(Oscillator2shapeSmo != lastOscillator2shapeSmo) {
			client.sendPacket("parameter 16 "+Oscillator2shapeSmo);
			lastOscillator2shapeSmo = Oscillator2shapeSmo;
		}
		if(Oscillator1Sidechai != lastOscillator1Sidechai) {
			client.sendPacket("parameter 499 "+Oscillator1Sidechai);
			lastOscillator1Sidechai = Oscillator1Sidechai;
		}
		if(Oscillator2Sidechai != lastOscillator2Sidechai) {
			client.sendPacket("parameter 500 "+Oscillator2Sidechai);
			lastOscillator2Sidechai = Oscillator2Sidechai;
		}
	}

	public override void resetStateTrackers() {
		lastModulateoscillators = -1f;
		lastOscillator1Oscillato = -1f;
		lastOscillator1Depth = -1f;
		lastOscillator1Frequency = -1f;
		lastOscillator1Phase = -1f;
		lastOscillator2Oscillato = -1f;
		lastOscillator2Depth = -1f;
		lastOscillator2Frequency = -1f;
		lastOscillator2Phase = -1f;
		lastOscillator1shapeCus = -1f;
		lastOscillator1shapeSmo = -1f;
		lastOscillator2shapeCus = -1f;
		lastOscillator2shapeSmo = -1f;
		lastOscillator1Sidechai = -1f;
		lastOscillator2Sidechai = -1f;
	}
}
