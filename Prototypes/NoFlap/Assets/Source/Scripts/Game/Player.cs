using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
		PlayMakerFSM fsm;
		bool flapping;
		Animator animator;
		public float targetHeight;
		public float riseFlapSpeed;
		public float lowerFlapSpeed;
		public float fallingRecoverySpeed;
		public float distanceRatio;
		public float recoverRatio;
		public float rotationRatio;

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
						// animator.animation ["bear_flying"].time = 0;
				} 
				if (!DoFall && !flapping) {
						flapping = true;
				}

				if (flapping) {
						ManageFlapSpeed ();
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
				Scene.Reload ();
		}

		void ManageFlapSpeed ()
		{
				float yVel = rigidbody2D.velocity.y;
				float yPos = transform.position.y;
				float flapSpeed = 1.0f;

				float distance = Mathf.Abs (targetHeight - yPos);
				bool belowTarget = yPos < targetHeight;
				bool rising = yVel > 0;
            
				if (belowTarget) {
						if (rising) {
								// The greater the distance is the faster the flapspeed should be.
								float ratio = Mathf.Max (1f, ((distance / yVel) / (distanceRatio)));
								flapSpeed = riseFlapSpeed * ratio;
						} else {
								// The greater the fall speed the faster the recover speed
								float fallingSpeed = Mathf.Abs (yVel);
								float ratio = Mathf.Max (1f, (fallingSpeed / recoverRatio));
								flapSpeed = fallingRecoverySpeed * ratio;
						}
				} else { // Above Target
						if (rising) {
								flapSpeed = 0.5f;
						} else { // Falling
								flapSpeed = lowerFlapSpeed;
						}
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
