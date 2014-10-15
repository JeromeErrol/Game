using UnityEngine;
using System.Collections;

public class Collectable : PlayerInteractive
{

		public override void PlayerEnter (Player player)
		{
			CollectedBy (player);
			GameObject.Destroy (gameObject);
		}

		public virtual void CollectedBy(Player player){

		}
}

