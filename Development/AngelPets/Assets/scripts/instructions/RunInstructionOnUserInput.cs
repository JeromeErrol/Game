using UnityEngine;
using System.Collections;

public class RunInstructionOnUserInput : UserInteractive
{
		public Instruction instruction;

		public override void Pressed ()
		{
				instruction.Run ();
		}
}

