using UnityEngine;

public class Slide : MonoBehaviour {

    public float forwardSpeed = 0;
    public float sidewaysSpeed = 0;

    void FixedUpdate () {
        GetComponent<BallworldObject>().moveSideways(sidewaysSpeed);
        GetComponent<BallworldObject>().moveForward(forwardSpeed);
    }
}
