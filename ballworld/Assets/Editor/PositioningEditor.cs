using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BallworldObject))]
[CanEditMultipleObjects]
public class PositioningEditor : Editor
{
    BallworldObject ballworldObject;

    void OnEnable()
    {
        ballworldObject = (BallworldObject)target;
    }

    void OnSceneGUI()
    {
        Handles.Label(ballworldObject.transform.position, "Hello");

      //  Vector3 a = Handles.DoPositionHandle(ballworldObject.transform.position, ballworldObject.transform.rotation);

      //  Vector3 lookTarget = Handles.PositionHandle(ballworldObject.transform.position, Quaternion.identity);

      //  ballworldObject.transform.RotateAround(Vector3.zero, lookTarget, 0.1f);
        


        Event e = Event.current;
        switch (e.type)
        {
            case EventType.keyDown:
                {
                    if (Event.current.keyCode == (KeyCode.A))
                    {
                        ballworldObject.moveHorizontally(-distance);
                    }
                    if (Event.current.keyCode == (KeyCode.D))
                    {
                        ballworldObject.moveHorizontally(distance);
                    }
                    if (Event.current.keyCode == (KeyCode.W))
                    {
                        ballworldObject.moveVertically(distance);
                    }
                    if (Event.current.keyCode == (KeyCode.S))
                    {
                        ballworldObject.moveVertically(-distance);
                    }

                    if (Event.current.keyCode == (KeyCode.V))
                    {
                        Vector3 forward = ballworldObject.transform.position.normalized;
                        Vector3 upwards = Vector3.Cross(Vector3.zero, forward);                        
                        ballworldObject.transform.rotation = Quaternion.LookRotation(forward, upwards);
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