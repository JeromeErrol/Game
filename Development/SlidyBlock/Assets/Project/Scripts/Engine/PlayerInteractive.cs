using UnityEngine;
using System.Collections;

public abstract class PlayerInteractive : MonoBehaviour
{
		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				Player player = collider2D.gameObject.GetComponent<Player> ();
				if (player != null) {
						PlayerEntered (player);
				}
		}

		public abstract void PlayerEntered (Player player);
}

