using UnityEngine;
using System.Collections;

public abstract class TargetedAnimation : TargetedInstruction
{
		private float velocity;
		private float acceleration;
		public float initialVelocity;
		public float finalVelocity;
		public float targetValue;
		private float distanceTravelled;
		private float time;
		private float currentTime;
	
		public override void Begin ()
		{
				currentTime = 0;
				velocity = initialVelocity;
				float averageVelocity = (initialVelocity + finalVelocity) / 2f;

				distanceTravelled = targetValue - GetCurrentValue ();

				time = Mathf.Abs (distanceTravelled / averageVelocity);
				acceleration = (finalVelocity - initialVelocity) / time;
		}
	
		public override bool IsFinished ()
		{
				if (currentTime >= time) {
						SetCurrentValue (targetValue);
						return true;
				}
				return false;
		}

		public abstract float GetCurrentValue ();
	
		public override void Run ()
		{
				currentTime++;
				UpdateValue (velocity);
				velocity += acceleration;
		}
	
		public abstract void UpdateValue (float velocity);

		public abstract void SetCurrentValue (float value);
}

