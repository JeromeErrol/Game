using UnityEngine;
using System.Collections;

public class PreviousLevel : InstructionRunOnce
{

	public override void RunOnce ()
	{
		Level.instance.PreviousLevel ();
	}
}

