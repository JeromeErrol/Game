using UnityEngine;
using System.Collections;

public class BallworldPositioning : MonoBehaviour {

    private Vector3 verticalAxis; 

    public void moveVertically(float distance)
    {        
        if (transform.position != Vector3.up)
        {
            verticalAxis = Vector3.Cross(transform.position, Vector3.up);
        }        
        transform.RotateAround(Vector3.zero, verticalAxis, distance);
        
    }

    public void moveHorizontally(float distance)
    {
        transform.RotateAround(Vector3.zero, Vector3.down, distance);
    }
}
