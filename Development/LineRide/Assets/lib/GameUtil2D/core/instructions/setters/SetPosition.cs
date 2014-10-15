using UnityEngine;
using System.Collections;

public class SetPosition : TargetedInstruction
{
	public GameObject destinationPosition;
	private bool moved = false;

	public override void Begin ()
	{
		moved = false;
	}

	public override void Run ()
	{
		Target.transform.position = destinationPosition.transform.position;
		moved = true;
	}

	public override bool IsFinished ()
	{
		return moved;
	}
}

