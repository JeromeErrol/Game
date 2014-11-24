using UnityEngine;
using System.Collections;

public class ActivateRunAutomatically : InstructionRunOnce
{
		public Instruction instruction;

		public override void RunOnce ()
		{
			instruction.runAutomatically = true;
		}
}

