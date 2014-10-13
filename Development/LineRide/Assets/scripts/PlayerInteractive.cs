using UnityEngine;
using System.Collections;

public class PlayerInteractive : MonoBehaviour
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
			if (collider2D.gameObject.GetComponent<Player> ()) {
				CollisionWithPlayer(collider2D.gameObject.GetComponent<Player> ());
			}
		}				
	}

	public virtual void CollisionWithPlayer (Player player){

	}
}

