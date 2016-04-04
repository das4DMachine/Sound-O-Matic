using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(Animation), true)]
public class AnimationEditor : Editor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        SerializedProperty vecProp = serializedObject.FindProperty("m_Animations");

        List<string> names = new List<string>();

        for (int i = 0; i < vecProp.arraySize; i++)
        {
            SerializedProperty elmProp = vecProp.GetArrayElementAtIndex(i);

            AnimationClip clip = (AnimationClip)elmProp.objectReferenceValue;

            if (clip != null)
            {
				// Set as legacy and add to list of anims
				clip.legacy = true;
				names.Add(clip.name);
            }
        }

		// Also set the default anim as legacy
		SerializedProperty defaultAnimProperty = serializedObject.FindProperty("m_Animation");
		AnimationClip defaultClip = (AnimationClip)defaultAnimProperty.objectReferenceValue;
		if (defaultClip!=null){
			defaultClip.legacy = true;
		}

        Animation ourTarget = (Animation)target;

        Starter[] starters = ourTarget.GetComponents<Starter>();
        foreach (Starter starter in starters)
        {
            starter.animationNames = names;
        }

        DrawDefaultInspector();
    }
}
