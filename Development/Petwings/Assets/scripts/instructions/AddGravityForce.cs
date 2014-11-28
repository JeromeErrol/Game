using UnityEngine;
using System.Collections;

public class AddGravityForce : InstructionRunOnce
{
		public Movement movement;

		public override void RunOnce ()
		{
				movement.gameObject.GetOrCreateComponent<Force2D> ().value.y = -0.005f;
		}
}

