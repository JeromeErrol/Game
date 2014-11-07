using UnityEngine;
using System.Collections;

public class NextLevel : InstructionRunOnce
{

	public override void RunOnce ()
	{
		Level.instance.NextLevel ();
	}
}

