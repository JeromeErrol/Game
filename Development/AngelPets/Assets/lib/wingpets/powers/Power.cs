using UnityEngine;
using System.Collections;

public abstract class Power : Instruction
{
		public float duration;
		private float timeRemaining;
	
		public override void Begin ()
		{
				Activated ();
				timeRemaining = duration;
		}
	
		public override void Run ()
		{
				if (!Game.Instance.Paused) {
						timeRemaining -= this.RelativeSpeed ();
				}
		}
	
		public override bool IsFinished ()
		{
				if (timeRemaining <= 0) {
						Deactivated ();
						return true;
				}
				return false;
		}

		public abstract void Activated ();

		public abstract void Deactivated ();
}

