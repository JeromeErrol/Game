using UnityEngine;
using System.Collections;

public class Collectable : PlayerInteractive
{

		public override void CollisionWithPlayer (Player player)
		{
			CollectedBy (player);
			GameObject.Destroy (gameObject);
		}

		public virtual void CollectedBy(Player player){

		}
}

