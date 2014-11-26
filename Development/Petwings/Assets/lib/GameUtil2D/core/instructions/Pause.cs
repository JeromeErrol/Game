using UnityEngine;
using System.Collections;

public class Pause : Instruction
{
		public float duration;
		private float _duration;

		public override void Run ()
		{
				float gs = Game.GameSpeed;
				_duration -= 50f * Time.deltaTime;
		}

		public override bool IsFinished ()
		{
				return _duration < 0;
		}

		public override void Begin ()
		{
				_duration = duration;
		}
}

