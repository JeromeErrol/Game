using UnityEngine;
using System.Collections;

public class Destroy : TargetedInstruction
{
	private bool called = false;

	public override void Begin ()
	{
		called = false;
	}

	public override bool IsFinished ()
	{
		return called;
	}

	public override void Run ()
	{
		called = true;
		GameObject.Destroy (Target);
	}
}

