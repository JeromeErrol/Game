using UnityEngine;
using System.Collections;
using GameUtil2D;

public class FlowBall : IOverlap
{
	public Quaternion rotation;
	public float strength;

	public override void OverlapTriggered (RocketShip rocketShip)
	{
		PhysicsUtil2D.ApplyDirectedForce (rocketShip.rigidbody2D, rotation, strength);
	}
}

