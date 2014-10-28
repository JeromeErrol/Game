using UnityEngine;
using System.Collections;

public class Fade : TargetedInstruction
{
		public float amount;
		public bool run = false;
	
		public override void Run ()
		{
				Target.ModifyAlpha (amount);
				run = true;
		}
	
		public override void Begin ()
		{
				run = false;
		}
	
		public override bool IsFinished ()
		{
				return run;
		}
}

