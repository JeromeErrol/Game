using UnityEngine;
using System.Collections;

public class Rotate : TargetedInstruction
{
	public float amount;
	public bool run = false;

	public override void Run ()
	{
		Target.transform.Rotate (new Vector3(0, 0, amount));
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

