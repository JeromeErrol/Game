using UnityEngine;
using System.Collections;

public class Toggle : InstructionRunOnce
{
		private bool on = true;
		public Instruction instructionA;
		public Instruction instructionB;


		public override void RunOnce ()
		{
				if (on) {
						instructionA.Run ();
				} else {
						instructionB.Run ();
				}
				on = !on;
		}
}

