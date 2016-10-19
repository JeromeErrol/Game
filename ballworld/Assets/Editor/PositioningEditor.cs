using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(BallworldPositioning))]
public class PositioningEditor : Editor
{
    public override void OnInspectorGUI()
    {
        BallworldPositioning ballworldPositioning = (BallworldPositioning) target;       

        if (GUILayout.Button("Up"))
        {
            ballworldPositioning.moveVertically(1);
        }

        if (GUILayout.Button("Down"))
        {
            ballworldPositioning.moveVertically(-1);
        }

        if (GUILayout.Button("Left"))
        {
            ballworldPositioning.moveHorizontally(-1);
        }

        if (GUILayout.Button("Right"))
        {
            ballworldPositioning.moveHorizontally(1);
        }
    }
}