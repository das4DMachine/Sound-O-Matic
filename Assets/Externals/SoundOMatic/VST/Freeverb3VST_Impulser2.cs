using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Freeverb3VST_Impulser2")]
public class Freeverb3VST_Impulser2 : VSTFilter {

	public readonly string pluginPath = "Freeverb3VST_Impulser2.dll";

	public override void resetToDefaults() {
		_0Width = 1.0f;
		_0Wet = 0.62500006f;
		_0MuteW = 0.0f;
		_0LPF = 0.0f;
		_0HPF = 0.0f;
		_0M2S = 0.0f;
		_0Swap = 0.0f;
		_0Delay = 0.5f;
		_0LRBal = 0.5f;
		_1Width = 1.0f;
		_1Wet = 0.62500006f;
		_1MuteW = 0.0f;
		_1LPF = 0.0f;
		_1HPF = 0.0f;
		_1M2S = 0.0f;
		_1Swap = 0.0f;
		_1Delay = 0.5f;
		_1LRBal = 0.5f;
		_2Width = 1.0f;
		_2Wet = 0.62500006f;
		_2MuteW = 0.0f;
		_2LPF = 0.0f;
		_2HPF = 0.0f;
		_2M2S = 0.0f;
		_2Swap = 0.0f;
		_2Delay = 0.5f;
		_2LRBal = 0.5f;
		_3Width = 1.0f;
		_3Wet = 0.62500006f;
		_3MuteW = 0.0f;
		_3LPF = 0.0f;
		_3HPF = 0.0f;
		_3M2S = 0.0f;
		_3Swap = 0.0f;
		_3Delay = 0.5f;
		_3LRBal = 0.5f;
		_4Width = 1.0f;
		_4Wet = 0.62500006f;
		_4MuteW = 0.0f;
		_4LPF = 0.0f;
		_4HPF = 0.0f;
		_4M2S = 0.0f;
		_4Swap = 0.0f;
		_4Delay = 0.5f;
		_4LRBal = 0.5f;
		_5Width = 1.0f;
		_5Wet = 0.62500006f;
		_5MuteW = 0.0f;
		_5LPF = 0.0f;
		_5HPF = 0.0f;
		_5M2S = 0.0f;
		_5Swap = 0.0f;
		_5Delay = 0.5f;
		_5LRBal = 0.5f;
		_6Width = 1.0f;
		_6Wet = 0.62500006f;
		_6MuteW = 0.0f;
		_6LPF = 0.0f;
		_6HPF = 0.0f;
		_6M2S = 0.0f;
		_6Swap = 0.0f;
		_6Delay = 0.5f;
		_6LRBal = 0.5f;
		_7Width = 1.0f;
		_7Wet = 0.62500006f;
		_7MuteW = 0.0f;
		_7LPF = 0.0f;
		_7HPF = 0.0f;
		_7M2S = 0.0f;
		_7Swap = 0.0f;
		_7Delay = 0.5f;
		_7LRBal = 0.5f;
		_8Width = 1.0f;
		_8Wet = 0.62500006f;
		_8MuteW = 0.0f;
		_8LPF = 0.0f;
		_8HPF = 0.0f;
		_8M2S = 0.0f;
		_8Swap = 0.0f;
		_8Delay = 0.5f;
		_8LRBal = 0.5f;
		_9Width = 1.0f;
		_9Wet = 0.62500006f;
		_9MuteW = 0.0f;
		_9LPF = 0.0f;
		_9HPF = 0.0f;
		_9M2S = 0.0f;
		_9Swap = 0.0f;
		_9Delay = 0.5f;
		_9LRBal = 0.5f;
		Rele = 0.020000001f;
		Ceili = 0.5f;
		Thres = 0.475f;
		Dry = 0.7916667f;
		SkipL = 0.0f;
	}

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _0Width = 1.0f;
	private float last_0Width = -1f;
	public readonly int _0WidthIndex = 0;
	public readonly string _0WidthLow = "0.000000%";
	public readonly string _0WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _0Wet = 0.62500006f;
	private float last_0Wet = -1f;
	public readonly int _0WetIndex = 1;
	public readonly string _0WetLow = "-100.000dB";
	public readonly string _0WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _0MuteW = 0.0f;
	private float last_0MuteW = -1f;
	public readonly int _0MuteWIndex = 2;
	public readonly string _0MuteWLow = "m offdB";
	public readonly string _0MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _0LPF = 0.0f;
	private float last_0LPF = -1f;
	public readonly int _0LPFIndex = 3;
	public readonly string _0LPFLow = "0.000000%";
	public readonly string _0LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _0HPF = 0.0f;
	private float last_0HPF = -1f;
	public readonly int _0HPFIndex = 4;
	public readonly string _0HPFLow = "0.000000%";
	public readonly string _0HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _0M2S = 0.0f;
	private float last_0M2S = -1f;
	public readonly int _0M2SIndex = 5;
	public readonly string _0M2SLow = "off";
	public readonly string _0M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _0Swap = 0.0f;
	private float last_0Swap = -1f;
	public readonly int _0SwapIndex = 6;
	public readonly string _0SwapLow = "off";
	public readonly string _0SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _0Delay = 0.5f;
	private float last_0Delay = -1f;
	public readonly int _0DelayIndex = 7;
	public readonly string _0DelayLow = "-1000.00s";
	public readonly string _0DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _0LRBal = 0.5f;
	private float last_0LRBal = -1f;
	public readonly int _0LRBalIndex = 8;
	public readonly string _0LRBalLow = "-L-C-R";
	public readonly string _0LRBalHigh = "-L-C-R";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _1Width = 1.0f;
	private float last_1Width = -1f;
	public readonly int _1WidthIndex = 16;
	public readonly string _1WidthLow = "0.000000%";
	public readonly string _1WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _1Wet = 0.62500006f;
	private float last_1Wet = -1f;
	public readonly int _1WetIndex = 17;
	public readonly string _1WetLow = "-100.000dB";
	public readonly string _1WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _1MuteW = 0.0f;
	private float last_1MuteW = -1f;
	public readonly int _1MuteWIndex = 18;
	public readonly string _1MuteWLow = "m offdB";
	public readonly string _1MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _1LPF = 0.0f;
	private float last_1LPF = -1f;
	public readonly int _1LPFIndex = 19;
	public readonly string _1LPFLow = "0.000000%";
	public readonly string _1LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _1HPF = 0.0f;
	private float last_1HPF = -1f;
	public readonly int _1HPFIndex = 20;
	public readonly string _1HPFLow = "0.000000%";
	public readonly string _1HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _1M2S = 0.0f;
	private float last_1M2S = -1f;
	public readonly int _1M2SIndex = 21;
	public readonly string _1M2SLow = "off";
	public readonly string _1M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _1Swap = 0.0f;
	private float last_1Swap = -1f;
	public readonly int _1SwapIndex = 22;
	public readonly string _1SwapLow = "off";
	public readonly string _1SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _1Delay = 0.5f;
	private float last_1Delay = -1f;
	public readonly int _1DelayIndex = 23;
	public readonly string _1DelayLow = "-1000.00s";
	public readonly string _1DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _1LRBal = 0.5f;
	private float last_1LRBal = -1f;
	public readonly int _1LRBalIndex = 24;
	public readonly string _1LRBalLow = "-L-C-R";
	public readonly string _1LRBalHigh = "-L-C-R";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _2Width = 1.0f;
	private float last_2Width = -1f;
	public readonly int _2WidthIndex = 32;
	public readonly string _2WidthLow = "0.000000%";
	public readonly string _2WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _2Wet = 0.62500006f;
	private float last_2Wet = -1f;
	public readonly int _2WetIndex = 33;
	public readonly string _2WetLow = "-100.000dB";
	public readonly string _2WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _2MuteW = 0.0f;
	private float last_2MuteW = -1f;
	public readonly int _2MuteWIndex = 34;
	public readonly string _2MuteWLow = "m offdB";
	public readonly string _2MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _2LPF = 0.0f;
	private float last_2LPF = -1f;
	public readonly int _2LPFIndex = 35;
	public readonly string _2LPFLow = "0.000000%";
	public readonly string _2LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _2HPF = 0.0f;
	private float last_2HPF = -1f;
	public readonly int _2HPFIndex = 36;
	public readonly string _2HPFLow = "0.000000%";
	public readonly string _2HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _2M2S = 0.0f;
	private float last_2M2S = -1f;
	public readonly int _2M2SIndex = 37;
	public readonly string _2M2SLow = "off";
	public readonly string _2M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _2Swap = 0.0f;
	private float last_2Swap = -1f;
	public readonly int _2SwapIndex = 38;
	public readonly string _2SwapLow = "off";
	public readonly string _2SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _2Delay = 0.5f;
	private float last_2Delay = -1f;
	public readonly int _2DelayIndex = 39;
	public readonly string _2DelayLow = "-1000.00s";
	public readonly string _2DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _2LRBal = 0.5f;
	private float last_2LRBal = -1f;
	public readonly int _2LRBalIndex = 40;
	public readonly string _2LRBalLow = "-L-C-R";
	public readonly string _2LRBalHigh = "-L-C-R";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _3Width = 1.0f;
	private float last_3Width = -1f;
	public readonly int _3WidthIndex = 48;
	public readonly string _3WidthLow = "0.000000%";
	public readonly string _3WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _3Wet = 0.62500006f;
	private float last_3Wet = -1f;
	public readonly int _3WetIndex = 49;
	public readonly string _3WetLow = "-100.000dB";
	public readonly string _3WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _3MuteW = 0.0f;
	private float last_3MuteW = -1f;
	public readonly int _3MuteWIndex = 50;
	public readonly string _3MuteWLow = "m offdB";
	public readonly string _3MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _3LPF = 0.0f;
	private float last_3LPF = -1f;
	public readonly int _3LPFIndex = 51;
	public readonly string _3LPFLow = "0.000000%";
	public readonly string _3LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _3HPF = 0.0f;
	private float last_3HPF = -1f;
	public readonly int _3HPFIndex = 52;
	public readonly string _3HPFLow = "0.000000%";
	public readonly string _3HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _3M2S = 0.0f;
	private float last_3M2S = -1f;
	public readonly int _3M2SIndex = 53;
	public readonly string _3M2SLow = "off";
	public readonly string _3M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _3Swap = 0.0f;
	private float last_3Swap = -1f;
	public readonly int _3SwapIndex = 54;
	public readonly string _3SwapLow = "off";
	public readonly string _3SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _3Delay = 0.5f;
	private float last_3Delay = -1f;
	public readonly int _3DelayIndex = 55;
	public readonly string _3DelayLow = "-1000.00s";
	public readonly string _3DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _3LRBal = 0.5f;
	private float last_3LRBal = -1f;
	public readonly int _3LRBalIndex = 56;
	public readonly string _3LRBalLow = "-L-C-R";
	public readonly string _3LRBalHigh = "-L-C-R";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _4Width = 1.0f;
	private float last_4Width = -1f;
	public readonly int _4WidthIndex = 64;
	public readonly string _4WidthLow = "0.000000%";
	public readonly string _4WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _4Wet = 0.62500006f;
	private float last_4Wet = -1f;
	public readonly int _4WetIndex = 65;
	public readonly string _4WetLow = "-100.000dB";
	public readonly string _4WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _4MuteW = 0.0f;
	private float last_4MuteW = -1f;
	public readonly int _4MuteWIndex = 66;
	public readonly string _4MuteWLow = "m offdB";
	public readonly string _4MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _4LPF = 0.0f;
	private float last_4LPF = -1f;
	public readonly int _4LPFIndex = 67;
	public readonly string _4LPFLow = "0.000000%";
	public readonly string _4LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _4HPF = 0.0f;
	private float last_4HPF = -1f;
	public readonly int _4HPFIndex = 68;
	public readonly string _4HPFLow = "0.000000%";
	public readonly string _4HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _4M2S = 0.0f;
	private float last_4M2S = -1f;
	public readonly int _4M2SIndex = 69;
	public readonly string _4M2SLow = "off";
	public readonly string _4M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _4Swap = 0.0f;
	private float last_4Swap = -1f;
	public readonly int _4SwapIndex = 70;
	public readonly string _4SwapLow = "off";
	public readonly string _4SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _4Delay = 0.5f;
	private float last_4Delay = -1f;
	public readonly int _4DelayIndex = 71;
	public readonly string _4DelayLow = "-1000.00s";
	public readonly string _4DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _4LRBal = 0.5f;
	private float last_4LRBal = -1f;
	public readonly int _4LRBalIndex = 72;
	public readonly string _4LRBalLow = "-L-C-R";
	public readonly string _4LRBalHigh = "-L-C-R";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _5Width = 1.0f;
	private float last_5Width = -1f;
	public readonly int _5WidthIndex = 80;
	public readonly string _5WidthLow = "0.000000%";
	public readonly string _5WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _5Wet = 0.62500006f;
	private float last_5Wet = -1f;
	public readonly int _5WetIndex = 81;
	public readonly string _5WetLow = "-100.000dB";
	public readonly string _5WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _5MuteW = 0.0f;
	private float last_5MuteW = -1f;
	public readonly int _5MuteWIndex = 82;
	public readonly string _5MuteWLow = "m offdB";
	public readonly string _5MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _5LPF = 0.0f;
	private float last_5LPF = -1f;
	public readonly int _5LPFIndex = 83;
	public readonly string _5LPFLow = "0.000000%";
	public readonly string _5LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _5HPF = 0.0f;
	private float last_5HPF = -1f;
	public readonly int _5HPFIndex = 84;
	public readonly string _5HPFLow = "0.000000%";
	public readonly string _5HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _5M2S = 0.0f;
	private float last_5M2S = -1f;
	public readonly int _5M2SIndex = 85;
	public readonly string _5M2SLow = "off";
	public readonly string _5M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _5Swap = 0.0f;
	private float last_5Swap = -1f;
	public readonly int _5SwapIndex = 86;
	public readonly string _5SwapLow = "off";
	public readonly string _5SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _5Delay = 0.5f;
	private float last_5Delay = -1f;
	public readonly int _5DelayIndex = 87;
	public readonly string _5DelayLow = "-1000.00s";
	public readonly string _5DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _5LRBal = 0.5f;
	private float last_5LRBal = -1f;
	public readonly int _5LRBalIndex = 88;
	public readonly string _5LRBalLow = "-L-C-R";
	public readonly string _5LRBalHigh = "-L-C-R";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _6Width = 1.0f;
	private float last_6Width = -1f;
	public readonly int _6WidthIndex = 96;
	public readonly string _6WidthLow = "0.000000%";
	public readonly string _6WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _6Wet = 0.62500006f;
	private float last_6Wet = -1f;
	public readonly int _6WetIndex = 97;
	public readonly string _6WetLow = "-100.000dB";
	public readonly string _6WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _6MuteW = 0.0f;
	private float last_6MuteW = -1f;
	public readonly int _6MuteWIndex = 98;
	public readonly string _6MuteWLow = "m offdB";
	public readonly string _6MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _6LPF = 0.0f;
	private float last_6LPF = -1f;
	public readonly int _6LPFIndex = 99;
	public readonly string _6LPFLow = "0.000000%";
	public readonly string _6LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _6HPF = 0.0f;
	private float last_6HPF = -1f;
	public readonly int _6HPFIndex = 100;
	public readonly string _6HPFLow = "0.000000%";
	public readonly string _6HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _6M2S = 0.0f;
	private float last_6M2S = -1f;
	public readonly int _6M2SIndex = 101;
	public readonly string _6M2SLow = "off";
	public readonly string _6M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _6Swap = 0.0f;
	private float last_6Swap = -1f;
	public readonly int _6SwapIndex = 102;
	public readonly string _6SwapLow = "off";
	public readonly string _6SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _6Delay = 0.5f;
	private float last_6Delay = -1f;
	public readonly int _6DelayIndex = 103;
	public readonly string _6DelayLow = "-1000.00s";
	public readonly string _6DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _6LRBal = 0.5f;
	private float last_6LRBal = -1f;
	public readonly int _6LRBalIndex = 104;
	public readonly string _6LRBalLow = "-L-C-R";
	public readonly string _6LRBalHigh = "-L-C-R";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _7Width = 1.0f;
	private float last_7Width = -1f;
	public readonly int _7WidthIndex = 112;
	public readonly string _7WidthLow = "0.000000%";
	public readonly string _7WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _7Wet = 0.62500006f;
	private float last_7Wet = -1f;
	public readonly int _7WetIndex = 113;
	public readonly string _7WetLow = "-100.000dB";
	public readonly string _7WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _7MuteW = 0.0f;
	private float last_7MuteW = -1f;
	public readonly int _7MuteWIndex = 114;
	public readonly string _7MuteWLow = "m offdB";
	public readonly string _7MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _7LPF = 0.0f;
	private float last_7LPF = -1f;
	public readonly int _7LPFIndex = 115;
	public readonly string _7LPFLow = "0.000000%";
	public readonly string _7LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _7HPF = 0.0f;
	private float last_7HPF = -1f;
	public readonly int _7HPFIndex = 116;
	public readonly string _7HPFLow = "0.000000%";
	public readonly string _7HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _7M2S = 0.0f;
	private float last_7M2S = -1f;
	public readonly int _7M2SIndex = 117;
	public readonly string _7M2SLow = "off";
	public readonly string _7M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _7Swap = 0.0f;
	private float last_7Swap = -1f;
	public readonly int _7SwapIndex = 118;
	public readonly string _7SwapLow = "off";
	public readonly string _7SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _7Delay = 0.5f;
	private float last_7Delay = -1f;
	public readonly int _7DelayIndex = 119;
	public readonly string _7DelayLow = "-1000.00s";
	public readonly string _7DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _7LRBal = 0.5f;
	private float last_7LRBal = -1f;
	public readonly int _7LRBalIndex = 120;
	public readonly string _7LRBalLow = "-L-C-R";
	public readonly string _7LRBalHigh = "-L-C-R";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _8Width = 1.0f;
	private float last_8Width = -1f;
	public readonly int _8WidthIndex = 128;
	public readonly string _8WidthLow = "0.000000%";
	public readonly string _8WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _8Wet = 0.62500006f;
	private float last_8Wet = -1f;
	public readonly int _8WetIndex = 129;
	public readonly string _8WetLow = "-100.000dB";
	public readonly string _8WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _8MuteW = 0.0f;
	private float last_8MuteW = -1f;
	public readonly int _8MuteWIndex = 130;
	public readonly string _8MuteWLow = "m offdB";
	public readonly string _8MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _8LPF = 0.0f;
	private float last_8LPF = -1f;
	public readonly int _8LPFIndex = 131;
	public readonly string _8LPFLow = "0.000000%";
	public readonly string _8LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _8HPF = 0.0f;
	private float last_8HPF = -1f;
	public readonly int _8HPFIndex = 132;
	public readonly string _8HPFLow = "0.000000%";
	public readonly string _8HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _8M2S = 0.0f;
	private float last_8M2S = -1f;
	public readonly int _8M2SIndex = 133;
	public readonly string _8M2SLow = "off";
	public readonly string _8M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _8Swap = 0.0f;
	private float last_8Swap = -1f;
	public readonly int _8SwapIndex = 134;
	public readonly string _8SwapLow = "off";
	public readonly string _8SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _8Delay = 0.5f;
	private float last_8Delay = -1f;
	public readonly int _8DelayIndex = 135;
	public readonly string _8DelayLow = "-1000.00s";
	public readonly string _8DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _8LRBal = 0.5f;
	private float last_8LRBal = -1f;
	public readonly int _8LRBalIndex = 136;
	public readonly string _8LRBalLow = "-L-C-R";
	public readonly string _8LRBalHigh = "-L-C-R";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _9Width = 1.0f;
	private float last_9Width = -1f;
	public readonly int _9WidthIndex = 144;
	public readonly string _9WidthLow = "0.000000%";
	public readonly string _9WidthHigh = "100.0000%";

