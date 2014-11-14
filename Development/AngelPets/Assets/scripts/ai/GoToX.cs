using UnityEngine;
using System.Collections;

public class GoToX : TargetedInstruction
{
		public Transform destinationX;
		public float movementSpeed = 0.01f;
		private bool finished;
	
		public override void Run ()
		{
				float difference = Mathf.Abs (destinationX.position.x - Target.transform.position.x);

				if (difference > 0.1 + movementSpeed) {
						Movement movement = Target.gameObject.GetOrCreateComponent<Movement> ();
						float currentX = movement.position.x;
						if (Target.transform.position.x < destinationX.position.x) {
								movement.acceleration.x += movementSpeed;
						} else {
								movement.acceleration.x -= movementSpeed;
						}
				} else {
						finished = true;
				}
		}
	
		public override void Begin ()
		{
				finished = false;
		}
	
		public override bool IsFinished ()
		{
				return finished;
		}
}

