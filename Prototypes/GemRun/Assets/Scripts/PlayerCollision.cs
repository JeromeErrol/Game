using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
		private bool sameFrame = false;
		
	
		void Update ()
		{
				sameFrame = false;
		}
	
		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				if (!sameFrame) {
						sameFrame = true;
						Ring ring = collider2D.gameObject.GetComponent<Ring> ();
						if (collider2D.gameObject.GetComponent<Ring> ()) {
								CollideWithRing (ring);
						}
				}				
		}
		
		void OnTriggerStay2D (Collider2D collider2D)
		{		
				if (!sameFrame) {
						sameFrame = true;
						Ring ring = collider2D.gameObject.GetComponent<Ring> ();
						if (collider2D.gameObject.GetComponent<Ring> ()) {
								CollideWithRing (ring);
						}
				}				
		}
	
		void CollideWithRing (Ring ring)
		{
				if (ring.level < Player.instance.level) {
						Player.instance.CollectRing (ring);
				} else {
						Player.instance.Die ();
				}
		}

		
}

