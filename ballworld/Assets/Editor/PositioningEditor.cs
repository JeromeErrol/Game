using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(BallworldObject))]
public class PositioningEditor : Editor
{
    /*
    void OnSceneGUI()
    {
        BallworldObject ballworldPositioning = (BallworldObject) target;

        switch (Event.current.type)
        {
            case EventType.keyDown:
                {
                    if (Event.current.keyCode == (KeyCode.A))
                    {
                        ballworldPositioning.moveHorizontally(-distance);
                    }

                    if (Event.current.keyCode == (KeyCode.D))
                    {
                        ballworldPositioning.moveHorizontally(distance);
                    }

                    if (Event.current.keyCode == (KeyCode.W))
                    {
                        ballworldPositioning.moveVertically(distance);
                    }

                    if (Event.current.keyCode == (KeyCode.S))
                    {
                        ballworldPositioning.moveVertically(-distance);
                    }
                    break;
                }
        }
    }
    */

    void OnSceneGUI()
    {
        BallworldObject script = (BallworldObject)target;
        Event e = Event.current;
        switch (e.type)
        {
            case EventType.keyDown:
                {
                    if (Event.current.keyCode == (KeyCode.A))
                    {
                        script.moveHorizontally(-distance);
                    }
                    if (Event.current.keyCode == (KeyCode.D))
                    {
                        script.moveHorizontally(distance);
                    }
                    if (Event.current.keyCode == (KeyCode.W))
                    {
                        script.moveVertically(distance);
                    }
                    if (Event.current.keyCode == (KeyCode.S))
                    {
                        script.moveVertically(-distance);
                    }
                    break;
                }
        }
    }
    
    public float distance
    {
        get
        {
            if (Event.current.shift)
            {
                return 0.1f;
            }
            return 1f;
        }
    }
}