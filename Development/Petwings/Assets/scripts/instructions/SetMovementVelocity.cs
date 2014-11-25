using UnityEngine;
using System.Collections;

public class SetMovementVelocity : InstructionRunOnce
{
		public Movement movement;
		public Vector2 velocity;

		public override void RunOnce ()
		{
				movement.velocity = velocity;
		}
}

