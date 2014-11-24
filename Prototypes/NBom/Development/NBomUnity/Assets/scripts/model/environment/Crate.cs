using System;
using UnityEngine;

public class Crate:ICollideable
{
		public Crate ()
		{
		}

		public override void CollidedWith (RocketShip rocketShip)
		{
			Shield shield = rocketShip.GetComponent<Shield> ();
			if (shield.Active) {
					Break ();
				} else {
					gameObject.GetComponent<Collider2D>().isTrigger = false;
				}
		}

		public void Break(){
			Destroy (gameObject);
		}
}


