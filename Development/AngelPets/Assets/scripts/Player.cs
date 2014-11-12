using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Player : MonoBehaviour
{
		public KeyCode accelerateKey = KeyCode.RightArrow;
		public KeyCode breakKey = KeyCode.LeftArrow;
		public float acceleration;
		public static int currentLevel = 0;
		public bool activated = false;
		public int heldDownFor = 0;
		public bool moving = false;
		public static Player instance;
		public int fastFlapSpeed = 2;
		public int slowFlapSpeed = 5;

		void Start ()
		{
				Player.instance = this;
		}

		void FixedUpdate ()
		{
				if (Game.Instance.Paused == false) {
						moving = false;
						ReadKeyboardInput ();
						ReadScreenInput ();
						GameObject.Find ("glintGenerator").GetComponent<ParticleGenerator> ().enabled = moving;
						SpriteSheet cat = Player.instance.GetComponent<SpriteSheet> ();		
						if (moving) {
								cat.SetTimePerFrame (fastFlapSpeed);

						} else {
								cat.SetTimePerFrame (slowFlapSpeed);
						}

						if (gameObject.Left () < -17.906f) {
								gameObject.Left (-17.906f);
						}

						if (transform.position.x > 18.073) {
								Level.instance.NextLevel ();
						}
				}
		}

		void ReadScreenInput ()
		{
				for (var i = 0; i < Input.touchCount; ++i) {
						Touch touch = Input.GetTouch (i);

						if (activated == false) {

								if (touch.phase == TouchPhase.Began) {
										activated = true;
								}
						}						

						if (activated) {
								if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved) {
										if (touch.position.x > (Screen.width / 2)) {
												Accelerate ();
										} else {
												Reverse ();
										}
								}
						} 
				}
		}

		void ReadKeyboardInput ()
		{
				if (Input.GetKeyDown (accelerateKey) || Input.GetKeyDown (breakKey)) {
						activated = true;
				}
			
				if (Input.GetKey (accelerateKey)) {
						heldDownFor++;
						if (heldDownFor > 15) {
								activated = true;
						}
				}

				if (activated) {

						if (Input.GetKey (accelerateKey) || Input.GetKey (KeyCode.D)) {
								Accelerate ();
						}		
						if (Input.GetKey (breakKey) || Input.GetKey (KeyCode.A)) {
								Reverse ();
						}
				} 
		}

		void Accelerate ()
		{
				Movement movement = gameObject.GetComponent<Movement> ();
				movement.acceleration.x += this.acceleration;
				Vector3 scale = gameObject.transform.localScale;
				scale.x = Mathf.Abs (scale.x);
				transform.localScale = scale;
				moving = true;
		}

		void Reverse ()
		{
				Movement movement = gameObject.GetComponent<Movement> ();
				movement.acceleration.x -= this.acceleration;
				Vector3 scale = gameObject.transform.localScale;
				scale.x = -Mathf.Abs (scale.x);
				transform.localScale = scale;
				moving = true;
		}
}
