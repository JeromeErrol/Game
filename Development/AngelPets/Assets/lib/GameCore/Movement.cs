using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
		public Vector2 position;
		public Vector2 acceleration;
		public Vector2 velocity;
		public float rotationalAcceleration;
		public float rotationalVelocity;

		void Start ()
		{
				position = transform.position;
		}

		void Update ()
		{
				velocity.x += acceleration.x;
				velocity.y += acceleration.y;
				float speed = gameObject.GetOrCreateComponent<Speed> ().RelativeSpeed;
				position.x += velocity.x * speed;
				position.y += velocity.y * speed;
				rotationalVelocity += rotationalAcceleration;
				gameObject.RotateBy (rotationalVelocity * speed);
				transform.position = position;
		}

		public static float CalculateAcceleration (float initialVelocity, float finalVelocity, float distance)
		{
				return (finalVelocity - initialVelocity) / (Mathf.Abs (distance / ((initialVelocity + finalVelocity) / 2f)));
		}
}

