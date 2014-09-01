using UnityEngine;
using System.Collections;

public class Fuel:ICollectable
{
		public float percentFilled;

		public Fuel ()
		{

		}

		public override void CollectedBy (RocketShip rocketShip)
		{
				float amount = rocketShip.fuelTank.Capacity * percentFilled;
				rocketShip.fuelTank.Refill (amount);
		}		
}


