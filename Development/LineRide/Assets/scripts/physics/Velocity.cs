using UnityEngine;
using System.Collections;

public class Velocity : MonoBehaviour
{
		float acceleration = 0;
		public float friction = 0.95f;
		float velocity = 0;
		float previousVelocity;
		Vector3 direction = new Vector3(1, 0, 0);

		void Start ()
		{	
				previousVelocity = velocity;
		}

		public void AddAcceleration (float amount)
		{
				acceleration += amount;
		}

		public float Vel {
				get {
						return velocity;
				}
		}

		void FixedUpdate ()
		{
			velocity += acceleration;
			acceleration = 0;
			velocity *= (friction);

			Vector3 nextPosition = transform.position;
			nextPosition.x += velocity;
			Vector3 targetPos = new Vector3 (velocity, 0, 0);
			Vector3 vel = new Vector3 (velocity, 0, 0);
			transform.position = Vector3.SmoothDamp (transform.position, nextPosition, ref vel, 1f);
			// transform.position = Vector3.MoveTowards(transform.position, nextPosition, Time.deltaTime * Mathf.Abs(velocity));
		}

		float averageVelocity {
				get {
						return (previousVelocity + velocity) / 2f;
				}
		}
}

