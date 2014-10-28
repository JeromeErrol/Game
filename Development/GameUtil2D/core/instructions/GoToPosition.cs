using UnityEngine;
using System.Collections;

public class GoToPosition : TargetedInstruction
{
	public Vector3 position;

	public override void Run ()
	{
	}

	public override bool IsFinished ()
	{
		return false;
	}

	public override void Begin ()
	{

	}
}

