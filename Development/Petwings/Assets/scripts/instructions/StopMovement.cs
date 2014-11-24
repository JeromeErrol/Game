using UnityEngine;
using System.Collections;

public class StopMovement : InstructionRunOnce
{
	public GameObject Target;

	public override void RunOnce ()
	{
		Target.GetOrCreateComponent<Movement> ().Stop ();
	}
}

