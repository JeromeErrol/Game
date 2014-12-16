using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				if (collider2D.gameObject.GetComponent<Player> () != null) {
						GameFSM.RestartLevel ();
				}
		}
}
