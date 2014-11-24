using UnityEngine;
using System.Collections;

public class ResetInstruction : InstructionRunOnce
{
		public Instruction instruction;

		public override void RunOnce ()
		{
				instruction.Begin ();
		}
}

