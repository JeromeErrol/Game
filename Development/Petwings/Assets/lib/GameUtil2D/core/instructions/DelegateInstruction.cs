using UnityEngine;
using System.Collections;
using System;

public class DelegateInstruction : InstructionRunOnce
{
		public Action action;
		
		public override void RunOnce ()
		{
				action ();
		}
}

