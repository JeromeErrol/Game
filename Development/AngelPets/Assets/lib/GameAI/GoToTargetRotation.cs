using UnityEngine;
using System.Collections;

public class GoToTargetRotation : TargetedInstruction
{
		public float targetRotation;
		public float rotationAcceleration;
		public float rotationVelocity;
		private bool passed = false;
		private float velocity;

		public override void Begin ()
		{
				passed = false;
				velocity = rotationVelocity;
		}

		public override bool IsFinished ()
		{
				return passed;
		}

		public override void Run ()
		{
				Rotation rotation = Target.GetOrCreateComponent<Rotation> ();
				float previousRotation = rotation.value;
				rotation.RotateBy (velocity);
				velocity += rotationAcceleration;
				float newRotation = rotation.value;
				if (targetRotation.IsBetween (previousRotation, newRotation)) {
						rotation.value = targetRotation;
						passed = true;
				}
		}

}

