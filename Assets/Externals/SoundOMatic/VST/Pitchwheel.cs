using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Filters/Pitchwheel")]
public class Pitchwheel : VSTFilter {

	public readonly string pluginPath = "Pitchwheel.dll";

	public override void resetToDefaults() {
		PicthWheel = 0.5f;
		Mix = 1.0f;
		Smooth = 0.5f;
		Inertia = 0.5f;
		gravity = 1.0f;
		internal1 = 0.0f;
		Range = 0.71428573f;
		Snap = 1.0f;
		KeyOrig = 0.48979592f;
		KeyConst = 0.1875f;
		Preserveformants = 0.0f;
		Constanton = 1.0f;
		TimbreWheel = 0.5f;
		Smoothtimbre = 0.5f;
		Inertiatimbre = 0.5f;
		Gravitytimbre = 1.0f;
		Lockwheels = 0.0f;
		Snaptimbre = 1.0f;
	}

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float PicthWheel = 0.5f;
	private float lastPicthWheel = -1f;
	public readonly int PicthWheelIndex = 0;
	public readonly string PicthWheelLow = "amount";
	public readonly string PicthWheelHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Mix = 1.0f;
	private float lastMix = -1f;
	public readonly int MixIndex = 1;
	public readonly string MixLow = "amount";
	public readonly string MixHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Smooth = 0.5f;
	private float lastSmooth = -1f;
	public readonly int SmoothIndex = 2;
	public readonly string SmoothLow = "amount";
	public readonly string SmoothHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Inertia = 0.5f;
	private float lastInertia = -1f;
	public readonly int InertiaIndex = 3;
	public readonly string InertiaLow = "amount";
	public readonly string InertiaHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float gravity = 1.0f;
	private float lastgravity = -1f;
	public readonly int gravityIndex = 4;
	public readonly string gravityLow = "amount";
	public readonly string gravityHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float internal1 = 0.0f;
	private float lastinternal1 = -1f;
	public readonly int internal1Index = 5;
	public readonly string internal1Low = "amount";
	public readonly string internal1High = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Range = 0.71428573f;
	private float lastRange = -1f;
	public readonly int RangeIndex = 6;
	public readonly string RangeLow = "amount";
	public readonly string RangeHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Snap = 1.0f;
	private float lastSnap = -1f;
	public readonly int SnapIndex = 7;
	public readonly string SnapLow = "amount";
	public readonly string SnapHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float KeyOrig = 0.48979592f;
	private float lastKeyOrig = -1f;
	public readonly int KeyOrigIndex = 8;
	public readonly string KeyOrigLow = "amount";
	public readonly string KeyOrigHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float KeyConst = 0.1875f;
	private float lastKeyConst = -1f;
	public readonly int KeyConstIndex = 9;
	public readonly string KeyConstLow = "amount";
	public readonly string KeyConstHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Preserveformants = 0.0f;
	private float lastPreserveformants = -1f;
	public readonly int PreserveformantsIndex = 10;
	public readonly string PreserveformantsLow = "amount";
	public readonly string PreserveformantsHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Constanton = 1.0f;
	private float lastConstanton = -1f;
	public readonly int ConstantonIndex = 11;
	public readonly string ConstantonLow = "amount";
	public readonly string ConstantonHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float TimbreWheel = 0.5f;
	private float lastTimbreWheel = -1f;
	public readonly int TimbreWheelIndex = 12;
	public readonly string TimbreWheelLow = "amount";
	public readonly string TimbreWheelHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Smoothtimbre = 0.5f;
	private float lastSmoothtimbre = -1f;
	public readonly int SmoothtimbreIndex = 13;
	public readonly string SmoothtimbreLow = "amount";
	public readonly string SmoothtimbreHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Inertiatimbre = 0.5f;
	private float lastInertiatimbre = -1f;
	public readonly int InertiatimbreIndex = 14;
	public readonly string InertiatimbreLow = "amount";
	public readonly string InertiatimbreHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Gravitytimbre = 1.0f;
	private float lastGravitytimbre = -1f;
	public readonly int GravitytimbreIndex = 15;
	public readonly string GravitytimbreLow = "amount";
	public readonly string GravitytimbreHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Lockwheels = 0.0f;
	private float lastLockwheels = -1f;
	public readonly int LockwheelsIndex = 16;
	public readonly string LockwheelsLow = "amount";
	public readonly string LockwheelsHigh = "amount";

	[Tooltip("amount  |  amount")]
	[Range(0.0f, 1.0f)]
	public float Snaptimbre = 1.0f;
	private float lastSnaptimbre = -1f;
	public readonly int SnaptimbreIndex = 17;
	public readonly string SnaptimbreLow = "amount";
	public readonly string SnaptimbreHigh = "amount";

