using UnityEngine;
using System.Collections;
using UnityUtil.Extensions;

public class Collectable : MonoBehaviour
{
		private bool missed = false;

		void FixedUpdate ()
		{
				if (!missed) {
						CheckIfMissed ();
				}
		}
		
		void CheckIfMissed ()
		{
				if (transform.position.x < Player.GameObject.transform.position.x) {
						Missed ();
				}
		}
    
		void Missed ()
		{
				missed = true;
				GameObject.Destroy (gameObject);
		}

		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				Player player = collider2D.GetComponent<Player> ();
				if (player != null) {
						Collected ();
				}
		}
	
		void Collected ()
		{
				CollectablesManager.IncrementStreakAndAddToScore ();
				GameObject.Destroy (gameObject);
		}
}

