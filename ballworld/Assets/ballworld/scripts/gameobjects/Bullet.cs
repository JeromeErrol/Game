using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed = 1;
	
	void FixedUpdate () {
        GetComponent<BallworldObject>().moveForward(speed);
	}

    void OnTriggerEnter(Collider collider)
    {
          
    }
}