	public override string getFilterName() {
		return "./vst/Pitchwheel.dll";
	}
	public override bool hasUpdate() {
		bool isUpdated = false;
		if(PicthWheel != lastPicthWheel) isUpdated = true;
		if(Mix != lastMix) isUpdated = true;
		if(Smooth != lastSmooth) isUpdated = true;
		if(Inertia != lastInertia) isUpdated = true;
		if(gravity != lastgravity) isUpdated = true;
		if(internal1 != lastinternal1) isUpdated = true;
		if(Range != lastRange) isUpdated = true;
		if(Snap != lastSnap) isUpdated = true;
		if(KeyOrig != lastKeyOrig) isUpdated = true;
		if(KeyConst != lastKeyConst) isUpdated = true;
		if(Preserveformants != lastPreserveformants) isUpdated = true;
		if(Constanton != lastConstanton) isUpdated = true;
		if(TimbreWheel != lastTimbreWheel) isUpdated = true;
		if(Smoothtimbre != lastSmoothtimbre) isUpdated = true;
		if(Inertiatimbre != lastInertiatimbre) isUpdated = true;
		if(Gravitytimbre != lastGravitytimbre) isUpdated = true;
		if(Lockwheels != lastLockwheels) isUpdated = true;
		if(Snaptimbre != lastSnaptimbre) isUpdated = true;

		return isUpdated;
	}

	public override void sendUpdate(SoundOMaticClient client) {
		client.sendPacket("filterName ./vst/Pitchwheel.dll");
		if(PicthWheel != lastPicthWheel) {
			client.sendPacket("parameter 0 "+PicthWheel);
			lastPicthWheel = PicthWheel;
		}
		if(Mix != lastMix) {
			client.sendPacket("parameter 1 "+Mix);
			lastMix = Mix;
		}
		if(Smooth != lastSmooth) {
			client.sendPacket("parameter 2 "+Smooth);
			lastSmooth = Smooth;
		}
		if(Inertia != lastInertia) {
			client.sendPacket("parameter 3 "+Inertia);
			lastInertia = Inertia;
		}
		if(gravity != lastgravity) {
			client.sendPacket("parameter 4 "+gravity);
			lastgravity = gravity;
		}
		if(internal1 != lastinternal1) {
			client.sendPacket("parameter 5 "+internal1);
			lastinternal1 = internal1;
		}
		if(Range != lastRange) {
			client.sendPacket("parameter 6 "+Range);
			lastRange = Range;
		}
		if(Snap != lastSnap) {
			client.sendPacket("parameter 7 "+Snap);
			lastSnap = Snap;
		}
		if(KeyOrig != lastKeyOrig) {
			client.sendPacket("parameter 8 "+KeyOrig);
			lastKeyOrig = KeyOrig;
		}
		if(KeyConst != lastKeyConst) {
			client.sendPacket("parameter 9 "+KeyConst);
			lastKeyConst = KeyConst;
		}
		if(Preserveformants != lastPreserveformants) {
			client.sendPacket("parameter 10 "+Preserveformants);
			lastPreserveformants = Preserveformants;
		}
		if(Constanton != lastConstanton) {
			client.sendPacket("parameter 11 "+Constanton);
			lastConstanton = Constanton;
		}
		if(TimbreWheel != lastTimbreWheel) {
			client.sendPacket("parameter 12 "+TimbreWheel);
			lastTimbreWheel = TimbreWheel;
		}
		if(Smoothtimbre != lastSmoothtimbre) {
			client.sendPacket("parameter 13 "+Smoothtimbre);
			lastSmoothtimbre = Smoothtimbre;
		}
		if(Inertiatimbre != lastInertiatimbre) {
			client.sendPacket("parameter 14 "+Inertiatimbre);
			lastInertiatimbre = Inertiatimbre;
		}
		if(Gravitytimbre != lastGravitytimbre) {
			client.sendPacket("parameter 15 "+Gravitytimbre);
			lastGravitytimbre = Gravitytimbre;
		}
		if(Lockwheels != lastLockwheels) {
			client.sendPacket("parameter 16 "+Lockwheels);
			lastLockwheels = Lockwheels;
		}
		if(Snaptimbre != lastSnaptimbre) {
			client.sendPacket("parameter 17 "+Snaptimbre);
			lastSnaptimbre = Snaptimbre;
		}
	}

	public override void resetStateTrackers() {
		lastPicthWheel = -1f;
		lastMix = -1f;
		lastSmooth = -1f;
		lastInertia = -1f;
		lastgravity = -1f;
		lastinternal1 = -1f;
		lastRange = -1f;
		lastSnap = -1f;
		lastKeyOrig = -1f;
		lastKeyConst = -1f;
		lastPreserveformants = -1f;
		lastConstanton = -1f;
		lastTimbreWheel = -1f;
		lastSmoothtimbre = -1f;
		lastInertiatimbre = -1f;
		lastGravitytimbre = -1f;
		lastLockwheels = -1f;
		lastSnaptimbre = -1f;
	}
}
