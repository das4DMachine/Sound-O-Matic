#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Xml;

[ExecuteInEditMode]
public class SoundOMaticClient : MonoBehaviour {
	private string versionString = "v.15.2.27";
	public int port = 1337+1;
	public string host = "";

    public string soundbaseUsername = "user";
    public string soundbasePassword = "pass";
    public string soundbaseUrl = "http://";

	public string[] layers = new string[1]{"default"};

	[Tooltip("0 gain |  2x gain")]
	[Range(0.0f, 2.0f)]
	public float masterGain = 1f;
	private float masterGainOld = -1f;

	private bool clientInitialized = false;
	private TcpClient tcpClient;
	private StreamWriter writer;
	private StreamReader reader;
	private long lastConnectionTimestamp = 0;
	private long reconnectInterval = 1 * 10000000; // Ticks between re-connection attempts

	void initializeConnection(){
		int connectTimeout = 250;
		int liveTimeout = 2500;

#if !UNITY_IOS
		Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
#endif
		
		if (tcpClient!=null) {
			shutdownConnection();
		}
		
		// Async start the connection process
		tcpClient = new TcpClient();
		System.IAsyncResult asyncResult = tcpClient.BeginConnect(host, port, null, null);
		System.Threading.WaitHandle handle = asyncResult.AsyncWaitHandle;
		try {
			asyncResult.AsyncWaitHandle.WaitOne(System.TimeSpan.FromMilliseconds(50));
			if (!tcpClient.Connected){
				tcpClient.Close();
				Debug.Log("Failed to connect to Sound-O-Matic server on "+host+":"+port, this);
				lastConnectionTimestamp = System.DateTime.UtcNow.Ticks;
				return; // We failed... too bad
			}
		} finally {
			handle.Close();
		}
		
		tcpClient.SendTimeout = connectTimeout;
		tcpClient.ReceiveTimeout = connectTimeout;
		tcpClient.SendBufferSize = 32 * 1024;
		Stream stream = tcpClient.GetStream();
        reader = new StreamReader(stream);
        writer = new StreamWriter(stream);
		writer.AutoFlush = false;
		writer.NewLine = "\n";
		clientInitialized = true;
		sendPacket("hi UnitySoundOMaticClient "+versionString);		
		flush ();

		// Check that we got the attention of the server by reading a line here, potentially timing out the connect process already
		string greeting = reader.ReadLine ();
		if (!greeting.StartsWith ("hi")) {
			// This is wrong, fail!
			shutdownConnection ();
			Debug.Log ("Network error: " + greeting, this);
			return;
		} else {
			// We have connection, set up reader thread
			ThreadStart threadDelegate = new ThreadStart(this.serverStreamParser);
			Thread newThread = new Thread(threadDelegate);
			newThread.Start();
		}

		// We are happy, server is happy, let's get going for real now!
		tcpClient.SendTimeout = liveTimeout;
		tcpClient.ReceiveTimeout = liveTimeout;
		sendPacket("# --------- Connection starting ----------");
#if UNITY_EDITOR
		sendPacket("# Scene: " + EditorApplication.currentScene);
#else
		sendPacket("# Scene: " + Application.loadedLevelName);
#endif

        //Set soundbase data
        sendPacket("soundbase " + soundbaseUsername + " " + soundbasePassword + " " + soundbaseUrl);

		// Prep the state trackers
		sendPacket("# Preparing state handlers...");		
		AudioNode[] nodes = GetComponentsInChildren<AudioNode>() as AudioNode[];
		Dictionary<string,int> filterCounter = new Dictionary<string,int>();
		Dictionary<int,int> audioCounter = new Dictionary<int,int>();
		int nodeCounter = 0;
		int filterTotalCounter = 0;
		foreach (AudioNode child in nodes){
			child.resetStateTrackers();
			if (child.getNodeTypeString()=="soundbase"){
				if (audioCounter.ContainsKey(child.audioIdentifier)){
					audioCounter[child.audioIdentifier]++;
				} else {
					audioCounter[child.audioIdentifier] = 1;
				}
			}

			VSTFilter[] childFilters = child.gameObject.GetComponents<VSTFilter>();
			foreach (VSTFilter filter in childFilters){
				if (filterCounter.ContainsKey(filter.getFilterName())){
					filterCounter[filter.getFilterName()]++;
				} else {
					filterCounter[filter.getFilterName()] = 1;
				}
				filterTotalCounter++;
			}
			nodeCounter++;
		}

		// Send preloading info		
		string preloadAudioString = "";
		bool firstComma = true;
		foreach (KeyValuePair<int,int> entry in audioCounter){
			if (firstComma) {
				firstComma = false;
			} else {
				preloadAudioString += ", ";
			}
			preloadAudioString += entry.Key+":"+entry.Value;
		}
		sendPacket("preloadAudio {"+preloadAudioString+"}");

		string preloadFiltersString = "";
		firstComma = true;
		foreach (KeyValuePair<string,int> entry in filterCounter){
			if (firstComma) {
				firstComma = false;
			} else {
				preloadFiltersString += ", ";
			}
			preloadFiltersString += entry.Key+":"+entry.Value;
		}
		sendPacket("preloadFilters {"+preloadFiltersString+"}");

		sendPacket("# "+nodeCounter+" AudioNodes prepared");		
		sendPacket("# "+filterTotalCounter+" VSTFilters prepared");		
		ListenerNode[] lNodes = Resources.FindObjectsOfTypeAll(typeof(ListenerNode)) as ListenerNode[];
		nodeCounter = 0;
		this.resetStateTrackers();
		foreach (ListenerNode child in lNodes){
			child.resetStateTrackers();
			nodeCounter++;
		}
		sendPacket("# "+nodeCounter+" ListenerNodes prepared");		
		sendPacket("# --------- Connection started -----------");

		Debug.Log("Connected to Sound-O-Matic server on "+host+":"+port, this);
	}

