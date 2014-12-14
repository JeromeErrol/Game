using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
		public static Player instance;
		PlayMakerFSM fsm;
		bool flapping;
		Animator animator;
		public float risingVelocityRatio;
		public float recoveringVelocityRatio;
		public float rotationRatio;
		public float maxHeight;
		public float overMaxHeightVelocityRatio;

		void Awake ()
		{
				instance = this;
		}

		public static GameObject GameObject {
				get {
						return instance.gameObject;
				}
		}

		void Start ()
		{
				fsm = GetComponent<PlayMakerFSM> ();
				animator = GetComponent<Animator> ();
				flapping = true;
		}

		void FixedUpdate ()
		{
				if (DoFall && flapping) {
						flapping = false;
						animator.SetTrigger ("stop_flapping");
				} 
				if (!DoFall && !flapping) {
						flapping = true;
						animator.SetTrigger ("resume_flapping");
				}

				if (flapping) {
						ManageFlapSpeed2 ();
				} else {
						animator.speed = 0;
				}
				UpdateRotation ();
		}

		public void UpdateRotation ()
		{
				gameObject.rigidbody2D.rotation = YVelocity * rotationRatio;
		}

		public void Die ()
		{
				Score.GameOver ();
				Scene.Reload ();
		}

		void ManageFlapSpeed2 ()
		{
				float yVel = rigidbody2D.velocity.y;
				float yPos = transform.position.y;
				bool rising = yVel > 0;
				bool belowMaxHeight = yPos < maxHeight;
				float flapSpeed = 1.0f;
				
				if (rising) {
						if (belowMaxHeight) {
								// The faster we are rising (The higher yVel is) 
								// The slower we need to flap
								flapSpeed = (risingVelocityRatio / Mathf.Max (1f, yVel));
						} else {
								float distanceOver = yPos - maxHeight;
								// The greater the distance over, the slower we need to flap
								flapSpeed = overMaxHeightVelocityRatio / Mathf.Max (1f, distanceOver);
						}
				} else { // If Falling
						// The faster we are falling (The lower yVel is)
						// The faster we need to flap
						flapSpeed = (recoveringVelocityRatio * yVel);
				}

				animator.speed = Mathf.Abs (flapSpeed);
		}

		public void Flap ()
		{
				if (flapping) {
						fsm.SendEvent ("Flap");
				}
		}

		private bool DoFall {
				get {
						return Input.GetKey (KeyCode.Space) || Input.GetMouseButton (0);
				}
		}

		public bool Falling {
				get {
						return YVelocity < 0;
				}
		}

		public float YVelocity {
				get {
						return rigidbody2D.velocity.y;
				}set {
						Vector3 velocity = rigidbody2D.velocity;
						velocity.y = value;
						rigidbody2D.velocity = velocity;
				}
		}

}
