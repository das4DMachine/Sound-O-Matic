using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/TAL_NoiseMaker")]
public class TAL_NoiseMaker : VSTFilter {

	public readonly string pluginPath = "TAL-NoiseMaker.dll";

	public override void resetToDefaults() {
		volume = 0.40800002f;
		filtertype = 0.0f;
		cutoff = 1.0f;
		resonance = 0.0f;
		keyfollow = 0.0f;
		filtercontour = 0.5f;
		filterattack = 0.0f;
		filterdecay = 0.0f;
		filtersustain = 1.0f;
		filterrelease = 0.0f;
		ampattack = 0.0f;
		ampdecay = 0.0f;
		ampsustain = 1.0f;
		amprelease = 0.0f;
		osc1volume = 0.8f;
		osc2volume = 0.0f;
		osc3volume = 0.8f;
		oscmastertune = 0.5f;
		osc1tune = 0.25f;
		osc2tune = 0.5f;
		osc1finetune = 0.5f;
		osc2finetune = 0.5f;
		osc1waveform = 0.0f;
		osc2waveform = 0.0f;
		oscsync = 0.0f;
		lfo1waveform = 0.0f;
		lfo2waveform = 0.0f;
		lfo1rate = 0.0f;
		lfo2rate = 0.0f;
		lfo1amount = 0.5f;
		lfo2amount = 0.5f;
		lfo1destination = 0.0f;
		lfo2destination = 0.0f;
		lfo1phase = 0.0f;
		lfo2phase = 0.0f;
		osc2fm = 0.0f;
		osc2phase = 0.0f;
		osc1pw = 0.5f;
		osc1phase = 0.5f;
		transpose = 0.5f;
		freeadattack = 0.0f;
		freeaddecay = 0.0f;
		freeadamount = 0.0f;
		freeaddestinati = 0.0f;
		lfo1sync = 0.0f;
		lfo1keytrigger = 0.0f;
		lfo2sync = 0.0f;
		lfo2keytrigger = 0.0f;
		portamento = 0.0f;
		portamentomode = 0.0f;
		voices = 0.0f;
		velocityvolume = 0.0f;
		velocitycontour = 0.0f;
		velocitycutoff = 0.0f;
		pitchwheelcutof = 0.0f;
		pitchwheelpitch = 0.0f;
		ringmodulation = 0.0f;
		chorus1enable = 0.0f;
		chorus2enable = 0.0f;
		reverbwet = 0.0f;
		reverbdecay = 0.5f;
		reverbpredelay = 0.0f;
		reverbhighcut = 0.0f;
		reverblowcut = 1.0f;
		oscbitcrusher = 1.0f;
		highpass = 0.0f;
		detune = 0.0f;
		vintagenoise = 0.0f;
		envelopeeditord = 0.0f;
		envelopeeditors = 0.0f;
		envelopeeditora = 0.0f;
		envelopeoneshot = 0.0f;
		envelopefixtemp = 0.0f;
		filterdrive = 0.0f;
		delaywet = 0.0f;
		delaytime = 0.5f;
		delaysync = 0.0f;
		delayfactorl = 0.0f;
		delayfactorr = 0.0f;
		delayhighshelf = 0.0f;
		delaylowshelf = 0.0f;
		delayfeedback = 0.5f;
	}

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float volume = 0.40800002f;
	private float lastvolume = -1f;
	public readonly int volumeIndex = 1;
	public readonly string volumeLow = "0.00";
	public readonly string volumeHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float filtertype = 0.0f;
	private float lastfiltertype = -1f;
	public readonly int filtertypeIndex = 2;
	public readonly string filtertypeLow = "0.00";
	public readonly string filtertypeHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float cutoff = 1.0f;
	private float lastcutoff = -1f;
	public readonly int cutoffIndex = 3;
	public readonly string cutoffLow = "0.00";
	public readonly string cutoffHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float resonance = 0.0f;
	private float lastresonance = -1f;
	public readonly int resonanceIndex = 4;
	public readonly string resonanceLow = "0.00";
	public readonly string resonanceHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float keyfollow = 0.0f;
	private float lastkeyfollow = -1f;
	public readonly int keyfollowIndex = 5;
	public readonly string keyfollowLow = "0.00";
	public readonly string keyfollowHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float filtercontour = 0.5f;
	private float lastfiltercontour = -1f;
	public readonly int filtercontourIndex = 6;
	public readonly string filtercontourLow = "0.00";
	public readonly string filtercontourHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float filterattack = 0.0f;
	private float lastfilterattack = -1f;
	public readonly int filterattackIndex = 7;
	public readonly string filterattackLow = "0.00";
	public readonly string filterattackHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float filterdecay = 0.0f;
	private float lastfilterdecay = -1f;
	public readonly int filterdecayIndex = 8;
	public readonly string filterdecayLow = "0.00";
	public readonly string filterdecayHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float filtersustain = 1.0f;
	private float lastfiltersustain = -1f;
	public readonly int filtersustainIndex = 9;
	public readonly string filtersustainLow = "0.00";
	public readonly string filtersustainHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float filterrelease = 0.0f;
	private float lastfilterrelease = -1f;
	public readonly int filterreleaseIndex = 10;
	public readonly string filterreleaseLow = "0.00";
	public readonly string filterreleaseHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float ampattack = 0.0f;
	private float lastampattack = -1f;
	public readonly int ampattackIndex = 11;
	public readonly string ampattackLow = "0.00";
	public readonly string ampattackHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float ampdecay = 0.0f;
	private float lastampdecay = -1f;
	public readonly int ampdecayIndex = 12;
	public readonly string ampdecayLow = "0.00";
	public readonly string ampdecayHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float ampsustain = 1.0f;
	private float lastampsustain = -1f;
	public readonly int ampsustainIndex = 13;
	public readonly string ampsustainLow = "0.00";
	public readonly string ampsustainHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float amprelease = 0.0f;
	private float lastamprelease = -1f;
	public readonly int ampreleaseIndex = 14;
	public readonly string ampreleaseLow = "0.00";
	public readonly string ampreleaseHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc1volume = 0.8f;
	private float lastosc1volume = -1f;
	public readonly int osc1volumeIndex = 15;
	public readonly string osc1volumeLow = "0.00";
	public readonly string osc1volumeHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc2volume = 0.0f;
	private float lastosc2volume = -1f;
	public readonly int osc2volumeIndex = 16;
	public readonly string osc2volumeLow = "0.00";
	public readonly string osc2volumeHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc3volume = 0.8f;
	private float lastosc3volume = -1f;
	public readonly int osc3volumeIndex = 17;
	public readonly string osc3volumeLow = "0.00";
	public readonly string osc3volumeHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float oscmastertune = 0.5f;
	private float lastoscmastertune = -1f;
	public readonly int oscmastertuneIndex = 18;
	public readonly string oscmastertuneLow = "0.00";
	public readonly string oscmastertuneHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc1tune = 0.25f;
	private float lastosc1tune = -1f;
	public readonly int osc1tuneIndex = 19;
	public readonly string osc1tuneLow = "0.00";
	public readonly string osc1tuneHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc2tune = 0.5f;
	private float lastosc2tune = -1f;
	public readonly int osc2tuneIndex = 20;
	public readonly string osc2tuneLow = "0.00";
	public readonly string osc2tuneHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc1finetune = 0.5f;
	private float lastosc1finetune = -1f;
	public readonly int osc1finetuneIndex = 21;
	public readonly string osc1finetuneLow = "0.00";
	public readonly string osc1finetuneHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc2finetune = 0.5f;
	private float lastosc2finetune = -1f;
	public readonly int osc2finetuneIndex = 22;
	public readonly string osc2finetuneLow = "0.00";
	public readonly string osc2finetuneHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc1waveform = 0.0f;
	private float lastosc1waveform = -1f;
	public readonly int osc1waveformIndex = 23;
	public readonly string osc1waveformLow = "0.00";
	public readonly string osc1waveformHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc2waveform = 0.0f;
	private float lastosc2waveform = -1f;
	public readonly int osc2waveformIndex = 24;
	public readonly string osc2waveformLow = "0.00";
	public readonly string osc2waveformHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float oscsync = 0.0f;
	private float lastoscsync = -1f;
	public readonly int oscsyncIndex = 25;
	public readonly string oscsyncLow = "0.00";
	public readonly string oscsyncHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo1waveform = 0.0f;
	private float lastlfo1waveform = -1f;
	public readonly int lfo1waveformIndex = 26;
	public readonly string lfo1waveformLow = "0.00";
	public readonly string lfo1waveformHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo2waveform = 0.0f;
	private float lastlfo2waveform = -1f;
	public readonly int lfo2waveformIndex = 27;
	public readonly string lfo2waveformLow = "0.00";
	public readonly string lfo2waveformHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo1rate = 0.0f;
	private float lastlfo1rate = -1f;
	public readonly int lfo1rateIndex = 28;
	public readonly string lfo1rateLow = "0.00";
	public readonly string lfo1rateHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo2rate = 0.0f;
	private float lastlfo2rate = -1f;
	public readonly int lfo2rateIndex = 29;
	public readonly string lfo2rateLow = "0.00";
	public readonly string lfo2rateHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo1amount = 0.5f;
	private float lastlfo1amount = -1f;
	public readonly int lfo1amountIndex = 30;
	public readonly string lfo1amountLow = "0.00";
	public readonly string lfo1amountHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo2amount = 0.5f;
	private float lastlfo2amount = -1f;
	public readonly int lfo2amountIndex = 31;
	public readonly string lfo2amountLow = "0.00";
	public readonly string lfo2amountHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo1destination = 0.0f;
	private float lastlfo1destination = -1f;
	public readonly int lfo1destinationIndex = 32;
	public readonly string lfo1destinationLow = "0.00";
	public readonly string lfo1destinationHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo2destination = 0.0f;
	private float lastlfo2destination = -1f;
	public readonly int lfo2destinationIndex = 33;
	public readonly string lfo2destinationLow = "0.00";
	public readonly string lfo2destinationHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo1phase = 0.0f;
	private float lastlfo1phase = -1f;
	public readonly int lfo1phaseIndex = 34;
	public readonly string lfo1phaseLow = "0.00";
	public readonly string lfo1phaseHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo2phase = 0.0f;
	private float lastlfo2phase = -1f;
	public readonly int lfo2phaseIndex = 35;
	public readonly string lfo2phaseLow = "0.00";
	public readonly string lfo2phaseHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc2fm = 0.0f;
	private float lastosc2fm = -1f;
	public readonly int osc2fmIndex = 36;
	public readonly string osc2fmLow = "0.00";
	public readonly string osc2fmHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc2phase = 0.0f;
	private float lastosc2phase = -1f;
	public readonly int osc2phaseIndex = 37;
	public readonly string osc2phaseLow = "0.00";
	public readonly string osc2phaseHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc1pw = 0.5f;
	private float lastosc1pw = -1f;
	public readonly int osc1pwIndex = 38;
	public readonly string osc1pwLow = "0.00";
	public readonly string osc1pwHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float osc1phase = 0.5f;
	private float lastosc1phase = -1f;
	public readonly int osc1phaseIndex = 39;
	public readonly string osc1phaseLow = "0.00";
	public readonly string osc1phaseHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float transpose = 0.5f;
	private float lasttranspose = -1f;
	public readonly int transposeIndex = 40;
	public readonly string transposeLow = "0.00";
	public readonly string transposeHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float freeadattack = 0.0f;
	private float lastfreeadattack = -1f;
	public readonly int freeadattackIndex = 41;
	public readonly string freeadattackLow = "0.00";
	public readonly string freeadattackHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float freeaddecay = 0.0f;
	private float lastfreeaddecay = -1f;
	public readonly int freeaddecayIndex = 42;
	public readonly string freeaddecayLow = "0.00";
	public readonly string freeaddecayHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float freeadamount = 0.0f;
	private float lastfreeadamount = -1f;
	public readonly int freeadamountIndex = 43;
	public readonly string freeadamountLow = "0.00";
	public readonly string freeadamountHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float freeaddestinati = 0.0f;
	private float lastfreeaddestinati = -1f;
	public readonly int freeaddestinatiIndex = 44;
	public readonly string freeaddestinatiLow = "0.00";
	public readonly string freeaddestinatiHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo1sync = 0.0f;
	private float lastlfo1sync = -1f;
	public readonly int lfo1syncIndex = 45;
	public readonly string lfo1syncLow = "0.00";
	public readonly string lfo1syncHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo1keytrigger = 0.0f;
	private float lastlfo1keytrigger = -1f;
	public readonly int lfo1keytriggerIndex = 46;
	public readonly string lfo1keytriggerLow = "0.00";
	public readonly string lfo1keytriggerHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo2sync = 0.0f;
	private float lastlfo2sync = -1f;
	public readonly int lfo2syncIndex = 47;
	public readonly string lfo2syncLow = "0.00";
	public readonly string lfo2syncHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float lfo2keytrigger = 0.0f;
	private float lastlfo2keytrigger = -1f;
	public readonly int lfo2keytriggerIndex = 48;
	public readonly string lfo2keytriggerLow = "0.00";
	public readonly string lfo2keytriggerHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float portamento = 0.0f;
	private float lastportamento = -1f;
	public readonly int portamentoIndex = 49;
	public readonly string portamentoLow = "0.00";
	public readonly string portamentoHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float portamentomode = 0.0f;
	private float lastportamentomode = -1f;
	public readonly int portamentomodeIndex = 50;
	public readonly string portamentomodeLow = "0.00";
	public readonly string portamentomodeHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float voices = 0.0f;
	private float lastvoices = -1f;
	public readonly int voicesIndex = 51;
	public readonly string voicesLow = "0.00";
	public readonly string voicesHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float velocityvolume = 0.0f;
	private float lastvelocityvolume = -1f;
	public readonly int velocityvolumeIndex = 52;
	public readonly string velocityvolumeLow = "0.00";
	public readonly string velocityvolumeHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float velocitycontour = 0.0f;
	private float lastvelocitycontour = -1f;
	public readonly int velocitycontourIndex = 53;
	public readonly string velocitycontourLow = "0.00";
	public readonly string velocitycontourHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float velocitycutoff = 0.0f;
	private float lastvelocitycutoff = -1f;
	public readonly int velocitycutoffIndex = 54;
	public readonly string velocitycutoffLow = "0.00";
	public readonly string velocitycutoffHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float pitchwheelcutof = 0.0f;
	private float lastpitchwheelcutof = -1f;
	public readonly int pitchwheelcutofIndex = 55;
	public readonly string pitchwheelcutofLow = "0.00";
	public readonly string pitchwheelcutofHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float pitchwheelpitch = 0.0f;
	private float lastpitchwheelpitch = -1f;
	public readonly int pitchwheelpitchIndex = 56;
	public readonly string pitchwheelpitchLow = "0.00";
	public readonly string pitchwheelpitchHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float ringmodulation = 0.0f;
	private float lastringmodulation = -1f;
	public readonly int ringmodulationIndex = 57;
	public readonly string ringmodulationLow = "0.00";
	public readonly string ringmodulationHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float chorus1enable = 0.0f;
	private float lastchorus1enable = -1f;
	public readonly int chorus1enableIndex = 58;
	public readonly string chorus1enableLow = "0.00";
	public readonly string chorus1enableHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float chorus2enable = 0.0f;
	private float lastchorus2enable = -1f;
	public readonly int chorus2enableIndex = 59;
	public readonly string chorus2enableLow = "0.00";
	public readonly string chorus2enableHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float reverbwet = 0.0f;
	private float lastreverbwet = -1f;
	public readonly int reverbwetIndex = 60;
	public readonly string reverbwetLow = "0.00";
	public readonly string reverbwetHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float reverbdecay = 0.5f;
	private float lastreverbdecay = -1f;
	public readonly int reverbdecayIndex = 61;
	public readonly string reverbdecayLow = "0.00";
	public readonly string reverbdecayHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float reverbpredelay = 0.0f;
	private float lastreverbpredelay = -1f;
	public readonly int reverbpredelayIndex = 62;
	public readonly string reverbpredelayLow = "0.00";
	public readonly string reverbpredelayHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float reverbhighcut = 0.0f;
	private float lastreverbhighcut = -1f;
	public readonly int reverbhighcutIndex = 63;
	public readonly string reverbhighcutLow = "0.00";
	public readonly string reverbhighcutHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float reverblowcut = 1.0f;
	private float lastreverblowcut = -1f;
	public readonly int reverblowcutIndex = 64;
	public readonly string reverblowcutLow = "0.00";
	public readonly string reverblowcutHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float oscbitcrusher = 1.0f;
	private float lastoscbitcrusher = -1f;
	public readonly int oscbitcrusherIndex = 65;
	public readonly string oscbitcrusherLow = "0.00";
	public readonly string oscbitcrusherHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float highpass = 0.0f;
	private float lasthighpass = -1f;
	public readonly int highpassIndex = 66;
	public readonly string highpassLow = "0.00";
	public readonly string highpassHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float detune = 0.0f;
	private float lastdetune = -1f;
	public readonly int detuneIndex = 67;
	public readonly string detuneLow = "0.00";
	public readonly string detuneHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float vintagenoise = 0.0f;
	private float lastvintagenoise = -1f;
	public readonly int vintagenoiseIndex = 68;
	public readonly string vintagenoiseLow = "0.00";
	public readonly string vintagenoiseHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float envelopeeditord = 0.0f;
	private float lastenvelopeeditord = -1f;
	public readonly int envelopeeditordIndex = 71;
	public readonly string envelopeeditordLow = "0.00";
	public readonly string envelopeeditordHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float envelopeeditors = 0.0f;
	private float lastenvelopeeditors = -1f;
	public readonly int envelopeeditorsIndex = 72;
	public readonly string envelopeeditorsLow = "0.00";
	public readonly string envelopeeditorsHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float envelopeeditora = 0.0f;
	private float lastenvelopeeditora = -1f;
	public readonly int envelopeeditoraIndex = 73;
	public readonly string envelopeeditoraLow = "0.00";
	public readonly string envelopeeditoraHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float envelopeoneshot = 0.0f;
	private float lastenvelopeoneshot = -1f;
	public readonly int envelopeoneshotIndex = 74;
	public readonly string envelopeoneshotLow = "0.00";
	public readonly string envelopeoneshotHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float envelopefixtemp = 0.0f;
	private float lastenvelopefixtemp = -1f;
	public readonly int envelopefixtempIndex = 75;
	public readonly string envelopefixtempLow = "0.00";
	public readonly string envelopefixtempHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float filterdrive = 0.0f;
	private float lastfilterdrive = -1f;
	public readonly int filterdriveIndex = 81;
	public readonly string filterdriveLow = "0.00";
	public readonly string filterdriveHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float delaywet = 0.0f;
	private float lastdelaywet = -1f;
	public readonly int delaywetIndex = 82;
	public readonly string delaywetLow = "0.00";
	public readonly string delaywetHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float delaytime = 0.5f;
	private float lastdelaytime = -1f;
	public readonly int delaytimeIndex = 83;
	public readonly string delaytimeLow = "0.00";
	public readonly string delaytimeHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float delaysync = 0.0f;
	private float lastdelaysync = -1f;
	public readonly int delaysyncIndex = 84;
	public readonly string delaysyncLow = "0.00";
	public readonly string delaysyncHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float delayfactorl = 0.0f;
	private float lastdelayfactorl = -1f;
	public readonly int delayfactorlIndex = 85;
	public readonly string delayfactorlLow = "0.00";
	public readonly string delayfactorlHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float delayfactorr = 0.0f;
	private float lastdelayfactorr = -1f;
	public readonly int delayfactorrIndex = 86;
	public readonly string delayfactorrLow = "0.00";
	public readonly string delayfactorrHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float delayhighshelf = 0.0f;
	private float lastdelayhighshelf = -1f;
	public readonly int delayhighshelfIndex = 87;
	public readonly string delayhighshelfLow = "0.00";
	public readonly string delayhighshelfHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float delaylowshelf = 0.0f;
	private float lastdelaylowshelf = -1f;
	public readonly int delaylowshelfIndex = 88;
	public readonly string delaylowshelfLow = "0.00";
	public readonly string delaylowshelfHigh = "1.00";