	[Tooltip("-100.000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float _9Wet = 0.62500006f;
	private float last_9Wet = -1f;
	public readonly int _9WetIndex = 145;
	public readonly string _9WetLow = "-100.000dB";
	public readonly string _9WetHigh = "20.00000dB";

	[Tooltip("m offdB  |  m ondB")]
	[Range(0.0f, 1.0f)]
	public float _9MuteW = 0.0f;
	private float last_9MuteW = -1f;
	public readonly int _9MuteWIndex = 146;
	public readonly string _9MuteWLow = "m offdB";
	public readonly string _9MuteWHigh = "m ondB";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _9LPF = 0.0f;
	private float last_9LPF = -1f;
	public readonly int _9LPFIndex = 147;
	public readonly string _9LPFLow = "0.000000%";
	public readonly string _9LPFHigh = "100.0000%";

	[Tooltip("0.000000%  |  100.0000%")]
	[Range(0.0f, 1.0f)]
	public float _9HPF = 0.0f;
	private float last_9HPF = -1f;
	public readonly int _9HPFIndex = 148;
	public readonly string _9HPFLow = "0.000000%";
	public readonly string _9HPFHigh = "100.0000%";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _9M2S = 0.0f;
	private float last_9M2S = -1f;
	public readonly int _9M2SIndex = 149;
	public readonly string _9M2SLow = "off";
	public readonly string _9M2SHigh = "on";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float _9Swap = 0.0f;
	private float last_9Swap = -1f;
	public readonly int _9SwapIndex = 150;
	public readonly string _9SwapLow = "off";
	public readonly string _9SwapHigh = "on";

	[Tooltip("-1000.00s  |  1000.000s")]
	[Range(0.0f, 1.0f)]
	public float _9Delay = 0.5f;
	private float last_9Delay = -1f;
	public readonly int _9DelayIndex = 151;
	public readonly string _9DelayLow = "-1000.00s";
	public readonly string _9DelayHigh = "1000.000s";

	[Tooltip("-L-C-R  |  -L-C-R")]
	[Range(0.0f, 1.0f)]
	public float _9LRBal = 0.5f;
	private float last_9LRBal = -1f;
	public readonly int _9LRBalIndex = 152;
	public readonly string _9LRBalLow = "-L-C-R";
	public readonly string _9LRBalHigh = "-L-C-R";

	[Tooltip("0.000000ms  |  500.0000ms")]
	[Range(0.0f, 1.0f)]
	public float Rele = 0.020000001f;
	private float lastRele = -1f;
	public readonly int ReleIndex = 160;
	public readonly string ReleLow = "0.000000ms";
	public readonly string ReleHigh = "500.0000ms";

	[Tooltip("-1.00000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Ceili = 0.5f;
	private float lastCeili = -1f;
	public readonly int CeiliIndex = 161;
	public readonly string CeiliLow = "-1.00000dB";
	public readonly string CeiliHigh = "20.00000dB";

	[Tooltip("-20.0000dB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Thres = 0.475f;
	private float lastThres = -1f;
	public readonly int ThresIndex = 162;
	public readonly string ThresLow = "-20.0000dB";
	public readonly string ThresHigh = "20.00000dB";

	[Tooltip("-infdB  |  20.00000dB")]
	[Range(0.0f, 1.0f)]
	public float Dry = 0.7916667f;
	private float lastDry = -1f;
	public readonly int DryIndex = 163;
	public readonly string DryLow = "-infdB";
	public readonly string DryHigh = "20.00000dB";

	[Tooltip("off  |  on")]
	[Range(0.0f, 1.0f)]
	public float SkipL = 0.0f;
	private float lastSkipL = -1f;
	public readonly int SkipLIndex = 164;
	public readonly string SkipLLow = "off";
	public readonly string SkipLHigh = "on";

	public override string getFilterName() {
		return "./vst/Freeverb3VST_Impulser2.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(_0Width != last_0Width) isUpdated = true;
		if(_0Wet != last_0Wet) isUpdated = true;
		if(_0MuteW != last_0MuteW) isUpdated = true;
		if(_0LPF != last_0LPF) isUpdated = true;
		if(_0HPF != last_0HPF) isUpdated = true;
		if(_0M2S != last_0M2S) isUpdated = true;
		if(_0Swap != last_0Swap) isUpdated = true;
		if(_0Delay != last_0Delay) isUpdated = true;
		if(_0LRBal != last_0LRBal) isUpdated = true;
		if(_1Width != last_1Width) isUpdated = true;
		if(_1Wet != last_1Wet) isUpdated = true;
		if(_1MuteW != last_1MuteW) isUpdated = true;
		if(_1LPF != last_1LPF) isUpdated = true;
		if(_1HPF != last_1HPF) isUpdated = true;
		if(_1M2S != last_1M2S) isUpdated = true;
		if(_1Swap != last_1Swap) isUpdated = true;
		if(_1Delay != last_1Delay) isUpdated = true;
		if(_1LRBal != last_1LRBal) isUpdated = true;
		if(_2Width != last_2Width) isUpdated = true;
		if(_2Wet != last_2Wet) isUpdated = true;
		if(_2MuteW != last_2MuteW) isUpdated = true;
		if(_2LPF != last_2LPF) isUpdated = true;
		if(_2HPF != last_2HPF) isUpdated = true;
		if(_2M2S != last_2M2S) isUpdated = true;
		if(_2Swap != last_2Swap) isUpdated = true;
		if(_2Delay != last_2Delay) isUpdated = true;
		if(_2LRBal != last_2LRBal) isUpdated = true;
		if(_3Width != last_3Width) isUpdated = true;
		if(_3Wet != last_3Wet) isUpdated = true;
		if(_3MuteW != last_3MuteW) isUpdated = true;
		if(_3LPF != last_3LPF) isUpdated = true;
		if(_3HPF != last_3HPF) isUpdated = true;
		if(_3M2S != last_3M2S) isUpdated = true;
		if(_3Swap != last_3Swap) isUpdated = true;
		if(_3Delay != last_3Delay) isUpdated = true;
		if(_3LRBal != last_3LRBal) isUpdated = true;
		if(_4Width != last_4Width) isUpdated = true;
		if(_4Wet != last_4Wet) isUpdated = true;
		if(_4MuteW != last_4MuteW) isUpdated = true;
		if(_4LPF != last_4LPF) isUpdated = true;
		if(_4HPF != last_4HPF) isUpdated = true;
		if(_4M2S != last_4M2S) isUpdated = true;
		if(_4Swap != last_4Swap) isUpdated = true;
		if(_4Delay != last_4Delay) isUpdated = true;
		if(_4LRBal != last_4LRBal) isUpdated = true;
		if(_5Width != last_5Width) isUpdated = true;
		if(_5Wet != last_5Wet) isUpdated = true;
		if(_5MuteW != last_5MuteW) isUpdated = true;
		if(_5LPF != last_5LPF) isUpdated = true;
		if(_5HPF != last_5HPF) isUpdated = true;
		if(_5M2S != last_5M2S) isUpdated = true;
		if(_5Swap != last_5Swap) isUpdated = true;
		if(_5Delay != last_5Delay) isUpdated = true;
		if(_5LRBal != last_5LRBal) isUpdated = true;
		if(_6Width != last_6Width) isUpdated = true;
		if(_6Wet != last_6Wet) isUpdated = true;
		if(_6MuteW != last_6MuteW) isUpdated = true;
		if(_6LPF != last_6LPF) isUpdated = true;
		if(_6HPF != last_6HPF) isUpdated = true;
		if(_6M2S != last_6M2S) isUpdated = true;
		if(_6Swap != last_6Swap) isUpdated = true;
		if(_6Delay != last_6Delay) isUpdated = true;
		if(_6LRBal != last_6LRBal) isUpdated = true;
		if(_7Width != last_7Width) isUpdated = true;
		if(_7Wet != last_7Wet) isUpdated = true;
		if(_7MuteW != last_7MuteW) isUpdated = true;
		if(_7LPF != last_7LPF) isUpdated = true;
		if(_7HPF != last_7HPF) isUpdated = true;
		if(_7M2S != last_7M2S) isUpdated = true;
		if(_7Swap != last_7Swap) isUpdated = true;
		if(_7Delay != last_7Delay) isUpdated = true;
		if(_7LRBal != last_7LRBal) isUpdated = true;
		if(_8Width != last_8Width) isUpdated = true;
		if(_8Wet != last_8Wet) isUpdated = true;
		if(_8MuteW != last_8MuteW) isUpdated = true;
		if(_8LPF != last_8LPF) isUpdated = true;
		if(_8HPF != last_8HPF) isUpdated = true;
		if(_8M2S != last_8M2S) isUpdated = true;
		if(_8Swap != last_8Swap) isUpdated = true;
		if(_8Delay != last_8Delay) isUpdated = true;
		if(_8LRBal != last_8LRBal) isUpdated = true;
		if(_9Width != last_9Width) isUpdated = true;
		if(_9Wet != last_9Wet) isUpdated = true;
		if(_9MuteW != last_9MuteW) isUpdated = true;
		if(_9LPF != last_9LPF) isUpdated = true;
		if(_9HPF != last_9HPF) isUpdated = true;
		if(_9M2S != last_9M2S) isUpdated = true;
		if(_9Swap != last_9Swap) isUpdated = true;
		if(_9Delay != last_9Delay) isUpdated = true;
		if(_9LRBal != last_9LRBal) isUpdated = true;
		if(Rele != lastRele) isUpdated = true;
		if(Ceili != lastCeili) isUpdated = true;
		if(Thres != lastThres) isUpdated = true;
		if(Dry != lastDry) isUpdated = true;
		if(SkipL != lastSkipL) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Freeverb3VST_Impulser2.dll");
		if(_0Width != last_0Width) {
			client.sendPacket("parameter 0 "+_0Width);
			last_0Width = _0Width;
		}
		if(_0Wet != last_0Wet) {
			client.sendPacket("parameter 1 "+_0Wet);
			last_0Wet = _0Wet;
		}
		if(_0MuteW != last_0MuteW) {
			client.sendPacket("parameter 2 "+_0MuteW);
			last_0MuteW = _0MuteW;
		}
		if(_0LPF != last_0LPF) {
			client.sendPacket("parameter 3 "+_0LPF);
			last_0LPF = _0LPF;
		}
		if(_0HPF != last_0HPF) {
			client.sendPacket("parameter 4 "+_0HPF);
			last_0HPF = _0HPF;
		}
		if(_0M2S != last_0M2S) {
			client.sendPacket("parameter 5 "+_0M2S);
			last_0M2S = _0M2S;
		}
		if(_0Swap != last_0Swap) {
			client.sendPacket("parameter 6 "+_0Swap);
			last_0Swap = _0Swap;
		}
		if(_0Delay != last_0Delay) {
			client.sendPacket("parameter 7 "+_0Delay);
			last_0Delay = _0Delay;
		}
		if(_0LRBal != last_0LRBal) {
			client.sendPacket("parameter 8 "+_0LRBal);
			last_0LRBal = _0LRBal;
		}
		if(_1Width != last_1Width) {
			client.sendPacket("parameter 16 "+_1Width);
			last_1Width = _1Width;
		}
		if(_1Wet != last_1Wet) {
			client.sendPacket("parameter 17 "+_1Wet);
			last_1Wet = _1Wet;
		}
		if(_1MuteW != last_1MuteW) {
			client.sendPacket("parameter 18 "+_1MuteW);
			last_1MuteW = _1MuteW;
		}
		if(_1LPF != last_1LPF) {
			client.sendPacket("parameter 19 "+_1LPF);
			last_1LPF = _1LPF;
		}
		if(_1HPF != last_1HPF) {
			client.sendPacket("parameter 20 "+_1HPF);
			last_1HPF = _1HPF;
		}
		if(_1M2S != last_1M2S) {
			client.sendPacket("parameter 21 "+_1M2S);
			last_1M2S = _1M2S;
		}
		if(_1Swap != last_1Swap) {
			client.sendPacket("parameter 22 "+_1Swap);
			last_1Swap = _1Swap;
		}
		if(_1Delay != last_1Delay) {
			client.sendPacket("parameter 23 "+_1Delay);
			last_1Delay = _1Delay;
		}
		if(_1LRBal != last_1LRBal) {
			client.sendPacket("parameter 24 "+_1LRBal);
			last_1LRBal = _1LRBal;
		}
		if(_2Width != last_2Width) {
			client.sendPacket("parameter 32 "+_2Width);
			last_2Width = _2Width;
		}
		if(_2Wet != last_2Wet) {
			client.sendPacket("parameter 33 "+_2Wet);
			last_2Wet = _2Wet;
		}
		if(_2MuteW != last_2MuteW) {
			client.sendPacket("parameter 34 "+_2MuteW);
			last_2MuteW = _2MuteW;
		}
		if(_2LPF != last_2LPF) {
			client.sendPacket("parameter 35 "+_2LPF);
			last_2LPF = _2LPF;
		}
		if(_2HPF != last_2HPF) {
			client.sendPacket("parameter 36 "+_2HPF);
			last_2HPF = _2HPF;
		}
		if(_2M2S != last_2M2S) {
			client.sendPacket("parameter 37 "+_2M2S);
			last_2M2S = _2M2S;
		}
		if(_2Swap != last_2Swap) {
			client.sendPacket("parameter 38 "+_2Swap);
			last_2Swap = _2Swap;
		}
		if(_2Delay != last_2Delay) {
			client.sendPacket("parameter 39 "+_2Delay);
			last_2Delay = _2Delay;
		}
		if(_2LRBal != last_2LRBal) {
			client.sendPacket("parameter 40 "+_2LRBal);
			last_2LRBal = _2LRBal;
		}
		if(_3Width != last_3Width) {
			client.sendPacket("parameter 48 "+_3Width);
			last_3Width = _3Width;
		}
		if(_3Wet != last_3Wet) {
			client.sendPacket("parameter 49 "+_3Wet);
			last_3Wet = _3Wet;
		}
		if(_3MuteW != last_3MuteW) {
			client.sendPacket("parameter 50 "+_3MuteW);
			last_3MuteW = _3MuteW;
		}
		if(_3LPF != last_3LPF) {
			client.sendPacket("parameter 51 "+_3LPF);
			last_3LPF = _3LPF;
		}
		if(_3HPF != last_3HPF) {
			client.sendPacket("parameter 52 "+_3HPF);
			last_3HPF = _3HPF;
		}
		if(_3M2S != last_3M2S) {
			client.sendPacket("parameter 53 "+_3M2S);
			last_3M2S = _3M2S;
		}
		if(_3Swap != last_3Swap) {
			client.sendPacket("parameter 54 "+_3Swap);
			last_3Swap = _3Swap;
		}
		if(_3Delay != last_3Delay) {
			client.sendPacket("parameter 55 "+_3Delay);
			last_3Delay = _3Delay;
		}
		if(_3LRBal != last_3LRBal) {
			client.sendPacket("parameter 56 "+_3LRBal);
			last_3LRBal = _3LRBal;
		}
		if(_4Width != last_4Width) {
			client.sendPacket("parameter 64 "+_4Width);
			last_4Width = _4Width;
		}
		if(_4Wet != last_4Wet) {
			client.sendPacket("parameter 65 "+_4Wet);
			last_4Wet = _4Wet;
		}
		if(_4MuteW != last_4MuteW) {
			client.sendPacket("parameter 66 "+_4MuteW);
			last_4MuteW = _4MuteW;
		}
		if(_4LPF != last_4LPF) {
			client.sendPacket("parameter 67 "+_4LPF);
			last_4LPF = _4LPF;
		}
		if(_4HPF != last_4HPF) {
			client.sendPacket("parameter 68 "+_4HPF);
			last_4HPF = _4HPF;
		}
		if(_4M2S != last_4M2S) {
			client.sendPacket("parameter 69 "+_4M2S);
			last_4M2S = _4M2S;
		}
		if(_4Swap != last_4Swap) {
			client.sendPacket("parameter 70 "+_4Swap);
			last_4Swap = _4Swap;
		}
		if(_4Delay != last_4Delay) {
			client.sendPacket("parameter 71 "+_4Delay);
			last_4Delay = _4Delay;
		}
		if(_4LRBal != last_4LRBal) {
			client.sendPacket("parameter 72 "+_4LRBal);
			last_4LRBal = _4LRBal;
		}
		if(_5Width != last_5Width) {
			client.sendPacket("parameter 80 "+_5Width);
			last_5Width = _5Width;
		}
		if(_5Wet != last_5Wet) {
			client.sendPacket("parameter 81 "+_5Wet);
			last_5Wet = _5Wet;
		}
		if(_5MuteW != last_5MuteW) {
			client.sendPacket("parameter 82 "+_5MuteW);
			last_5MuteW = _5MuteW;
		}
		if(_5LPF != last_5LPF) {
			client.sendPacket("parameter 83 "+_5LPF);
			last_5LPF = _5LPF;
		}
		if(_5HPF != last_5HPF) {
			client.sendPacket("parameter 84 "+_5HPF);
			last_5HPF = _5HPF;
		}
		if(_5M2S != last_5M2S) {
			client.sendPacket("parameter 85 "+_5M2S);
			last_5M2S = _5M2S;
		}
		if(_5Swap != last_5Swap) {
			client.sendPacket("parameter 86 "+_5Swap);
			last_5Swap = _5Swap;
		}
		if(_5Delay != last_5Delay) {
			client.sendPacket("parameter 87 "+_5Delay);
			last_5Delay = _5Delay;
		}
		if(_5LRBal != last_5LRBal) {
			client.sendPacket("parameter 88 "+_5LRBal);
			last_5LRBal = _5LRBal;
		}
		if(_6Width != last_6Width) {
			client.sendPacket("parameter 96 "+_6Width);
			last_6Width = _6Width;
		}
		if(_6Wet != last_6Wet) {
			client.sendPacket("parameter 97 "+_6Wet);
			last_6Wet = _6Wet;
		}
		if(_6MuteW != last_6MuteW) {
			client.sendPacket("parameter 98 "+_6MuteW);
			last_6MuteW = _6MuteW;
		}
		if(_6LPF != last_6LPF) {
			client.sendPacket("parameter 99 "+_6LPF);
			last_6LPF = _6LPF;
		}
		if(_6HPF != last_6HPF) {
			client.sendPacket("parameter 100 "+_6HPF);
			last_6HPF = _6HPF;
		}
		if(_6M2S != last_6M2S) {
			client.sendPacket("parameter 101 "+_6M2S);
			last_6M2S = _6M2S;
		}
		if(_6Swap != last_6Swap) {
			client.sendPacket("parameter 102 "+_6Swap);
			last_6Swap = _6Swap;
		}
		if(_6Delay != last_6Delay) {
			client.sendPacket("parameter 103 "+_6Delay);
			last_6Delay = _6Delay;
		}
		if(_6LRBal != last_6LRBal) {
			client.sendPacket("parameter 104 "+_6LRBal);
			last_6LRBal = _6LRBal;
		}
		if(_7Width != last_7Width) {
			client.sendPacket("parameter 112 "+_7Width);
			last_7Width = _7Width;
		}
		if(_7Wet != last_7Wet) {
			client.sendPacket("parameter 113 "+_7Wet);
			last_7Wet = _7Wet;
		}
		if(_7MuteW != last_7MuteW) {
			client.sendPacket("parameter 114 "+_7MuteW);
			last_7MuteW = _7MuteW;
		}
		if(_7LPF != last_7LPF) {
			client.sendPacket("parameter 115 "+_7LPF);
			last_7LPF = _7LPF;
		}
		if(_7HPF != last_7HPF) {
			client.sendPacket("parameter 116 "+_7HPF);
			last_7HPF = _7HPF;
		}
		if(_7M2S != last_7M2S) {
			client.sendPacket("parameter 117 "+_7M2S);
			last_7M2S = _7M2S;
		}
		if(_7Swap != last_7Swap) {
			client.sendPacket("parameter 118 "+_7Swap);
			last_7Swap = _7Swap;
		}
		if(_7Delay != last_7Delay) {
			client.sendPacket("parameter 119 "+_7Delay);
			last_7Delay = _7Delay;
		}
		if(_7LRBal != last_7LRBal) {
			client.sendPacket("parameter 120 "+_7LRBal);
			last_7LRBal = _7LRBal;
		}
		if(_8Width != last_8Width) {
			client.sendPacket("parameter 128 "+_8Width);
			last_8Width = _8Width;
		}
		if(_8Wet != last_8Wet) {
			client.sendPacket("parameter 129 "+_8Wet);
			last_8Wet = _8Wet;
		}
		if(_8MuteW != last_8MuteW) {
			client.sendPacket("parameter 130 "+_8MuteW);
			last_8MuteW = _8MuteW;
		}
		if(_8LPF != last_8LPF) {
			client.sendPacket("parameter 131 "+_8LPF);
			last_8LPF = _8LPF;
		}
		if(_8HPF != last_8HPF) {
			client.sendPacket("parameter 132 "+_8HPF);
			last_8HPF = _8HPF;
		}
		if(_8M2S != last_8M2S) {
			client.sendPacket("parameter 133 "+_8M2S);
			last_8M2S = _8M2S;
		}
		if(_8Swap != last_8Swap) {
			client.sendPacket("parameter 134 "+_8Swap);
			last_8Swap = _8Swap;
		}
		if(_8Delay != last_8Delay) {
			client.sendPacket("parameter 135 "+_8Delay);
			last_8Delay = _8Delay;
		}
		if(_8LRBal != last_8LRBal) {
			client.sendPacket("parameter 136 "+_8LRBal);
			last_8LRBal = _8LRBal;
		}
		if(_9Width != last_9Width) {
			client.sendPacket("parameter 144 "+_9Width);
			last_9Width = _9Width;
		}
		if(_9Wet != last_9Wet) {
			client.sendPacket("parameter 145 "+_9Wet);
			last_9Wet = _9Wet;
		}
		if(_9MuteW != last_9MuteW) {
			client.sendPacket("parameter 146 "+_9MuteW);
			last_9MuteW = _9MuteW;
		}
		if(_9LPF != last_9LPF) {
			client.sendPacket("parameter 147 "+_9LPF);
			last_9LPF = _9LPF;
		}
		if(_9HPF != last_9HPF) {
			client.sendPacket("parameter 148 "+_9HPF);
			last_9HPF = _9HPF;
		}
		if(_9M2S != last_9M2S) {
			client.sendPacket("parameter 149 "+_9M2S);
			last_9M2S = _9M2S;
		}
		if(_9Swap != last_9Swap) {
			client.sendPacket("parameter 150 "+_9Swap);
			last_9Swap = _9Swap;
		}
		if(_9Delay != last_9Delay) {
			client.sendPacket("parameter 151 "+_9Delay);
			last_9Delay = _9Delay;
		}
		if(_9LRBal != last_9LRBal) {
			client.sendPacket("parameter 152 "+_9LRBal);
			last_9LRBal = _9LRBal;
		}
		if(Rele != lastRele) {
			client.sendPacket("parameter 160 "+Rele);
			lastRele = Rele;
		}
		if(Ceili != lastCeili) {
			client.sendPacket("parameter 161 "+Ceili);
			lastCeili = Ceili;
		}
		if(Thres != lastThres) {
			client.sendPacket("parameter 162 "+Thres);
			lastThres = Thres;
		}
		if(Dry != lastDry) {
			client.sendPacket("parameter 163 "+Dry);
			lastDry = Dry;
		}
		if(SkipL != lastSkipL) {
			client.sendPacket("parameter 164 "+SkipL);
			lastSkipL = SkipL;
		}
	}

	public override void resetStateTrackers() {
		last_0Width = -1f;
		last_0Wet = -1f;
		last_0MuteW = -1f;
		last_0LPF = -1f;
		last_0HPF = -1f;
		last_0M2S = -1f;
		last_0Swap = -1f;
		last_0Delay = -1f;
		last_0LRBal = -1f;
		last_1Width = -1f;
		last_1Wet = -1f;
		last_1MuteW = -1f;
		last_1LPF = -1f;
		last_1HPF = -1f;
		last_1M2S = -1f;
		last_1Swap = -1f;
		last_1Delay = -1f;
		last_1LRBal = -1f;
		last_2Width = -1f;
		last_2Wet = -1f;
		last_2MuteW = -1f;
		last_2LPF = -1f;
		last_2HPF = -1f;
		last_2M2S = -1f;
		last_2Swap = -1f;
		last_2Delay = -1f;
		last_2LRBal = -1f;
		last_3Width = -1f;
		last_3Wet = -1f;
		last_3MuteW = -1f;
		last_3LPF = -1f;
		last_3HPF = -1f;
		last_3M2S = -1f;
		last_3Swap = -1f;
		last_3Delay = -1f;
		last_3LRBal = -1f;
		last_4Width = -1f;
		last_4Wet = -1f;
		last_4MuteW = -1f;
		last_4LPF = -1f;
		last_4HPF = -1f;
		last_4M2S = -1f;
		last_4Swap = -1f;
		last_4Delay = -1f;
		last_4LRBal = -1f;
		last_5Width = -1f;
		last_5Wet = -1f;
		last_5MuteW = -1f;
		last_5LPF = -1f;
		last_5HPF = -1f;
		last_5M2S = -1f;
		last_5Swap = -1f;
		last_5Delay = -1f;
		last_5LRBal = -1f;
		last_6Width = -1f;
		last_6Wet = -1f;
		last_6MuteW = -1f;
		last_6LPF = -1f;
		last_6HPF = -1f;
		last_6M2S = -1f;
		last_6Swap = -1f;
		last_6Delay = -1f;
		last_6LRBal = -1f;
		last_7Width = -1f;
		last_7Wet = -1f;
		last_7MuteW = -1f;
		last_7LPF = -1f;
		last_7HPF = -1f;
		last_7M2S = -1f;
		last_7Swap = -1f;
		last_7Delay = -1f;
		last_7LRBal = -1f;
		last_8Width = -1f;
		last_8Wet = -1f;
		last_8MuteW = -1f;
		last_8LPF = -1f;
		last_8HPF = -1f;
		last_8M2S = -1f;
		last_8Swap = -1f;
		last_8Delay = -1f;
		last_8LRBal = -1f;
		last_9Width = -1f;
		last_9Wet = -1f;
		last_9MuteW = -1f;
		last_9LPF = -1f;
		last_9HPF = -1f;
		last_9M2S = -1f;
		last_9Swap = -1f;
		last_9Delay = -1f;
		last_9LRBal = -1f;
		lastRele = -1f;
		lastCeili = -1f;
		lastThres = -1f;
		lastDry = -1f;
		lastSkipL = -1f;
	}
}
