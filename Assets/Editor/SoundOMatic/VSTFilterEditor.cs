using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(VSTFilter), true)]
public class VSTFilterEditor : Editor {

    public override void OnInspectorGUI()
    {
		VSTFilter ourTarget = (VSTFilter) target;

		if(GUILayout.Button("Reset to Defaults")){
			ourTarget.resetToDefaults();
		}		
		
        DrawDefaultInspector();
	}

}
