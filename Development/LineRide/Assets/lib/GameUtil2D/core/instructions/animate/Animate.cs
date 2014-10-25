using UnityEngine;
using System.Collections;

public abstract class Animate : TargetedInstruction
{
		private float velocity;
		private float acceleration;
		public float initialVelocity;
		public float finalVelocity;
		public float distanceTravelled;
		private float time;
		private float currentTime;

		public override void Begin ()
		{
				currentTime = 0;
				velocity = initialVelocity;
				float averageVelocity = 0.5f * (initialVelocity + finalVelocity);
				time = distanceTravelled / averageVelocity;
				acceleration = (finalVelocity - initialVelocity) / time;
		}

		public override bool IsFinished ()
		{
				return currentTime >= time;
		}

		public override void Run ()
		{
				currentTime++;
				UpdateValue (velocity);
				velocity += acceleration;
		}

		public abstract void UpdateValue (float velocity);

		
}

