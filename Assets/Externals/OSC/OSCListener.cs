using UnityEngine;
using System.Collections;

public interface OSCListener {
	void onOSCMessage(string address, ArrayList arguments);
}
