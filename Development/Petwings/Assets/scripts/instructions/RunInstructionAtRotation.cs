using UnityEngine;
using System.Collections;

public class RunInstructionAtRotation : Instruction
{
		public GameObject2D gameObject2D;
		public Instruction instruction;
		public float rotation;
		private float previousRotation1;
		private bool finished = false;

		public override void Begin ()
		{
				finished = false;
		}

		public override bool IsFinished ()
		{
				return finished;
		}

		public override void Run ()
		{
				float currentRotation = gameObject2D.NormalizedRotation;
				finished = rotation.IsBetween (previousRotation1, currentRotation);
				if (finished) {
						instruction.Run ();
				}
				previousRotation1 = currentRotation;
		}
}

