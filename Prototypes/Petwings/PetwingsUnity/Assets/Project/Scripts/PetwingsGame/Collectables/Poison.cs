using UnityEngine;
using System.Collections;
using Petwings.Engine.Base;

namespace Petwings.Game.Collectables
{
		public class Poison : PlayerInteractive
		{
				protected override void CollisionWithPlayer (Player player)
				{
						player.Dazzle ();
						GameObject.Destroy (gameObject);
				}
		}
}

