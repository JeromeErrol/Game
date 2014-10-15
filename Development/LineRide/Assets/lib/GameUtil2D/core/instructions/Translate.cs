using UnityEngine;
using System.Collections;

public class Translate : TargetedInstruction
{
	public float x;
	public float y;

	public override void Run ()
	{
		Vector3 pos = target.transform.position;
		pos.x += x;
		pos.y += y;
		target.transform.position = pos;
	}

	public override void Begin ()
	{

	}

	public override bool IsFinished ()
	{
		return true;
	}
}

