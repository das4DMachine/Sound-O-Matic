using UnityEngine;

public abstract class VSTFilter : Identifiable {
	public abstract bool hasUpdate();
	
	public abstract void sendUpdate(SoundOMaticClient client);

	public abstract void resetStateTrackers();
	
	public abstract void resetToDefaults();
	
	public abstract string getFilterName();
}