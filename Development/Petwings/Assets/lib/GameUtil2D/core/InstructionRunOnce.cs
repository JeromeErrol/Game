using UnityEngine;
using System.Collections;

public abstract class InstructionRunOnce : Instruction
{
		private bool called = false;
	
		public override void Begin ()
		{
				called = false;
		}
	
		public override bool IsFinished ()
		{
				return called;
		}
	
		public override void Run ()
		{
				if (enabled) {
						called = true;
						RunOnce ();
				}
		}

		public abstract void RunOnce ();
}