	void serverStreamParser(){
		while (reader!=null) {
			try {
				string message = reader.ReadLine ();
				if (message.StartsWith ("#")) {
					Debug.Log("Sound-O-Matic server says "+message);
				} else {
					// TODO: Handle it
				} 
			} catch (System.Exception ex){
				// This happens continously for each timeout
				if (ex==null) Debug.Log("This will never happen, but it makes the compiler not emit warnings about ex being unused");
			}
		}
		//Debug.Log ("Sound-O-Matic server processor has disconnected");
	}
	
	void shutdownConnection(){
		if (tcpClient!=null){
			clientInitialized = false;
			if (reader!=null){
				reader.Close();
				reader=null;
			}
			if (writer!=null){
				writer.Close();
				writer=null;
			}
			tcpClient.Close();
		}
	}
	
	void OnEnable(){
            initializeConnection();
	}
	
	void OnDisable(){
		shutdownConnection();
	}
	
	// Update is called once per change
	void Update () {
		try {
			if (clientInitialized && tcpClient!=null && tcpClient.Connected){
				if (masterGain!=masterGainOld){
					this.sendPacket("masterGain "+masterGain);
					masterGainOld = masterGain;
				}
				traverseAudioTree(this.gameObject);
			} else {
				if (System.DateTime.UtcNow.Ticks-lastConnectionTimestamp>reconnectInterval){
					initializeConnection();
				}
			}
		} catch (System.Exception e){
			Debug.Log("Disconnected from Sound-O-Matic server: "+e, this);
			shutdownConnection();
			lastConnectionTimestamp = System.DateTime.UtcNow.Ticks;
		}
	}
	
	void traverseAudioTree(GameObject topObject){
		// Remotely sync this level
		if (topObject.transform.childCount > 1) sendPacket("sync");
		
		foreach (Transform child in topObject.transform){ // Get immediate children
			GameObject childObject = child.gameObject;
			if (childObject.activeSelf){
				AudioNode audioNode = (AudioNode) childObject.GetComponent("AudioNode");
				ListenerNode listenerNode = (ListenerNode) childObject.GetComponent("ListenerNode");
				if (audioNode!=null){
					// Add to this level's command queue
					audioNode.sendUpdate(this);				
				} else if (listenerNode!=null){
					listenerNode.sendUpdate(this);
				} else {
					// Not an AudioNode, nothing to do				
				}
			}
		}
		// No remote sync is needed from here on
		if (topObject.transform.childCount > 1) sendPacket("unsync");
		
		// Traverse sub-trees
		foreach (Transform child in topObject.transform){
			GameObject childObject = child.gameObject;
			if (childObject.activeSelf){
				traverseAudioTree(childObject);
			}
		}		
		flush();
	}

	public void resetStateTrackers(){
		masterGainOld = -1f;
	}

	public void sendPacket(string data){
		if (writer!=null && clientInitialized){
			writer.WriteLine(data);
		}
	}
	void flush(){
		if (writer!=null && clientInitialized){
			writer.Flush();
		}
	}
	
	public string getUniqueName(Component caller){
		return caller.GetInstanceID () + "";
	}

#if UNITY_EDITOR
    public static T findCloseComponent<T>(GameObject child) where T : Component
    {
		Transform parent = child.transform.parent;
		while (parent != null) {
			T foundComponent = parent.GetComponent<T>();
		    if (foundComponent != null) {
			   return foundComponent;
		    }
		    parent = parent.transform.parent;
		}
		
		var prop = new HierarchyProperty(HierarchyType.GameObjects);
		var expanded = new int[0];
		while (prop.Next(expanded)) {
			T[] components = ((GameObject)prop.pptrValue).GetComponentsInChildren<T>();
			if (components.Length>0){
				return components[0];
			}
		}
				
		return null;
	}
	
