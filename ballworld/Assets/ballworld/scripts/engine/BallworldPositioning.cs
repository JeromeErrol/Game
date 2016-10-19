using UnityEngine;
using System.Collections;

public class BallworldPositioning : MonoBehaviour {

    public void moveVertically(float distance)
    {
        transform.RotateAround(Vector3.zero, -Vector3.back, distance);
    }

    public void moveHorizontally(float distance)
    {
        transform.RotateAround(Vector3.zero, -Vector3.up, distance);
    }
}
