using UnityEngine;
using System.Collections;

namespace Petwings.Engine.Base
{
		public abstract class PlayerInteractive : MonoBehaviour
		{
				void OnTriggerEnter2D (Collider2D collider2D)
				{		
						Player player = collider2D.GetComponent<Player> ();
						if (player != null) {
								CollisionWithPlayer (player);
						}
				}

				protected abstract void CollisionWithPlayer (Player player);
		}
}

