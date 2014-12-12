using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				Player player = collider2D.GetComponent<Player> ();
				if (player != null) {
						player.Die ();
				}
		}
}

