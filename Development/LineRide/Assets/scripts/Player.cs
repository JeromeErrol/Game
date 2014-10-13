using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public KeyCode accelerateKey = KeyCode.RightArrow;
	public KeyCode breakKey = KeyCode.LeftArrow;
	public float acceleration;
	public const int StartingLives = 10;
	public static int livesRemaining = StartingLives;

	void Start () {
	
	}

	void Update () {
		ReadKeyboardInput ();
	}

	void ReadKeyboardInput(){
		if (Input.GetKey (accelerateKey)) {
			Accelerate();
		}		
		if (Input.GetKey (breakKey)) {
			Reverse();
		}
	}

	void Accelerate(){
		rigidbody2D.AddForce (new Vector2 (acceleration, 0));
	}

	void Reverse(){
		rigidbody2D.AddForce (new Vector2 (-acceleration, 0));
	}
}
