using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(GroupHelper), true)]
public class GroupHelperEditor : Editor {

    public override void OnInspectorGUI() {
        GroupHelper ourTarget = (GroupHelper)target;

		if (ourTarget.getRealTargets().Length == 0){
			EditorGUILayout.HelpBox("This helper cannot possibly help with anything since no AudioNode or Animation is selected", MessageType.Warning);
		}

        DrawDefaultInspector();
    }

}