	[Tooltip("0.00  |  1.00")]
	[Range(0.0f, 1.0f)]
	public float delayfeedback = 0.5f;
	private float lastdelayfeedback = -1f;
	public readonly int delayfeedbackIndex = 89;
	public readonly string delayfeedbackLow = "0.00";
	public readonly string delayfeedbackHigh = "1.00";

	public override string getFilterName() {
		return "./vst/TAL-NoiseMaker.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(volume != lastvolume) isUpdated = true;
		if(filtertype != lastfiltertype) isUpdated = true;
		if(cutoff != lastcutoff) isUpdated = true;
		if(resonance != lastresonance) isUpdated = true;
		if(keyfollow != lastkeyfollow) isUpdated = true;
		if(filtercontour != lastfiltercontour) isUpdated = true;
		if(filterattack != lastfilterattack) isUpdated = true;
		if(filterdecay != lastfilterdecay) isUpdated = true;
		if(filtersustain != lastfiltersustain) isUpdated = true;
		if(filterrelease != lastfilterrelease) isUpdated = true;
		if(ampattack != lastampattack) isUpdated = true;
		if(ampdecay != lastampdecay) isUpdated = true;
		if(ampsustain != lastampsustain) isUpdated = true;
		if(amprelease != lastamprelease) isUpdated = true;
		if(osc1volume != lastosc1volume) isUpdated = true;
		if(osc2volume != lastosc2volume) isUpdated = true;
		if(osc3volume != lastosc3volume) isUpdated = true;
		if(oscmastertune != lastoscmastertune) isUpdated = true;
		if(osc1tune != lastosc1tune) isUpdated = true;
		if(osc2tune != lastosc2tune) isUpdated = true;
		if(osc1finetune != lastosc1finetune) isUpdated = true;
		if(osc2finetune != lastosc2finetune) isUpdated = true;
		if(osc1waveform != lastosc1waveform) isUpdated = true;
		if(osc2waveform != lastosc2waveform) isUpdated = true;
		if(oscsync != lastoscsync) isUpdated = true;
		if(lfo1waveform != lastlfo1waveform) isUpdated = true;
		if(lfo2waveform != lastlfo2waveform) isUpdated = true;
		if(lfo1rate != lastlfo1rate) isUpdated = true;
		if(lfo2rate != lastlfo2rate) isUpdated = true;
		if(lfo1amount != lastlfo1amount) isUpdated = true;
		if(lfo2amount != lastlfo2amount) isUpdated = true;
		if(lfo1destination != lastlfo1destination) isUpdated = true;
		if(lfo2destination != lastlfo2destination) isUpdated = true;
		if(lfo1phase != lastlfo1phase) isUpdated = true;
		if(lfo2phase != lastlfo2phase) isUpdated = true;
		if(osc2fm != lastosc2fm) isUpdated = true;
		if(osc2phase != lastosc2phase) isUpdated = true;
		if(osc1pw != lastosc1pw) isUpdated = true;
		if(osc1phase != lastosc1phase) isUpdated = true;
		if(transpose != lasttranspose) isUpdated = true;
		if(freeadattack != lastfreeadattack) isUpdated = true;
		if(freeaddecay != lastfreeaddecay) isUpdated = true;
		if(freeadamount != lastfreeadamount) isUpdated = true;
		if(freeaddestinati != lastfreeaddestinati) isUpdated = true;
		if(lfo1sync != lastlfo1sync) isUpdated = true;
		if(lfo1keytrigger != lastlfo1keytrigger) isUpdated = true;
		if(lfo2sync != lastlfo2sync) isUpdated = true;
		if(lfo2keytrigger != lastlfo2keytrigger) isUpdated = true;
		if(portamento != lastportamento) isUpdated = true;
		if(portamentomode != lastportamentomode) isUpdated = true;
		if(voices != lastvoices) isUpdated = true;
		if(velocityvolume != lastvelocityvolume) isUpdated = true;
		if(velocitycontour != lastvelocitycontour) isUpdated = true;
		if(velocitycutoff != lastvelocitycutoff) isUpdated = true;
		if(pitchwheelcutof != lastpitchwheelcutof) isUpdated = true;
		if(pitchwheelpitch != lastpitchwheelpitch) isUpdated = true;
		if(ringmodulation != lastringmodulation) isUpdated = true;
		if(chorus1enable != lastchorus1enable) isUpdated = true;
		if(chorus2enable != lastchorus2enable) isUpdated = true;
		if(reverbwet != lastreverbwet) isUpdated = true;
		if(reverbdecay != lastreverbdecay) isUpdated = true;
		if(reverbpredelay != lastreverbpredelay) isUpdated = true;
		if(reverbhighcut != lastreverbhighcut) isUpdated = true;
		if(reverblowcut != lastreverblowcut) isUpdated = true;
		if(oscbitcrusher != lastoscbitcrusher) isUpdated = true;
		if(highpass != lasthighpass) isUpdated = true;
		if(detune != lastdetune) isUpdated = true;
		if(vintagenoise != lastvintagenoise) isUpdated = true;
		if(envelopeeditord != lastenvelopeeditord) isUpdated = true;
		if(envelopeeditors != lastenvelopeeditors) isUpdated = true;
		if(envelopeeditora != lastenvelopeeditora) isUpdated = true;
		if(envelopeoneshot != lastenvelopeoneshot) isUpdated = true;
		if(envelopefixtemp != lastenvelopefixtemp) isUpdated = true;
		if(filterdrive != lastfilterdrive) isUpdated = true;
		if(delaywet != lastdelaywet) isUpdated = true;
		if(delaytime != lastdelaytime) isUpdated = true;
		if(delaysync != lastdelaysync) isUpdated = true;
		if(delayfactorl != lastdelayfactorl) isUpdated = true;
		if(delayfactorr != lastdelayfactorr) isUpdated = true;
		if(delayhighshelf != lastdelayhighshelf) isUpdated = true;
		if(delaylowshelf != lastdelaylowshelf) isUpdated = true;
		if(delayfeedback != lastdelayfeedback) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/TAL-NoiseMaker.dll");
		if(volume != lastvolume) {
			client.sendPacket("parameter 1 "+volume);
			lastvolume = volume;
		}
		if(filtertype != lastfiltertype) {
			client.sendPacket("parameter 2 "+filtertype);
			lastfiltertype = filtertype;
		}
		if(cutoff != lastcutoff) {
			client.sendPacket("parameter 3 "+cutoff);
			lastcutoff = cutoff;
		}
		if(resonance != lastresonance) {
			client.sendPacket("parameter 4 "+resonance);
			lastresonance = resonance;
		}
		if(keyfollow != lastkeyfollow) {
			client.sendPacket("parameter 5 "+keyfollow);
			lastkeyfollow = keyfollow;
		}
		if(filtercontour != lastfiltercontour) {
			client.sendPacket("parameter 6 "+filtercontour);
			lastfiltercontour = filtercontour;
		}
		if(filterattack != lastfilterattack) {
			client.sendPacket("parameter 7 "+filterattack);
			lastfilterattack = filterattack;
		}
		if(filterdecay != lastfilterdecay) {
			client.sendPacket("parameter 8 "+filterdecay);
			lastfilterdecay = filterdecay;
		}
		if(filtersustain != lastfiltersustain) {
			client.sendPacket("parameter 9 "+filtersustain);
			lastfiltersustain = filtersustain;
		}
		if(filterrelease != lastfilterrelease) {
			client.sendPacket("parameter 10 "+filterrelease);
			lastfilterrelease = filterrelease;
		}
		if(ampattack != lastampattack) {
			client.sendPacket("parameter 11 "+ampattack);
			lastampattack = ampattack;
		}
		if(ampdecay != lastampdecay) {
			client.sendPacket("parameter 12 "+ampdecay);
			lastampdecay = ampdecay;
		}
		if(ampsustain != lastampsustain) {
			client.sendPacket("parameter 13 "+ampsustain);
			lastampsustain = ampsustain;
		}
		if(amprelease != lastamprelease) {
			client.sendPacket("parameter 14 "+amprelease);
			lastamprelease = amprelease;
		}
		if(osc1volume != lastosc1volume) {
			client.sendPacket("parameter 15 "+osc1volume);
			lastosc1volume = osc1volume;
		}
		if(osc2volume != lastosc2volume) {
			client.sendPacket("parameter 16 "+osc2volume);
			lastosc2volume = osc2volume;
		}
		if(osc3volume != lastosc3volume) {
			client.sendPacket("parameter 17 "+osc3volume);
			lastosc3volume = osc3volume;
		}
		if(oscmastertune != lastoscmastertune) {
			client.sendPacket("parameter 18 "+oscmastertune);
			lastoscmastertune = oscmastertune;
		}
		if(osc1tune != lastosc1tune) {
			client.sendPacket("parameter 19 "+osc1tune);
			lastosc1tune = osc1tune;
		}
		if(osc2tune != lastosc2tune) {
			client.sendPacket("parameter 20 "+osc2tune);
			lastosc2tune = osc2tune;
		}
		if(osc1finetune != lastosc1finetune) {
			client.sendPacket("parameter 21 "+osc1finetune);
			lastosc1finetune = osc1finetune;
		}
		if(osc2finetune != lastosc2finetune) {
			client.sendPacket("parameter 22 "+osc2finetune);
			lastosc2finetune = osc2finetune;
		}
		if(osc1waveform != lastosc1waveform) {
			client.sendPacket("parameter 23 "+osc1waveform);
			lastosc1waveform = osc1waveform;
		}
		if(osc2waveform != lastosc2waveform) {
			client.sendPacket("parameter 24 "+osc2waveform);
			lastosc2waveform = osc2waveform;
		}
		if(oscsync != lastoscsync) {
			client.sendPacket("parameter 25 "+oscsync);
			lastoscsync = oscsync;
		}
		if(lfo1waveform != lastlfo1waveform) {
			client.sendPacket("parameter 26 "+lfo1waveform);
			lastlfo1waveform = lfo1waveform;
		}
		if(lfo2waveform != lastlfo2waveform) {
			client.sendPacket("parameter 27 "+lfo2waveform);
			lastlfo2waveform = lfo2waveform;
		}
		if(lfo1rate != lastlfo1rate) {
			client.sendPacket("parameter 28 "+lfo1rate);
			lastlfo1rate = lfo1rate;
		}
		if(lfo2rate != lastlfo2rate) {
			client.sendPacket("parameter 29 "+lfo2rate);
			lastlfo2rate = lfo2rate;
		}
		if(lfo1amount != lastlfo1amount) {
			client.sendPacket("parameter 30 "+lfo1amount);
			lastlfo1amount = lfo1amount;
		}
		if(lfo2amount != lastlfo2amount) {
			client.sendPacket("parameter 31 "+lfo2amount);
			lastlfo2amount = lfo2amount;
		}
		if(lfo1destination != lastlfo1destination) {
			client.sendPacket("parameter 32 "+lfo1destination);
			lastlfo1destination = lfo1destination;
		}
		if(lfo2destination != lastlfo2destination) {
			client.sendPacket("parameter 33 "+lfo2destination);
			lastlfo2destination = lfo2destination;
		}
		if(lfo1phase != lastlfo1phase) {
			client.sendPacket("parameter 34 "+lfo1phase);
			lastlfo1phase = lfo1phase;
		}
		if(lfo2phase != lastlfo2phase) {
			client.sendPacket("parameter 35 "+lfo2phase);
			lastlfo2phase = lfo2phase;
		}
		if(osc2fm != lastosc2fm) {
			client.sendPacket("parameter 36 "+osc2fm);
			lastosc2fm = osc2fm;
		}
		if(osc2phase != lastosc2phase) {
			client.sendPacket("parameter 37 "+osc2phase);
			lastosc2phase = osc2phase;
		}
		if(osc1pw != lastosc1pw) {
			client.sendPacket("parameter 38 "+osc1pw);
			lastosc1pw = osc1pw;
		}
		if(osc1phase != lastosc1phase) {
			client.sendPacket("parameter 39 "+osc1phase);
			lastosc1phase = osc1phase;
		}
		if(transpose != lasttranspose) {
			client.sendPacket("parameter 40 "+transpose);
			lasttranspose = transpose;
		}
		if(freeadattack != lastfreeadattack) {
			client.sendPacket("parameter 41 "+freeadattack);
			lastfreeadattack = freeadattack;
		}
		if(freeaddecay != lastfreeaddecay) {
			client.sendPacket("parameter 42 "+freeaddecay);
			lastfreeaddecay = freeaddecay;
		}
		if(freeadamount != lastfreeadamount) {
			client.sendPacket("parameter 43 "+freeadamount);
			lastfreeadamount = freeadamount;
		}
		if(freeaddestinati != lastfreeaddestinati) {
			client.sendPacket("parameter 44 "+freeaddestinati);
			lastfreeaddestinati = freeaddestinati;
		}
		if(lfo1sync != lastlfo1sync) {
			client.sendPacket("parameter 45 "+lfo1sync);
			lastlfo1sync = lfo1sync;
		}
		if(lfo1keytrigger != lastlfo1keytrigger) {
			client.sendPacket("parameter 46 "+lfo1keytrigger);
			lastlfo1keytrigger = lfo1keytrigger;
		}
		if(lfo2sync != lastlfo2sync) {
			client.sendPacket("parameter 47 "+lfo2sync);
			lastlfo2sync = lfo2sync;
		}
		if(lfo2keytrigger != lastlfo2keytrigger) {
			client.sendPacket("parameter 48 "+lfo2keytrigger);
			lastlfo2keytrigger = lfo2keytrigger;
		}
		if(portamento != lastportamento) {
			client.sendPacket("parameter 49 "+portamento);
			lastportamento = portamento;
		}
		if(portamentomode != lastportamentomode) {
			client.sendPacket("parameter 50 "+portamentomode);
			lastportamentomode = portamentomode;
		}
		if(voices != lastvoices) {
			client.sendPacket("parameter 51 "+voices);
			lastvoices = voices;
		}
		if(velocityvolume != lastvelocityvolume) {
			client.sendPacket("parameter 52 "+velocityvolume);
			lastvelocityvolume = velocityvolume;
		}
		if(velocitycontour != lastvelocitycontour) {
			client.sendPacket("parameter 53 "+velocitycontour);
			lastvelocitycontour = velocitycontour;
		}
		if(velocitycutoff != lastvelocitycutoff) {
			client.sendPacket("parameter 54 "+velocitycutoff);
			lastvelocitycutoff = velocitycutoff;
		}
		if(pitchwheelcutof != lastpitchwheelcutof) {
			client.sendPacket("parameter 55 "+pitchwheelcutof);
			lastpitchwheelcutof = pitchwheelcutof;
		}
		if(pitchwheelpitch != lastpitchwheelpitch) {
			client.sendPacket("parameter 56 "+pitchwheelpitch);
			lastpitchwheelpitch = pitchwheelpitch;
		}
		if(ringmodulation != lastringmodulation) {
			client.sendPacket("parameter 57 "+ringmodulation);
			lastringmodulation = ringmodulation;
		}
		if(chorus1enable != lastchorus1enable) {
			client.sendPacket("parameter 58 "+chorus1enable);
			lastchorus1enable = chorus1enable;
		}
		if(chorus2enable != lastchorus2enable) {
			client.sendPacket("parameter 59 "+chorus2enable);
			lastchorus2enable = chorus2enable;
		}
		if(reverbwet != lastreverbwet) {
			client.sendPacket("parameter 60 "+reverbwet);
			lastreverbwet = reverbwet;
		}
		if(reverbdecay != lastreverbdecay) {
			client.sendPacket("parameter 61 "+reverbdecay);
			lastreverbdecay = reverbdecay;
		}
		if(reverbpredelay != lastreverbpredelay) {
			client.sendPacket("parameter 62 "+reverbpredelay);
			lastreverbpredelay = reverbpredelay;
		}
		if(reverbhighcut != lastreverbhighcut) {
			client.sendPacket("parameter 63 "+reverbhighcut);
			lastreverbhighcut = reverbhighcut;
		}
		if(reverblowcut != lastreverblowcut) {
			client.sendPacket("parameter 64 "+reverblowcut);
			lastreverblowcut = reverblowcut;
		}
		if(oscbitcrusher != lastoscbitcrusher) {
			client.sendPacket("parameter 65 "+oscbitcrusher);
			lastoscbitcrusher = oscbitcrusher;
		}
		if(highpass != lasthighpass) {
			client.sendPacket("parameter 66 "+highpass);
			lasthighpass = highpass;
		}
		if(detune != lastdetune) {
			client.sendPacket("parameter 67 "+detune);
			lastdetune = detune;
		}
		if(vintagenoise != lastvintagenoise) {
			client.sendPacket("parameter 68 "+vintagenoise);
			lastvintagenoise = vintagenoise;
		}
		if(envelopeeditord != lastenvelopeeditord) {
			client.sendPacket("parameter 71 "+envelopeeditord);
			lastenvelopeeditord = envelopeeditord;
		}
		if(envelopeeditors != lastenvelopeeditors) {
			client.sendPacket("parameter 72 "+envelopeeditors);
			lastenvelopeeditors = envelopeeditors;
		}
		if(envelopeeditora != lastenvelopeeditora) {
			client.sendPacket("parameter 73 "+envelopeeditora);
			lastenvelopeeditora = envelopeeditora;
		}
		if(envelopeoneshot != lastenvelopeoneshot) {
			client.sendPacket("parameter 74 "+envelopeoneshot);
			lastenvelopeoneshot = envelopeoneshot;
		}
		if(envelopefixtemp != lastenvelopefixtemp) {
			client.sendPacket("parameter 75 "+envelopefixtemp);
			lastenvelopefixtemp = envelopefixtemp;
		}
		if(filterdrive != lastfilterdrive) {
			client.sendPacket("parameter 81 "+filterdrive);
			lastfilterdrive = filterdrive;
		}
		if(delaywet != lastdelaywet) {
			client.sendPacket("parameter 82 "+delaywet);
			lastdelaywet = delaywet;
		}
		if(delaytime != lastdelaytime) {
			client.sendPacket("parameter 83 "+delaytime);
			lastdelaytime = delaytime;
		}
		if(delaysync != lastdelaysync) {
			client.sendPacket("parameter 84 "+delaysync);
			lastdelaysync = delaysync;
		}
		if(delayfactorl != lastdelayfactorl) {
			client.sendPacket("parameter 85 "+delayfactorl);
			lastdelayfactorl = delayfactorl;
		}
		if(delayfactorr != lastdelayfactorr) {
			client.sendPacket("parameter 86 "+delayfactorr);
			lastdelayfactorr = delayfactorr;
		}
		if(delayhighshelf != lastdelayhighshelf) {
			client.sendPacket("parameter 87 "+delayhighshelf);
			lastdelayhighshelf = delayhighshelf;
		}
		if(delaylowshelf != lastdelaylowshelf) {
			client.sendPacket("parameter 88 "+delaylowshelf);
			lastdelaylowshelf = delaylowshelf;
		}
		if(delayfeedback != lastdelayfeedback) {
			client.sendPacket("parameter 89 "+delayfeedback);
			lastdelayfeedback = delayfeedback;
		}
	}

