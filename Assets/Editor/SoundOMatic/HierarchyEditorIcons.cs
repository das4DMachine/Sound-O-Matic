using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
 
[InitializeOnLoad]
class HierarchyEditorIcon {
    static Texture2D playingTexture;
    static Texture2D silentTexture;
    static List<int> playingAudioNodes;
    static List<int> silentAudioNodes;
	 
    static HierarchyEditorIcon() {
        playingTexture = AssetDatabase.LoadAssetAtPath ("Assets/Gizmos/speaker.png", typeof(Texture2D)) as Texture2D;
        silentTexture = AssetDatabase.LoadAssetAtPath ("Assets/Gizmos/speaker_muted.png", typeof(Texture2D)) as Texture2D;

        EditorApplication.update += UpdateCallback;
        EditorApplication.hierarchyWindowItemOnGUI += HierarchyItemOnGUI;
		
		playingAudioNodes = new List<int>();
		silentAudioNodes = new List<int>();
    }
 
    static void UpdateCallback () {
        AudioNode[] nodes = Object.FindObjectsOfType (typeof(AudioNode)) as AudioNode[];
		
		playingAudioNodes.Clear();
		silentAudioNodes.Clear();
        foreach (AudioNode g in nodes) {
            if (g.play){
                playingAudioNodes.Add(g.gameObject.GetInstanceID());
			} else {
				silentAudioNodes.Add(g.gameObject.GetInstanceID());
			}
        }
    }
 
    static void HierarchyItemOnGUI (int instanceID, Rect selectionRect) {
        Rect r = new Rect (selectionRect); 
        r.x = r.width - 15;
        r.width = 18;
 
        if (playingAudioNodes.Contains (instanceID)) {
            GUI.Label (r, playingTexture); 
        } else if(silentAudioNodes.Contains (instanceID)) {
            GUI.Label (r, silentTexture); 
		}
    }
 
}