using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(BallworldPositioning))]
public class PositioningEditor : Editor
{
    public override void OnInspectorGUI()
    {
        BallworldPositioning ballworldPositioning = (BallworldPositioning) target;

        float distance = 1;   

        if (GUILayout.Button("Up"))
        {
            ballworldPositioning.moveVertically(distance);
        }

        if (GUILayout.Button("Down"))
        {
            ballworldPositioning.moveVertically(-distance);
        }

        if (GUILayout.Button("Left"))
        {
            ballworldPositioning.moveHorizontally(-distance);
        }

        if (GUILayout.Button("Right"))
        {
            ballworldPositioning.moveHorizontally(distance);
        }
    }
}