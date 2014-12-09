using UnityEngine;
using System.Collections;
using Petwings.Engine.Base;
using BaseEngine.Extensions;

namespace Petwings.Game.Collectables
{
		public class Collectable : PlayerInteractive
		{
				public AudioClip sound;

				protected override void CollisionWithPlayer (Player player)
				{
						if (sound != null) {
								SoundLibrary.Play (sound);
						}
						Collected ();
						GameObject.Destroy (gameObject);
				}
		
				public virtual void Collected ()
				{

				}
		}
}

