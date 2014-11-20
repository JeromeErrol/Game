using UnityEngine;
using System.Collections;

public class ShakeTime : TargetedInstruction
{
		public float time;
		public float intensity;
		private float timeRemaining;
		private Vector2 savePosition;

		public override void Begin ()
		{
				timeRemaining = time;
				savePosition = Target.transform.position;
		}

		public override void Run ()
		{
				Target.transform.position = savePosition;
				timeRemaining -= Target.GetRelativeSpeed ();
				float x = (0f).GiveOrTake (intensity);
				float y = (0f).GiveOrTake (intensity);
				Vector2 accel = new Vector2 (x, y);
				Target.GetOrCreateComponent<Movement> ().position += accel;
				savePosition = Target.transform.position;
		}
	
		public override bool IsFinished ()
		{
				return timeRemaining <= 0;
		}
}



