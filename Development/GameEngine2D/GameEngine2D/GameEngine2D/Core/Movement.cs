using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public Vector2 acceleration;
	public Vector2 velocity;
	public float friction = 1f;
	public bool inGameObject = true;
	
	
	void FixedUpdate ()
	{
		float speed = RelativeTime;
		velocity.x += acceleration.x;
		velocity.y += acceleration.y;
		velocity.x *= (friction * speed);
		velocity.y *= (friction * speed);
		Vector3 position = transform.position;
		position.x += velocity.x * speed;
		position.y += velocity.y * speed;
		transform.position = position;
	}

	public void Stop ()
	{
		acceleration = Vector2.zero;
		velocity = Vector2.zero;
	}
	
	public float RelativeTime {
		get {
			if (inGameObject) { 
				return Game2D.GameSpeed;
			} else {
				return (Game2D.FrameRate / Time.deltaTime);
			}
		}
	}

	/*
	public void AccelerateTowards (Vector2 position, float distance)
	{
		Vector3 difference = position - transform.position;
		difference.Normalize ();
		acceleration.x += difference.x * distance;
		acceleration.y = difference.y * distance;
	}
	*/
	
	public static float CalculateAcceleration (float initialVelocity, float finalVelocity, float distance)
	{
		return (finalVelocity - initialVelocity) / (Mathf.Abs (distance / ((initialVelocity + finalVelocity) / 2f)));
	}
}

