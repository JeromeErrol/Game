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
				PlayerEnter(collider2D.gameObject.GetComponent<Player> ());
			}
		}				
	}

	void OnTriggerStay2D(Collider2D collider2D){
		if (collider2D.gameObject.GetComponent<Player> ()) {
			PlayerStay(collider2D.gameObject.GetComponent<Player> ());
		}
	}

	void OnTriggerExit2D(Collider2D collider2D){
		if (collider2D.gameObject.GetComponent<Player> ()) {
			PlayerExit(collider2D.gameObject.GetComponent<Player> ());
		}
	}

	public virtual void PlayerStay(Player player){

	}
	
	public virtual void PlayerExit(Player player){
		
	}

	public virtual void PlayerEnter (Player player){

	}
}

