using UnityEngine;
using System.Collections;

public class SetPosition : TargetedInstruction
{
	public GameObject destinationPosition;

	public override void Begin ()
	{

	}

	public override void Run ()
	{
		target.transform.position = destinationPosition.transform.position;
	}

	public override bool IsFinished ()
	{
		return true;
	}
}