	public override void resetStateTrackers() {
		lastvolume = -1f;
		lastfiltertype = -1f;
		lastcutoff = -1f;
		lastresonance = -1f;
		lastkeyfollow = -1f;
		lastfiltercontour = -1f;
		lastfilterattack = -1f;
		lastfilterdecay = -1f;
		lastfiltersustain = -1f;
		lastfilterrelease = -1f;
		lastampattack = -1f;
		lastampdecay = -1f;
		lastampsustain = -1f;
		lastamprelease = -1f;
		lastosc1volume = -1f;
		lastosc2volume = -1f;
		lastosc3volume = -1f;
		lastoscmastertune = -1f;
		lastosc1tune = -1f;
		lastosc2tune = -1f;
		lastosc1finetune = -1f;
		lastosc2finetune = -1f;
		lastosc1waveform = -1f;
		lastosc2waveform = -1f;
		lastoscsync = -1f;
		lastlfo1waveform = -1f;
		lastlfo2waveform = -1f;
		lastlfo1rate = -1f;
		lastlfo2rate = -1f;
		lastlfo1amount = -1f;
		lastlfo2amount = -1f;
		lastlfo1destination = -1f;
		lastlfo2destination = -1f;
		lastlfo1phase = -1f;
		lastlfo2phase = -1f;
		lastosc2fm = -1f;
		lastosc2phase = -1f;
		lastosc1pw = -1f;
		lastosc1phase = -1f;
		lasttranspose = -1f;
		lastfreeadattack = -1f;
		lastfreeaddecay = -1f;
		lastfreeadamount = -1f;
		lastfreeaddestinati = -1f;
		lastlfo1sync = -1f;
		lastlfo1keytrigger = -1f;
		lastlfo2sync = -1f;
		lastlfo2keytrigger = -1f;
		lastportamento = -1f;
		lastportamentomode = -1f;
		lastvoices = -1f;
		lastvelocityvolume = -1f;
		lastvelocitycontour = -1f;
		lastvelocitycutoff = -1f;
		lastpitchwheelcutof = -1f;
		lastpitchwheelpitch = -1f;
		lastringmodulation = -1f;
		lastchorus1enable = -1f;
		lastchorus2enable = -1f;
		lastreverbwet = -1f;
		lastreverbdecay = -1f;
		lastreverbpredelay = -1f;
		lastreverbhighcut = -1f;
		lastreverblowcut = -1f;
		lastoscbitcrusher = -1f;
		lasthighpass = -1f;
		lastdetune = -1f;
		lastvintagenoise = -1f;
		lastenvelopeeditord = -1f;
		lastenvelopeeditors = -1f;
		lastenvelopeeditora = -1f;
		lastenvelopeoneshot = -1f;
		lastenvelopefixtemp = -1f;
		lastfilterdrive = -1f;
		lastdelaywet = -1f;
		lastdelaytime = -1f;
		lastdelaysync = -1f;
		lastdelayfactorl = -1f;
		lastdelayfactorr = -1f;
		lastdelayhighshelf = -1f;
		lastdelaylowshelf = -1f;
		lastdelayfeedback = -1f;
	}
}
