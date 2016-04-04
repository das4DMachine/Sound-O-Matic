using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OSC.NET;

public class OSCPort : MonoBehaviour {
	private bool connected = false;
	private OSCReceiver receiver;
	private Thread thread;
	private Dictionary<String,HashSet<OSCListener>> messageListeners = new Dictionary<String, HashSet<OSCListener>>();
	public int port = 3333;
	public bool allowAutodetect = true; // Whether things are allowed to autodetect this port
	
	public void OnEnable(){
		connect();
	}
	
	public void OnDisable(){
		disconnect();
	}
	
	public int getPort(){
		return port;
	}
	public bool shouldWarnIfAutodetected(){
		return !allowAutodetect;
	}

	public void connect() {
		lock(this){
			if (!connected){
				try {
					receiver = new OSCReceiver(port);
					thread = new Thread(new ThreadStart(listen));
					connected = true;
					thread.Start();
				} catch (Exception e) {
					Console.WriteLine("failed to connect to port "+port);
					Console.WriteLine(e.Message);
				}
			}
		}
	}

	public void disconnect() {
		lock (this){
			connected = false;

			if (receiver!=null){
				receiver.Close();
			}
			receiver = null;

			if (thread!=null){ 
				thread.Abort(); 
			}
			thread = null;				
		}
	}

	public bool isConnected() { return connected; }

	private void listen() {
		Debug.Log("OSC listener started on "+port);
		while(connected) {
			try {
				OSCPacket packet = receiver.Receive();
				if (packet!=null) {
					if (packet.IsBundle()) {
						ArrayList messages = packet.Values;
						for (int i=0; i<messages.Count; i++) {
							processMessage((OSCMessage)messages[i]);
						}
					} else processMessage((OSCMessage)packet);
				} else Console.WriteLine("null packet");
			} catch (Exception e) { Console.WriteLine(e.Message); }
		}
		Debug.Log("OSC listener died");
	}

	public void addListener(string addressPrefix, OSCListener listener){
		lock(this){
			if (!messageListeners.ContainsKey(addressPrefix)){
				messageListeners.Add(addressPrefix, new HashSet<OSCListener>());
			}
			messageListeners[addressPrefix].Add(listener);
		}
	}
	
	public void removeListener(OSCListener listener){
		lock(this){
			foreach (KeyValuePair<string, HashSet<OSCListener>> entry in messageListeners){
				entry.Value.Remove(listener);
			}
		}
		// Notice: empty hashsets are not removed. Only a memory leak if you de-register a lot
		// of random addressPrefixes - which is really a weird thing
	}
	
	private void processMessage(OSCMessage message){ 
		lock(this){
			foreach (KeyValuePair<string, HashSet<OSCListener>> entry in messageListeners){
				if (message.Address.StartsWith(entry.Key)){
					// Notify all listeners
					foreach (OSCListener listener in entry.Value){
						listener.onOSCMessage(message.Address, message.Values);
					}
				}
			}
		}
	}
}