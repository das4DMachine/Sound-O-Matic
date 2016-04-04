using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(Starter), true)]
public class StarterEditor : Editor
{

    public override void OnInspectorGUI()
    {
        Starter ourTarget = (Starter)target;

        List<string> animationTargets = new List<string>();

        animationTargets.Add("None");

        if (ourTarget.GetComponent<Animation>() != null)
        {
            if (ourTarget.GetComponent<Animation>().clip != null)
            {
                animationTargets.Add("Default");
            }

            foreach (string name in ourTarget.animationNames)
            {
                animationTargets.Add(name);
            }
        }

        int animationIndex = 0;

        for (int i = 0; i < animationTargets.Count; i++)
        {
            if(animationTargets[i].Equals(ourTarget.choosenAnimation)) {
                animationIndex = i;
                break;
            }
        }

        int index = EditorGUILayout.Popup("Target animation", animationIndex, animationTargets.ToArray(), new GUILayoutOption[0]);

        if (animationTargets[index].Equals("None"))
        {
            ourTarget.choosenAnimation = "";
        }
        else if (animationTargets[index].Equals("Default"))
        {
            ourTarget.choosenAnimation = "Default";
        }
        else
        {
            ourTarget.choosenAnimation = animationTargets[index];
        }

        DrawDefaultInspector();
    }

}
