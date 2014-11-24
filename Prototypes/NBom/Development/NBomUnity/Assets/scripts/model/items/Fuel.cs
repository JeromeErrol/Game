using UnityEngine;
using System.Collections;

public class Fuel:ICollectable
{
		public float percentFilled;

		public override void CollectedBy (RocketShip rocketShip)
		{
				FuelTank fuelTank = rocketShip.GetComponent<FuelTank> ();				
				float amount = fuelTank.Capacity * percentFilled;
				fuelTank.Refill (amount);
		}		
}