	[MenuItem ("GameObject/SoundOMatic/Create AudioNode (SoundBase File)", false, 10)]
	public static void createNewAudioNode(){
		prepareNewAudioNode(new GameObject("Untitled AudioNode", typeof(AudioNode)));
	}
    [MenuItem("GameObject/SoundOMatic/Create AudioNode (Streaming)", false, 10)]
    public static void createNewStreamingAudioNode()
    {
        prepareNewAudioNode(new GameObject("Untitled StreamingNode", typeof(StreamAudioNode)));
    }
    [MenuItem ("GameObject/SoundOMatic/Create AudioNode (Sine Wave)", false, 10)]
	public static void createNewSineAudioNode(){
		prepareNewAudioNode(new GameObject("Untitled SineNode", typeof(SineWaveAudioNode)));
	}
	[MenuItem ("GameObject/SoundOMatic/Create AudioNode (Live Input)", false, 10)]
	public static void createNewLiveAudioNode(){
		prepareNewAudioNode(new GameObject("Untitled LiveNode", typeof(LiveAudioNode)));
	}

    [MenuItem ("GameObject/Load Listener Positions", false, 540)]
    public static void loadSpeakerPositions()
    {
        Debug.Log("Loading speakers!");
        string xmlPath = EditorUtility.OpenFilePanel("Listener Positions", "", "xml");

        if(xmlPath.Length != 0)
        {
            ListenerNode[] listenerNodes = FindObjectsOfType(typeof(ListenerNode)) as ListenerNode[];

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlPath);

            XmlNode docRoot = xmlDoc.DocumentElement;

            XmlNodeList nodeList = docRoot.SelectNodes("/speakers/speaker");
            for(int i = 0; i<nodeList.Count; i++)
            {
                XmlNode node = nodeList.Item(i);

                int channel = int.Parse(node.Attributes.GetNamedItem("channel").FirstChild.Value);

                Debug.Log(node.SelectSingleNode("position"));

                float x = float.Parse(node.SelectSingleNode("./position").Attributes.GetNamedItem("x").FirstChild.Value, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                float y = float.Parse(node.SelectSingleNode("./position").Attributes.GetNamedItem("y").FirstChild.Value, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                float z = float.Parse(node.SelectSingleNode("./position").Attributes.GetNamedItem("z").FirstChild.Value, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);

                ListenerNode foundNode = null;

                foreach (ListenerNode listenerNode in listenerNodes)
                {
                    if(listenerNode.channel == channel)
                    {
                        //Found listener
                        foundNode = listenerNode;
                        break;
                    }
                }

                if(foundNode == null)
                {
                    foundNode = createNewListenerNode();
                    foundNode.channel = channel;
                    foundNode.name = "ListenerNode " + channel;
                }

                foundNode.transform.position = new Vector3(x, y, z);
            }
        }
    }

	public static void prepareNewAudioNode(GameObject o){
		// Add it as child to whatever SoundOMatic hypernode is the first one
		SoundOMaticClient[] soundOMaticHyperNodes = FindObjectsOfType(typeof(SoundOMaticClient)) as SoundOMaticClient[];
		foreach (SoundOMaticClient hyperNode in soundOMaticHyperNodes){
            GameObjectUtility.SetParentAndAlign(o, hyperNode.gameObject);
            //o.transform.parent = hyperNode.transform;
			break;
		}

        Undo.RegisterCreatedObjectUndo(o, "Create " + o.name);

        // Select it
        Selection.activeObject = o;
	}
	
	[MenuItem ("GameObject/SoundOMatic/Create ListenerNode", false, 10)]
	public static ListenerNode createNewListenerNode(){
		GameObject o = new GameObject("Untitled ListenerNode", typeof(ListenerNode));
		
		// Add it as child to whatever SoundOMatic hypernode is the first one
		SoundOMaticClient[] soundOMaticHyperNodes = FindObjectsOfType(typeof(SoundOMaticClient)) as SoundOMaticClient[];
		foreach (SoundOMaticClient hyperNode in soundOMaticHyperNodes){
            GameObjectUtility.SetParentAndAlign(o, hyperNode.gameObject);
            //o.transform.parent = hyperNode.transform;
			break;
		}

        Undo.RegisterCreatedObjectUndo(o, "Create " + o.name);

        // Select it
        Selection.activeObject = o;

        return o.GetComponent<ListenerNode>();
	}	
#endif	

}
