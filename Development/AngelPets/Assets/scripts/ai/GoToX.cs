using UnityEngine;
using System.Collections;

public class GoToX : TargetedInstruction
{
	public Transform destinationX;
	public float initialVelocity = 0.01f;
	private float velocity;
	public float acceleration = 0;
	private bool finished;
	public bool haltOnArrival = false;
	
	public override void Run ()
	{
		velocity += acceleration;
		Movement movement = Target.gameObject.GetOrCreateComponent<Movement> ();
		float futurePosY = movement.position.x + movement.velocity.x + velocity * movement.friction;
		
		if (!destinationX.position.x.IsBetween (Target.transform.position.x, futurePosY)) {
			float currentY = movement.position.x;
			if (Target.transform.position.x < destinationX.position.x) {
				movement.acceleration.x += velocity;
			} else {
				movement.acceleration.x -= velocity;
			}
		} else {
			if (haltOnArrival) {
				movement.velocity.x = 0;
			}
			movement.position.x = destinationX.transform.position.x;
			finished = true;
		}
	}
	
	public override void Begin ()
	{
		finished = false;
		velocity = initialVelocity;
	}
	
	public override bool IsFinished ()
	{
		return finished;
	}
}

