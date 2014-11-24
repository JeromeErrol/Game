using UnityEngine;
using System.Collections;

public class ActivateBehavior : InstructionRunOnce
{
	public MonoBehaviour behavior;
	
	public override void RunOnce ()
	{
		behavior.enabled = true;
	}
}

