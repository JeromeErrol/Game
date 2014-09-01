using UnityEngine;
using System.Collections;

public class IHurt : ICollideable {

	public override void CollidedWith (RocketShip rocketShip)
	{
		Destroy (rocketShip.gameObject);
	}
}
