using UnityEngine;
using System.Collections;

public class Velocity : MonoBehaviour
{
		float acceleration = 0;
		public float friction = 0.95f;
		float velocity = 0;
		float previousVelocity;

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
			nextPosition.x += velocity.RealVal();
			Vector3 vel = new Vector3 (velocity, 0, 0);
			transform.position = Vector3.SmoothDamp (transform.position, nextPosition, ref vel, 1f);
		}

		float averageVelocity {
				get {
						return (previousVelocity + velocity) / 2f;
				}
		}
}

