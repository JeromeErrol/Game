using UnityEngine;
using System.Collections;

public class MovementStop : InstructionRunOnce
{
	public Movement movement;

	public override void RunOnce ()
	{
		movement.Stop ();
	}
}

