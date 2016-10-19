using UnityEngine;

public class BallworldObject : MonoBehaviour {
      
    public void moveForward(float distance)
    {
        transform.RotateAround(Vector3.zero, transform.up, distance);
    }

    public void moveSideways(float distance)
    {
        transform.RotateAround(Vector3.zero, -transform.right, distance);
    }

    public void moveVertically(float distance)
    {
        transform.RotateAround(Vector3.zero, Vector3.Cross(transform.position, Vector3.up), distance);
    }

    public void moveHorizontally(float distance)
    {
        transform.RotateAround(Vector3.zero, Vector3.down, distance);
    }
}
