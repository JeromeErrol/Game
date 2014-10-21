using UnityEngine;
using System.Collections;

public class DeactivateOnCollision : MonoBehaviour
{

	void OnTriggerEnter2D (Collider2D collider2D)
	{				
		GameObject gameObj = collider2D.gameObject;
		
		
		if (gameObj.GetComponent<PolygonCollider2D> () != null) {
			gameObj.GetComponent<PolygonCollider2D> ().enabled = false;
		}
		
		if (gameObj.GetComponent<BoxCollider2D> () != null) {
			gameObj.GetComponent<BoxCollider2D> ().enabled = false;
		}
		
		if (gameObj.GetComponent<CircleCollider2D> () != null) {
			gameObj.GetComponent<CircleCollider2D> ().enabled = false;
		}
	}
}

