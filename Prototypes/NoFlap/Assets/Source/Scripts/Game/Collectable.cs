using UnityEngine;
using System.Collections;
using UnityUtil.Extensions;

public class Collectable : MonoBehaviour
{
		private bool missed = false;
		private bool collected = false;

		void FixedUpdate ()
		{
				if (!collected && !missed) {
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
				CollectablesManager.ResetCollectionStreak ();
				GetComponent<PlayMakerFSM> ().SendEvent ("Miss");
		}

		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				if (collected == false) {
						Player player = collider2D.GetComponent<Player> ();
						if (player != null) {
								Collected ();
						}
				}
		}
	
		void Collected ()
		{
				collected = true;
				CollectablesManager.IncrementStreakAndAddToScore ();
				GetComponent<PlayMakerFSM> ().SendEvent ("Collect");
		}
}

