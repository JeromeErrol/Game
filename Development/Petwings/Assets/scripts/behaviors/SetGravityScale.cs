using UnityEngine;
using System.Collections;

public class SetGravityScale : InstructionRunOnce
{
	public GameObject target;
	public float gravityScale;

	public override void Begin ()
	{
		base.Begin ();
	}

	public override void RunOnce ()
	{
		target.rigidbody2D.gravityScale = gravityScale;
	}

}

