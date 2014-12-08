using UnityEngine;
using System.Collections;

namespace Petwings.Engine.Base
{
		public class Obstacle : PlayerInteractive
		{
				protected override void CollisionWithPlayer (Player player)
				{
						this.Break ();
						player.Die ();
				}
        
				public void Break ()
				{
						GameObject.Destroy (gameObject);
				}
		}
}
