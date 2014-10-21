using UnityEngine;
using System.Collections;

public class ActivateOnCollision : MonoBehaviour
{

	void OnTriggerEnter2D (Collider2D collider2D)
	{				
		GameObject gameObj = collider2D.gameObject;


		if (gameObj.GetComponent<PolygonCollider2D> () != null) {
			gameObj.GetComponent<PolygonCollider2D> ().enabled = true;
		}

		if (gameObj.GetComponent<BoxCollider2D> () != null) {
			gameObj.GetComponent<BoxCollider2D> ().enabled = true;
		}

		if (gameObj.GetComponent<CircleCollider2D> () != null) {
			gameObj.GetComponent<CircleCollider2D> ().enabled = true;
		}
	}
}

