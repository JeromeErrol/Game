using UnityEngine;
using System.Collections;

public class GoToY : TargetedInstruction
{
		public Transform destinationY;
		public float initialVelocity = 0.01f;
		private float velocity;
		public float acceleration = 0;
		private bool finished;
		public bool haltOnArrival = false;
	
		public override void Run ()
		{
				velocity += acceleration;
				Movement movement = Target.gameObject.GetOrCreateComponent<Movement> ();
				float futurePosY = movement.position.y + (movement.velocity.y * 2);

				if (!destinationY.position.y.IsBetween (Target.transform.position.y, futurePosY)) {
						float currentY = movement.position.y;
						if (Target.transform.position.y < destinationY.position.y) {
								movement.acceleration.y += velocity;
						} else {
								movement.acceleration.y -= velocity;
						}
				} else {
						if (haltOnArrival) {
								movement.velocity.y = 0;
						}
						movement.position.y = destinationY.transform.position.y;
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

