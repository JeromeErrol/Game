using UnityEngine;
using System.Collections;

public class Slide : MonoBehaviour {

    public float verticalSpeed = 0;
    public float horizontalSpeed = 0;

    void FixedUpdate () {
        GetComponent<BallworldObject>().moveHorizontally(horizontalSpeed);
        GetComponent<BallworldObject>().moveVertically(verticalSpeed);
    }
}
