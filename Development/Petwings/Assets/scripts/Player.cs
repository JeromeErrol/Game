using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Player : MonoBehaviour
{
		public KeyCode accelerateKey = KeyCode.RightArrow;
		public KeyCode breakKey = KeyCode.LeftArrow;
		public float acceleration;
		public bool activated = false;
		public int heldDownFor = 0;
		public bool moving = false;
		private float movingFlapSpeed = 3f;
		private float normalFlapSpeed = 1f;
		private Animator animator;
		private ParticleGenerator glintGenerator;
		public static Player instance;
		public static int currentLevel = 0;

		void Awake ()
		{
				Player.instance = this;
				animator = GetComponent<Animator> ();
				glintGenerator = GameObject.Find ("glintGenerator").GetComponent<ParticleGenerator> ();
		}

		void FixedUpdate ()
		{
				if (Game.Instance.Paused == false) {
						moving = false;
						ReadKeyboardInput ();
						ReadScreenInput ();
						
						glintGenerator.enabled = moving;
						if (moving) {
								animator.speed = movingFlapSpeed;
						} else {
								animator.speed = normalFlapSpeed;
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
										float touchX = touch.position.x;
										
										if (touch.position.y > (Screen.height / 6)) {

												if (touchX > (Screen.width / 2)) {
														Accelerate ();
												} else {
														Reverse ();
												}
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
				movement.acceleration.x += (this.acceleration * gameObject.GetRelativeSpeed ());
				Vector3 scale = gameObject.transform.localScale;
				scale.x = Mathf.Abs (scale.x);
				transform.localScale = scale;
				moving = true;
		}

		void Reverse ()
		{
				Movement movement = gameObject.GetComponent<Movement> ();
				movement.acceleration.x -= (this.acceleration * gameObject.GetRelativeSpeed ());
				Vector3 scale = gameObject.transform.localScale;
				scale.x = -Mathf.Abs (scale.x);
				transform.localScale = scale;
				moving = true;
		}
}
