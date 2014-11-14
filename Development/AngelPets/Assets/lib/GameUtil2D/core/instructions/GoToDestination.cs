using UnityEngine;
using System.Collections;

public class GoToDestination : TargetedInstruction
{
		public GameObject destination;
		public float movementSpeed = 0.01f;

		public override void Run ()
		{
				Target.gameObject.GetOrCreateComponent<Movement> ().AccelerateTowards (destination.transform.position, movementSpeed);
		}

		public override void Begin ()
		{

		}

		public override bool IsFinished ()
		{
				float dist = Vector3.Distance (Target.transform.position, destination.transform.position);
				return dist <= (movementSpeed + 0.01f);	
		}
}

