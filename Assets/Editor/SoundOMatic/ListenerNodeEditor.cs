using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(ListenerNode))]
public class ListenerNodeEditor : Editor {		
	// Target target = target! - hidden field
	
    public override void OnInspectorGUI()
    {
		ListenerNode ourTarget = (ListenerNode) target;
        DrawDefaultInspector();

		// Layers
		SoundOMaticClient hyperNode = (SoundOMaticClient) SoundOMaticClient.findCloseComponent<SoundOMaticClient>(ourTarget.gameObject);		
		int mask = 0;
		foreach (int layer in ourTarget.getLayers()){
			mask |= 1<<layer;
		}
		mask = EditorGUILayout.MaskField ("Layers", mask, hyperNode.layers);
		ArrayList foundLayers = new ArrayList();		
		for (int layer = 0; layer < hyperNode.layers.Length; layer++){
			if ((mask & 1<<layer) == (1<<layer)){
				foundLayers.Add(layer);
			}
		}		
		ourTarget.setLayers((int[]) foundLayers.ToArray(typeof(int)));
		if (ourTarget.getLayers().Length > 1){
            string msg = "Choosen layers: ";
            bool first = true;
            foreach (int layer in ourTarget.getLayers())
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    msg += ", ";
                }
                msg += hyperNode.layers[layer];
            }
            EditorGUILayout.HelpBox(msg, MessageType.Info);
        }
        else if (ourTarget.getLayers().Length == 0)
        {
            EditorGUILayout.HelpBox("This ListenerNode does not have any active layers!", MessageType.Warning);
        }
    }
}
