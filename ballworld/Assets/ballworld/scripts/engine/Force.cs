using UnityEngine;

public class Force : BallworldObject {

    public Vector3 axis;
    public float amount = 1f;
    public float friction = 0.95f;
	
	void Update () {
        transform.RotateAround(Vector3.zero, axis, amount);
        amount *= friction;
        if (amount <= 0.1)
        {
            Destroy(this);
        }        
    }
}
