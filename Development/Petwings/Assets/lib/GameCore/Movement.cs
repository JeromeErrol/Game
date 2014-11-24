using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
		public Vector2 position;
		public Vector2 acceleration;
		public Vector2 velocity;
		public float friction = 1f;

		void Start ()
		{
				position = transform.position;
		}

		public void Translate (float x, float y)
		{
				float speed = gameObject.GetOrCreateComponent<Speed> ().RelativeSpeed;
				position.x += x * speed;
				position.y += y * speed;
		}

		public void Stop ()
		{
				acceleration = Vector2.zero;
				velocity = Vector2.zero;
		}

		void FixedUpdate ()
		{
				float speed = gameObject.GetOrCreateComponent<Speed> ().RelativeSpeed;
				velocity.x += acceleration.x;
				velocity.y += acceleration.y;
				velocity.x *= (friction * speed);
				velocity.y *= (friction * speed);
				acceleration = Vector2.zero;
				position.x += velocity.x * speed;
				position.y += velocity.y * speed;
				transform.position = position;
		}

		public void AccelerateTowards (Vector2 position, float distance)
		{
				Vector2 difference = position - this.position;
				difference.Normalize ();
				acceleration.x += difference.x * distance;
				acceleration.y = difference.y * distance;
		}

		public static float CalculateAcceleration (float initialVelocity, float finalVelocity, float distance)
		{
				return (finalVelocity - initialVelocity) / (Mathf.Abs (distance / ((initialVelocity + finalVelocity) / 2f)));
		}
}

