using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class RocketShip : MonoBehaviour {

	public float thrustSpeed = 0.5f;
	public float friction = 0.9f;
	Vector3 velocity = Vector3.zero;
	Vector3 acceleration = Vector3.zero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		updatePhysics ();
	}

	void updatePhysics(){
		velocity += acceleration;
		velocity *= friction;
		acceleration = Vector3.zero;
		transform.Translate (velocity);
	}

	public void FireThruster(){
		float angle = Mathf.Rad2Deg * transform.rotation.z;
		acceleration += TrigUtil2D.GetVelocity (angle, this.thrustSpeed);
	}
}
