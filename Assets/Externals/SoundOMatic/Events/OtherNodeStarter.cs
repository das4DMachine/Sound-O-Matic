using UnityEngine;
using System.Collections;

[AddComponentMenu("Starters/Other Node")]
public class OtherNodeStarter : Starter {
	public AudioNode starterNode;
    public int delay = 0;

    private bool shouldTrigger;

	public void OnEnable(){
        shouldTrigger = false;
        starterNode.playStateChanged += onOtherNodeStarted;
	}
	
	public void OnDisable(){
        shouldTrigger = false;
		starterNode.playStateChanged -= onOtherNodeStarted;
	}

    public void onOtherNodeStarted()
    {
		if (starterNode.play){
            if (delay > 0)
            {
                //Call trigger after delay seconds
                new System.Threading.Timer(this.doTrigger, null, delay * 1000, System.Threading.Timeout.Infinite);
            }
            else
            {
                trigger();
            }
		} else {
			// We ignore stops
		}
	}

    public void doTrigger(System.Object state)
    {
        shouldTrigger = true;
    }

	public override void Update(){
		base.Update();
        if (shouldTrigger)
        {
            shouldTrigger = false;
            trigger();
        }
	}
}
