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
                        if (Event.current.shift)
                        {
                            BallworldObject duplicate = (BallworldObject)Object.Instantiate(ballworldObject, ballworldObject.transform.parent, true);
                            duplicate.moveForward(-duplicate.width * 1.15f);
                            Selection.activeGameObject = duplicate.gameObject;
                        }else
                        {
                            ballworldObject.moveHorizontally(-distance);
                        }
                        
                    }
                    if (Event.current.keyCode == (KeyCode.D))
                    {
                        if (Event.current.shift)
                        {
                            BallworldObject duplicate = (BallworldObject)Object.Instantiate(ballworldObject, ballworldObject.transform.parent, true);
                            duplicate.moveForward(duplicate.width);
                            Selection.activeGameObject = duplicate.gameObject;
                        }
                        else
                        {
                            ballworldObject.moveHorizontally(distance);
                        }
                    }
                    if (Event.current.keyCode == (KeyCode.W))
                    {
                        

                        if (Event.current.shift)
                        {
                            BallworldObject duplicate = (BallworldObject)Object.Instantiate(ballworldObject, ballworldObject.transform.parent, true);
                            duplicate.moveSideways(duplicate.width);
                            Selection.activeGameObject = duplicate.gameObject;
                        }
                        else
                        {
                            ballworldObject.moveVertically(distance);
                        }
                    }
                    if (Event.current.keyCode == (KeyCode.S))
                    {
                        ballworldObject.moveVertically(-distance);
                    }

                    if (Event.current.keyCode == (KeyCode.I))
                    {
                        ballworldObject.moveForward(distance);
                    }
                    if (Event.current.keyCode == (KeyCode.K))
                    {
                        ballworldObject.moveForward(-distance);
                    }
                    if (Event.current.keyCode == (KeyCode.J))
                    {
                        ballworldObject.moveSideways(distance);
                    }
                    if (Event.current.keyCode == (KeyCode.L))
                    {
                        ballworldObject.moveSideways(-distance);
                    }

                    if (Event.current.keyCode == (KeyCode.Z))
                    {
                        BallworldObject duplicate = (BallworldObject)Object.Instantiate(ballworldObject, ballworldObject.transform.parent, true);
                        duplicate.moveForward(duplicate.width);
                       // duplicate.moveForward(0.1f);
                    }

                    if (Event.current.keyCode == (KeyCode.V))
                    {
                        float rotation = ballworldObject.transform.rotation.z;
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