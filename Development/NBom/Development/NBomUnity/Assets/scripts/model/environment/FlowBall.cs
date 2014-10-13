using UnityEngine;
using System.Collections;
using GameUtil2D;


public class FlowBall : IOverlap
{
	public float strength;

	public override void OverlapTriggered (RocketShip rocketShip)
	{
		PhysicsUtil2D.ApplyDirectedForce (rocketShip.rigidbody2D, gameObject.transform.rotation, strength);
	}

	public override void ExitTriggered (RocketShip gameObject)
	{

	}
}

