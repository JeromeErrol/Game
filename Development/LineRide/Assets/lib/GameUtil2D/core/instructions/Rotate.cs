using UnityEngine;
using System.Collections;

public class Rotate : TargetedInstruction
{
	public float amount;

	public override void Run ()
	{
		Target.transform.Rotate (new Vector3(0, 0, amount));
	}
	
	public override void Begin ()
	{
		
	}
	
	public override bool IsFinished ()
	{
		return true;
	}
}

