using UnityEngine;
using System.Collections;

public class ChargeThrusterUpgrade : ICollectable
{
		public override void CollectedBy (RocketShip rocketShip)
		{
				ChargeThruster chargeThruster = rocketShip.gameObject.GetComponent<ChargeThruster> ();
				if (chargeThruster == null) {
					chargeThruster = rocketShip.gameObject.AddComponent<ChargeThruster> ();
				} else {
					chargeThruster.level++;	
				}

		}
}

