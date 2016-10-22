using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float speed = 1;
	
	void FixedUpdate () {
        GetComponent<BallworldObject>().moveForward(speed);
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Enemy>() != null)
        {
            GameObject.Destroy(collider.gameObject);
            GameObject.Destroy(gameObject);
        }        
    }
}
