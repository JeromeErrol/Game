using UnityEngine;
using System.Collections;

public class SetRotationalVelocity : InstructionRunOnce
{
	public GameObject2D gameObject2D;
	public float velocity;
	
	public override void RunOnce ()
	{
		gameObject2D.rotationVelocity = velocity;
	}
}