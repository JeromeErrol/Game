using UnityEngine;
using System.Collections;
using Petwings.Engine.Base;

namespace Petwings.Game.Obstacles
{
		public class Barrel : PlayerInteractive
		{
				Animator anim;

				void Start ()
				{
						anim = GetComponent<Animator> ();
				}

				public void Explode ()
				{
						anim.SetTrigger ("explode");
				}

				protected override void CollisionWithPlayer (Player player)
				{
						Explode ();
						player.Die ();
				}

				public void Remove ()
				{
						GameObject.Destroy (gameObject);
				}
		}
}
