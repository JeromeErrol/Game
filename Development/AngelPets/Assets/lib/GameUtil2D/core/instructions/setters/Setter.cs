using UnityEngine;
using System.Collections;

public abstract class Setter : TargetedInstruction
{		
	private bool set = false;
	
	public override void Begin ()
	{
		set = false;
	}

	public override void Run ()
	{
		set = true;
		Set ();
	}

	public abstract void Set ();
	
	public override bool IsFinished ()
	{
		return set;
	}
}

