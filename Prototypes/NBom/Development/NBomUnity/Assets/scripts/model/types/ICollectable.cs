using UnityEngine;
using System.Collections;
using System;

public class ICollectable : ICollideable {

	public override void CollidedWith (RocketShip rocketShip)
	{
		CollectedBy (rocketShip);
		MonoBehaviour.Destroy (gameObject);
	}

	public virtual void CollectedBy(RocketShip rocketShip){
		throw new NotImplementedException ();
	}

}
