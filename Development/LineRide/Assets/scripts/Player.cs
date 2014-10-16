using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public KeyCode accelerateKey = KeyCode.RightArrow;
	public KeyCode breakKey = KeyCode.LeftArrow;
	public float acceleration;
	public static int currentLevel = 0;
		

	void Start () {

	}

	void FixedUpdate () {
		ReadKeyboardInput ();
		ReadScreenInput ();

		float leftBound = 1.45f;
		float rightBound = 28f;
		if (transform.position.x < leftBound) {
			Vector3 pos = transform.position;
			pos.x = leftBound;
			transform.position = pos;
		}

		if (transform.position.x > rightBound) {
			Level.instance.NextLevel();
		}
	}

	void ReadScreenInput(){
		for (var i = 0; i < Input.touchCount; ++i) {
			Touch touch = Input.GetTouch(i);
			if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Began) {
				if (touch.position.x > (Screen.width/2)) {
					Accelerate();
				}else{
					Reverse();
				}
			}
		}
	}

	void ReadKeyboardInput(){
		if (Input.GetKey (accelerateKey)|| Input.GetKey(KeyCode.D)) {
			Accelerate();
		}		
		if (Input.GetKey (breakKey)|| Input.GetKey(KeyCode.A)){
			Reverse();
		}
	}

	void Accelerate(){
		GetComponent<Velocity> ().AddAcceleration(acceleration);
	}

	void Reverse(){
		GetComponent<Velocity> ().AddAcceleration(-acceleration);
	}
}
