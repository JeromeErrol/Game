using UnityEngine;
using System.Collections;

public class TeleportUpgrade : ICollectable
{
		public override void CollectedBy (RocketShip rocketShip)
		{
				if (rocketShip.GetComponents<Teleport>() == null) {
					Teleport teleport = rocketShip.gameObject.AddComponent<Teleport>();
				} 
		}
}

