using UnityEngine;
using System.Collections;
using System;

public class ITriggerListener:MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D collider2D)
	{		
		ICollideable collideable = collider2D.gameObject.GetComponent<ICollideable> ();
		if (collideable) {
			// collideable.CollidedWith (gameObject);
		}
	}
	
	void OnTriggerExit2D (Collider2D col)
	{			
		IOverlap overlap = col.gameObject.GetComponent<IOverlap> ();
		if (overlap) {
			// overlap.ExitTriggered(gameObject);
		}
	}
	
	void OnTriggerStay2D (Collider2D col)
	{
		IOverlap overlap = col.gameObject.GetComponent<IOverlap> ();
		if (overlap) {
			// overlap.OverlapTriggered (gameObject);
		}
	}
}


