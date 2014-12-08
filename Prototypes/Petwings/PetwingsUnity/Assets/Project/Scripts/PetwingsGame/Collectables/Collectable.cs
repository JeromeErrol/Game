using UnityEngine;
using System.Collections;
using Petwings.Engine.Base;

namespace Petwings.Game.Collectables
{
	public class Collectable : PlayerInteractive
	{
		protected override void CollisionWithPlayer (Player player)
		{
			GameObject.Destroy (gameObject);
		}
	}
}

