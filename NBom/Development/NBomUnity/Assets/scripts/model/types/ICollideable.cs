
using System;
using UnityEngine;

public class ICollideable: MonoBehaviour
{
		public ICollideable ()
		{
			
		}

		public virtual void CollidedWith(RocketShip rocketShip){
			throw new NotImplementedException ();
		}
}


