using UnityEngine;
using System.Collections;

public class ToggleBehavior : InstructionRunOnce
{
	public MonoBehaviour behavior;
	
	public override void RunOnce ()
	{
		behavior.enabled = !behavior.enabled;
	}
}

